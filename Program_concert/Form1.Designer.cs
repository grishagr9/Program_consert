namespace Program_concert
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьНомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьНомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.считатьИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сТаймингомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безТаймингаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLow = new System.Windows.Forms.TextBox();
            this.checkArm = new System.Windows.Forms.CheckBox();
            this.checkNeo = new System.Windows.Forms.CheckBox();
            this.checkClassic = new System.Windows.Forms.CheckBox();
            this.checkRock = new System.Windows.Forms.CheckBox();
            this.checkEngPop = new System.Windows.Forms.CheckBox();
            this.checkRus = new System.Windows.Forms.CheckBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CountTime = new System.Windows.Forms.Button();
            this.CountSecondsLabel = new System.Windows.Forms.Label();
            this.SaveFileLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНомерToolStripMenuItem,
            this.создатьПрограммуToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьНомерToolStripMenuItem
            // 
            this.добавитьНомерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьНомерToolStripMenuItem,
            this.считатьИзФайлаToolStripMenuItem});
            this.добавитьНомерToolStripMenuItem.Name = "добавитьНомерToolStripMenuItem";
            this.добавитьНомерToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.добавитьНомерToolStripMenuItem.Text = "Добавить номер";
            // 
            // выбратьНомерToolStripMenuItem
            // 
            this.выбратьНомерToolStripMenuItem.Name = "выбратьНомерToolStripMenuItem";
            this.выбратьНомерToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выбратьНомерToolStripMenuItem.Text = "Вручную";
            this.выбратьНомерToolStripMenuItem.Click += new System.EventHandler(this.выбратьНомерToolStripMenuItem_Click);
            // 
            // считатьИзФайлаToolStripMenuItem
            // 
            this.считатьИзФайлаToolStripMenuItem.Name = "считатьИзФайлаToolStripMenuItem";
            this.считатьИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.считатьИзФайлаToolStripMenuItem.Text = "Считать из файла";
            this.считатьИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.считатьИзФайлаToolStripMenuItem_Click);
            // 
            // создатьПрограммуToolStripMenuItem
            // 
            this.создатьПрограммуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьФайлToolStripMenuItem});
            this.создатьПрограммуToolStripMenuItem.Name = "создатьПрограммуToolStripMenuItem";
            this.создатьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.создатьПрограммуToolStripMenuItem.Text = "Создать программу";
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сТаймингомToolStripMenuItem,
            this.безТаймингаToolStripMenuItem});
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            // 
            // сТаймингомToolStripMenuItem
            // 
            this.сТаймингомToolStripMenuItem.Name = "сТаймингомToolStripMenuItem";
            this.сТаймингомToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сТаймингомToolStripMenuItem.Text = "С таймингом";
            this.сТаймингомToolStripMenuItem.Click += new System.EventHandler(this.сТаймингомToolStripMenuItem_Click);
            // 
            // безТаймингаToolStripMenuItem
            // 
            this.безТаймингаToolStripMenuItem.Name = "безТаймингаToolStripMenuItem";
            this.безТаймингаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.безТаймингаToolStripMenuItem.Text = "Без тайминга";
            this.безТаймингаToolStripMenuItem.Click += new System.EventHandler(this.безТаймингаToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxUp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxLow);
            this.groupBox1.Controls.Add(this.checkArm);
            this.groupBox1.Controls.Add(this.checkNeo);
            this.groupBox1.Controls.Add(this.checkClassic);
            this.groupBox1.Controls.Add(this.checkRock);
            this.groupBox1.Controls.Add(this.checkEngPop);
            this.groupBox1.Controls.Add(this.checkRus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(375, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 255);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "от";
            // 
            // textBoxUp
            // 
            this.textBoxUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUp.Location = new System.Drawing.Point(134, 211);
            this.textBoxUp.Name = "textBoxUp";
            this.textBoxUp.Size = new System.Drawing.Size(51, 22);
            this.textBoxUp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Длительность в секундах";
            // 
            // textBoxLow
            // 
            this.textBoxLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLow.Location = new System.Drawing.Point(35, 211);
            this.textBoxLow.Name = "textBoxLow";
            this.textBoxLow.Size = new System.Drawing.Size(47, 22);
            this.textBoxLow.TabIndex = 6;
            // 
            // checkArm
            // 
            this.checkArm.AutoSize = true;
            this.checkArm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkArm.Location = new System.Drawing.Point(6, 151);
            this.checkArm.Name = "checkArm";
            this.checkArm.Size = new System.Drawing.Size(76, 20);
            this.checkArm.TabIndex = 5;
            this.checkArm.Text = "Кавказ";
            this.checkArm.UseVisualStyleBackColor = true;
            // 
            // checkNeo
            // 
            this.checkNeo.AutoSize = true;
            this.checkNeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkNeo.Location = new System.Drawing.Point(6, 125);
            this.checkNeo.Name = "checkNeo";
            this.checkNeo.Size = new System.Drawing.Size(115, 20);
            this.checkNeo.TabIndex = 4;
            this.checkNeo.Text = "Неоклассика";
            this.checkNeo.UseVisualStyleBackColor = true;
            // 
            // checkClassic
            // 
            this.checkClassic.AutoSize = true;
            this.checkClassic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkClassic.Location = new System.Drawing.Point(6, 99);
            this.checkClassic.Name = "checkClassic";
            this.checkClassic.Size = new System.Drawing.Size(90, 20);
            this.checkClassic.TabIndex = 3;
            this.checkClassic.Text = "Классика";
            this.checkClassic.UseVisualStyleBackColor = true;
            // 
            // checkRock
            // 
            this.checkRock.AutoSize = true;
            this.checkRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRock.Location = new System.Drawing.Point(6, 73);
            this.checkRock.Name = "checkRock";
            this.checkRock.Size = new System.Drawing.Size(53, 20);
            this.checkRock.TabIndex = 2;
            this.checkRock.Text = "Рок";
            this.checkRock.UseVisualStyleBackColor = true;
            // 
            // checkEngPop
            // 
            this.checkEngPop.AutoSize = true;
            this.checkEngPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkEngPop.Location = new System.Drawing.Point(6, 47);
            this.checkEngPop.Name = "checkEngPop";
            this.checkEngPop.Size = new System.Drawing.Size(162, 20);
            this.checkEngPop.TabIndex = 1;
            this.checkEngPop.Text = "Песни - зарубежные";
            this.checkEngPop.UseVisualStyleBackColor = true;
            // 
            // checkRus
            // 
            this.checkRus.AutoSize = true;
            this.checkRus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRus.Location = new System.Drawing.Point(6, 21);
            this.checkRus.Name = "checkRus";
            this.checkRus.Size = new System.Drawing.Size(133, 20);
            this.checkRus.TabIndex = 0;
            this.checkRus.Text = "Песни - русские";
            this.checkRus.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(375, 292);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(214, 58);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "Показать треки";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 420);
            this.listBox1.TabIndex = 5;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(601, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(326, 420);
            this.listBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CountTime
            // 
            this.CountTime.Location = new System.Drawing.Point(481, 356);
            this.CountTime.Name = "CountTime";
            this.CountTime.Size = new System.Drawing.Size(108, 40);
            this.CountTime.TabIndex = 9;
            this.CountTime.Text = "Рассчитать время";
            this.CountTime.UseVisualStyleBackColor = true;
            this.CountTime.Click += new System.EventHandler(this.CountTime_Click);
            // 
            // CountSecondsLabel
            // 
            this.CountSecondsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountSecondsLabel.AutoSize = true;
            this.CountSecondsLabel.Location = new System.Drawing.Point(506, 408);
            this.CountSecondsLabel.Name = "CountSecondsLabel";
            this.CountSecondsLabel.Size = new System.Drawing.Size(44, 16);
            this.CountSecondsLabel.TabIndex = 10;
            this.CountSecondsLabel.Text = "label4";
            // 
            // SaveFileLabel
            // 
            this.SaveFileLabel.AutoSize = true;
            this.SaveFileLabel.Location = new System.Drawing.Point(382, 408);
            this.SaveFileLabel.Name = "SaveFileLabel";
            this.SaveFileLabel.Size = new System.Drawing.Size(44, 16);
            this.SaveFileLabel.TabIndex = 11;
            this.SaveFileLabel.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 470);
            this.Controls.Add(this.SaveFileLabel);
            this.Controls.Add(this.CountSecondsLabel);
            this.Controls.Add(this.CountTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьНомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьНомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem считатьИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПрограммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сТаймингомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безТаймингаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkRus;
        private System.Windows.Forms.CheckBox checkRock;
        private System.Windows.Forms.CheckBox checkEngPop;
        private System.Windows.Forms.CheckBox checkArm;
        private System.Windows.Forms.CheckBox checkNeo;
        private System.Windows.Forms.CheckBox checkClassic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLow;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CountTime;
        private System.Windows.Forms.Label CountSecondsLabel;
        private System.Windows.Forms.Label SaveFileLabel;
    }
}

