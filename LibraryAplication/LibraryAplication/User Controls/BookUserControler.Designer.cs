namespace LibraryAplication.User_Controls
{
    partial class BookUserControler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUserControler));
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBookTitle.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelBookTitle.Location = new System.Drawing.Point(19, 140);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(100, 26);
            this.labelBookTitle.TabIndex = 1;
            this.labelBookTitle.Text = "BookTitle";
            this.labelBookTitle.Click += new System.EventHandler(this.labelBookTitle_Click);
            this.labelBookTitle.MouseLeave += new System.EventHandler(this.labelBookTitle_MouseLeave);
            this.labelBookTitle.MouseHover += new System.EventHandler(this.labelBookTitle_MouseHover);
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAuthorName.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelAuthorName.Location = new System.Drawing.Point(7, 166);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(130, 26);
            this.labelAuthorName.TabIndex = 1;
            this.labelAuthorName.Text = "AuthorName";
            this.labelAuthorName.Click += new System.EventHandler(this.labelBookTitle_Click);
            this.labelAuthorName.MouseLeave += new System.EventHandler(this.labelBookTitle_MouseLeave);
            this.labelAuthorName.MouseHover += new System.EventHandler(this.labelBookTitle_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.labelBookTitle_Click);
            // 
            // BookUserControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BookUserControler";
            this.Size = new System.Drawing.Size(142, 203);
            this.Load += new System.EventHandler(this.BookUserControler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelAuthorName;
    }
}
