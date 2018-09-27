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
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearchbar = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAuthorId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(75, 308);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthorName.TabIndex = 6;
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(3, 315);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(69, 13);
            this.labelAuthorName.TabIndex = 7;
            this.labelAuthorName.Text = "AuthorName:";
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
            this.PanelAuthors.Location = new System.Drawing.Point(6, 39);
            this.PanelAuthors.Name = "PanelAuthors";
            this.PanelAuthors.Size = new System.Drawing.Size(141, 243);
            this.PanelAuthors.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(167, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearchbar
            // 
            this.textBoxSearchbar.Location = new System.Drawing.Point(19, 13);
            this.textBoxSearchbar.Name = "textBoxSearchbar";
            this.textBoxSearchbar.Size = new System.Drawing.Size(142, 20);
            this.textBoxSearchbar.TabIndex = 12;
            this.textBoxSearchbar.TextChanged += new System.EventHandler(this.textBoxSearchbar_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(83, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Author ID:";
            // 
            // textBoxAuthorId
            // 
            this.textBoxAuthorId.Enabled = false;
            this.textBoxAuthorId.Location = new System.Drawing.Point(75, 285);
            this.textBoxAuthorId.Name = "textBoxAuthorId";
            this.textBoxAuthorId.Size = new System.Drawing.Size(42, 20);
            this.textBoxAuthorId.TabIndex = 16;
            // 
            // AuthorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(178)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.textBoxAuthorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearchbar);
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
        private System.Windows.Forms.Button btnNewAuthor;
        private System.Windows.Forms.FlowLayoutPanel PanelAuthors;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearchbar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAuthorId;
    }
}
