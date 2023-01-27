namespace Program_concert
{
    partial class CreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveButton = new System.Windows.Forms.Button();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.timeBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(198, 114);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(294, 60);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameBox1
            // 
            this.nameBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox1.Location = new System.Drawing.Point(198, 51);
            this.nameBox1.Multiline = true;
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(180, 57);
            this.nameBox1.TabIndex = 1;
            // 
            // timeBox2
            // 
            this.timeBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeBox2.Location = new System.Drawing.Point(382, 51);
            this.timeBox2.Multiline = true;
            this.timeBox2.Name = "timeBox2";
            this.timeBox2.Size = new System.Drawing.Size(110, 57);
            this.timeBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(377, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время";
            // 
            // checkedList
            // 
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Items.AddRange(new object[] {
            "Песни - русские",
            "Песни - зарубежные",
            "Рок",
            "Классика",
            "Неоклассика",
            "Кавказ"});
            this.checkedList.Location = new System.Drawing.Point(12, 51);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(180, 123);
            this.checkedList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Жанр";
            // 
            // CreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 187);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeBox2);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.SaveButton);
            this.Name = "CreatorForm";
            this.Text = "Создание номера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.TextBox timeBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.Label label3;
    }
}