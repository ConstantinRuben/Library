namespace LibraryAplication
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panelTopSideAddBook = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Settings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_Theme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_PredefinedDays = new System.Windows.Forms.Label();
            this.textBox_Predefined_Days = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTopSideAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopSideAddBook
            // 
            this.panelTopSideAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.panelTopSideAddBook.Controls.Add(this.pictureBox1);
            this.panelTopSideAddBook.Controls.Add(this.label_Settings);
            this.panelTopSideAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSideAddBook.Location = new System.Drawing.Point(0, 0);
            this.panelTopSideAddBook.Name = "panelTopSideAddBook";
            this.panelTopSideAddBook.Size = new System.Drawing.Size(795, 56);
            this.panelTopSideAddBook.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label_Settings
            // 
            this.label_Settings.AutoSize = true;
            this.label_Settings.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Settings.ForeColor = System.Drawing.Color.White;
            this.label_Settings.Location = new System.Drawing.Point(45, 9);
            this.label_Settings.Name = "label_Settings";
            this.label_Settings.Size = new System.Drawing.Size(111, 33);
            this.label_Settings.TabIndex = 10;
            this.label_Settings.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(38, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "TO DO";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(425, 325);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 95);
            this.richTextBox1.TabIndex = 59;
            this.richTextBox1.Text = "CLASIC DARK WHITE\nREMOVE LIBRARY HISTORY\nPREDEFINDE NUMBER OF DAYS FOR REZERVATIO" +
    "N\n\nCUSTOM CATEGORIES LIST FOR MAIN FORM\n";
            // 
            // label_Theme
            // 
            this.label_Theme.AutoSize = true;
            this.label_Theme.BackColor = System.Drawing.Color.Transparent;
            this.label_Theme.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Theme.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_Theme.Location = new System.Drawing.Point(38, 153);
            this.label_Theme.Name = "label_Theme";
            this.label_Theme.Size = new System.Drawing.Size(77, 23);
            this.label_Theme.TabIndex = 58;
            this.label_Theme.Text = "Theme:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(196, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 60;
            this.label3.Click += new System.EventHandler(this.ChangeThemeColorFromtLabel_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(196, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 23);
            this.label7.TabIndex = 60;
            this.label7.Click += new System.EventHandler(this.ChangeThemeColorFromtLabel_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(152, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 60;
            this.label2.Click += new System.EventHandler(this.ChangeThemeColorFromtLabel_Click);
            // 
            // label_PredefinedDays
            // 
            this.label_PredefinedDays.AutoSize = true;
            this.label_PredefinedDays.BackColor = System.Drawing.Color.Transparent;
            this.label_PredefinedDays.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PredefinedDays.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_PredefinedDays.Location = new System.Drawing.Point(12, 397);
            this.label_PredefinedDays.Name = "label_PredefinedDays";
            this.label_PredefinedDays.Size = new System.Drawing.Size(276, 23);
            this.label_PredefinedDays.TabIndex = 58;
            this.label_PredefinedDays.Text = "Default Days For Rezervation:";
            // 
            // textBox_Predefined_Days
            // 
            this.textBox_Predefined_Days.Location = new System.Drawing.Point(294, 401);
            this.textBox_Predefined_Days.Name = "textBox_Predefined_Days";
            this.textBox_Predefined_Days.Size = new System.Drawing.Size(53, 20);
            this.textBox_Predefined_Days.TabIndex = 61;
            this.textBox_Predefined_Days.Text = "10";
            this.textBox_Predefined_Days.TextChanged += new System.EventHandler(this.textBox_Predefined_Days_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(44)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(152, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 23);
            this.label4.TabIndex = 60;
            this.label4.Click += new System.EventHandler(this.ChangeThemeColorFromtLabel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 444);
            this.Controls.Add(this.textBox_Predefined_Days);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_PredefinedDays);
            this.Controls.Add(this.label_Theme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTopSideAddBook);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panelTopSideAddBook.ResumeLayout(false);
            this.panelTopSideAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSideAddBook;
        private System.Windows.Forms.Label label_Settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_Theme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_PredefinedDays;
        private System.Windows.Forms.TextBox textBox_Predefined_Days;
        private System.Windows.Forms.Label label4;
    }
}