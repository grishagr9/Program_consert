using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_concert
{
    public partial class CreatorForm : Form
    {
        public Track track = new Track();
        public CreatorForm()
        {
            InitializeComponent();
            checkedList.CheckOnClick = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Track track = new Track();
            track.name = nameBox1.Text;
            track.genre = checkedList.CheckedItems.Cast<string>().ToList();
            track.time = timeBox2.Text;
            if (timeBox2.Text == "")
            {
                track.time_seconds = 0;
                track.time = "0:0";
            }

            else
            {
                track.time = timeBox2.Text;
                track.time_seconds = track.toSeconds(track.time);
            }
                
            this.track = track;
            nameBox1.Text = "";    
            
        }
    }
}
