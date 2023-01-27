using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_concert
{
    public enum Genre{ Rus, Eng, Rock, Classic, Neoclassic, Arm }
    public partial class Form1 : Form
    {
        CreatorForm creatorForm = null;
        string path = "../../tracks.txt";
        private HashSet<Track> tracks = new HashSet<Track>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private List<string> newTracks = new List<string>();
        public Form1()
        {
            InitializeComponent();
            SaveFileLabel.Visible = false;
            CountSecondsLabel.Visible=false;
            load_file(path);
            checkBoxes.Add(checkRus);
            checkBoxes.Add(checkEngPop);
            checkBoxes.Add(checkRock);
            checkBoxes.Add(checkClassic);
            checkBoxes.Add(checkNeo);
            checkBoxes.Add(checkArm);
        }
        /// <summary>
        /// добавляем в список весь репертуар
        /// </summary>
        /// <param name="path"></param>
        private void load_file(string path)
        {
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                Track track = new Track(line);
                tracks.Add(track);
            }
        }

        /// <summary>
        /// создаем новую форму-конструктор трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выбратьНомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creatorForm = new CreatorForm();
            creatorForm.Show();
            creatorForm.SaveButton.Click += new System.EventHandler(Form2_FormClosed);
            SaveFileLabel.Visible = true;
            SaveFileLabel.ForeColor = Color.Red;
            SaveFileLabel.Text = "не сохранено";
        }

        /// <summary>
        /// сохранение созданного трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosed(object sender, EventArgs e)
        {
            Track newTrack = creatorForm.track;
            tracks.Add(newTrack);
        }

        /// <summary>
        /// Читает из файла плейлиста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void считатьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Файлы с программой(*.txt) | *.txt";
            fileDialog.Multiselect = false;
            fileDialog.Title = "Выбор файла с программой концерта";
            
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = fileDialog.FileName;
            var fileText = File.ReadAllLines(path);
            foreach (var line in fileText)
                listBox1.Items.Add(line.Substring(1));
        }

        /// <summary>
        /// показывает все подходящие треки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonView_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HashSet<Track> tracksFromFiltr = new HashSet<Track>();
            List<string> genreFiltr = new List<string>();
            int up;
            int low;
            try
            {
                low = int.Parse(textBoxLow.Text);
                up = int.Parse(textBoxUp.Text);
            }
            catch (Exception) {
                low = 0;
                up = 1000;
            }
            foreach (CheckBox item in checkBoxes)
            {
                if(item.Checked)
                    genreFiltr.Add(item.Text);
            }
            foreach (Track track in tracks)
            {
                if (track.time_seconds >= low && track.time_seconds <= up)
                    if (ContainGenre(track.genre, genreFiltr))
                    {
                        tracksFromFiltr.Add(track);
                        listBox1.Items.Add(track.name + "~" + track.time);
                    }
            }
            
        }

        /// <summary>
        /// проверка, есть ли треки данного жанра
        /// </summary>
        /// <param name="l1">Все треки</param>
        /// <param name="l2">Жанры,отмеченные галочкой</param>
        /// <returns></returns>
        private bool ContainGenre(List<string> l1, List<string> l2)
        {
            if (l2.Count == 0)
                return true;
            foreach(var it in l2)
            {
                if(l1.Contains(it))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// добавляет выбранные треки в колонку справа и в список новых треков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            { 
                var selected = listBox1.SelectedItem;
                if (selected == null) return;
                listBox2.Items.Add(selected.ToString());
                newTracks.Add(selected.ToString());
            }
            catch
            {
                Console.WriteLine("listBox1_MouseDoubleClick error");
            }
        }

        /// <summary>
        /// Полностью очищает все поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            textBoxLow.Clear();
            textBoxUp.Clear();
            CountSecondsLabel.Visible= false;
        }

        /// <summary>
        /// обрабатывает нажатие кнопки C ТАЙМИНГОМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сТаймингомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNewProgramm(true, newTracks);
        }

        /// <summary>
        /// обрабатывает нажатие кнопки БЕЗ ТАЙМИНГА
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void безТаймингаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNewProgramm(false, newTracks);
        }

        /// <summary>
        /// Сохраняет плейлист в файл
        /// </summary>
        /// <param name="timeOn">нужно ли писать время в файле</param>
        /// <param name="tracks">треки для нового плейлиста</param>
        private void SaveNewProgramm(bool timeOn, List<string> tracks)
        {
            List<string> newTracksToFile = new List<string>();
            int count = 1;
            foreach(string track in tracks)
            {
                if(timeOn)
                    newTracksToFile.Add(count++ + " " + track);
                else
                    newTracksToFile.Add(count++ + " " + track.Split('~')[0]);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
            //saveFileDialog.FileName = "program.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            File.WriteAllLines(saveFileDialog.FileName, newTracksToFile);
            MessageBox.Show("Файл сохранен");
        }

        /// <summary>
        /// Сохранение добавленного репертуара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> toFile = new List<string>();
            foreach (Track track in tracks)
                toFile.Add(track.ToString());
            File.Delete(path);
            File.WriteAllLines(path, toFile);
            SaveFileLabel.Visible = false;
        }

        /// <summary>
        /// Рассчитать сколько длится новый плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountTime_Click(object sender, EventArgs e)
        {
            int seconds = 0;
            foreach (var it in newTracks)
                seconds += int.Parse(it.Split('~')[1].Split(':')[0])*60 + int.Parse(it.Split('~')[1].Split(':')[1]);
            CountSecondsLabel.Visible = true;
            
            CountSecondsLabel.Text = seconds.ToString() + " секунд\n" + $"{seconds/60}:{seconds%60} минут";

        }
    }
}
