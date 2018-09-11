namespace LibraryAplication.User_Controls
{
    partial class AuthorsList
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
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.PanelAuthors = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(83, 288);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthorName.TabIndex = 6;
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(3, 288);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(66, 13);
            this.labelAuthorName.TabIndex = 7;
            this.labelAuthorName.Text = "AuthorName";
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.Location = new System.Drawing.Point(83, 328);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnNewAuthor.TabIndex = 10;
            this.btnNewAuthor.Text = "NewAuthor";
            this.btnNewAuthor.UseVisualStyleBackColor = true;
            this.btnNewAuthor.Click += new System.EventHandler(this.btnNewAuthor_Click);
            // 
            // PanelAuthors
            // 
            this.PanelAuthors.AutoScroll = true;
            this.PanelAuthors.Location = new System.Drawing.Point(27, 42);
            this.PanelAuthors.Name = "PanelAuthors";
            this.PanelAuthors.Size = new System.Drawing.Size(131, 185);
            this.PanelAuthors.TabIndex = 11;
            // 
            // AuthorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(178)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.PanelAuthors);
            this.Controls.Add(this.btnNewAuthor);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.textBoxAuthorName);
            this.Name = "AuthorsList";
            this.Size = new System.Drawing.Size(245, 392);
            this.Load += new System.EventHandler(this.AuthorsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNewAuthor;
        private System.Windows.Forms.FlowLayoutPanel PanelAuthors;
    }
}
