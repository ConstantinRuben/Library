namespace LibraryAplication
{
    partial class AdvancedSearchForm
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
            this.panelTopSideAddBook = new System.Windows.Forms.Panel();
            this.label_AdvancedSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_BookTitle = new System.Windows.Forms.Label();
            this.textBox_BookTitle = new System.Windows.Forms.TextBox();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_SearchResult = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTopSideAddBook.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopSideAddBook
            // 
            this.panelTopSideAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.panelTopSideAddBook.Controls.Add(this.label_AdvancedSearch);
            this.panelTopSideAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSideAddBook.Location = new System.Drawing.Point(0, 0);
            this.panelTopSideAddBook.Name = "panelTopSideAddBook";
            this.panelTopSideAddBook.Size = new System.Drawing.Size(927, 56);
            this.panelTopSideAddBook.TabIndex = 6;
            // 
            // label_AdvancedSearch
            // 
            this.label_AdvancedSearch.AutoSize = true;
            this.label_AdvancedSearch.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AdvancedSearch.ForeColor = System.Drawing.Color.White;
            this.label_AdvancedSearch.Location = new System.Drawing.Point(12, 9);
            this.label_AdvancedSearch.Name = "label_AdvancedSearch";
            this.label_AdvancedSearch.Size = new System.Drawing.Size(214, 33);
            this.label_AdvancedSearch.TabIndex = 10;
            this.label_AdvancedSearch.Text = "Advanced Search";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_BookTitle);
            this.panel1.Controls.Add(this.textBox_BookTitle);
            this.panel1.Controls.Add(this.label_ISBN);
            this.panel1.Controls.Add(this.textBox_ISBN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 569);
            this.panel1.TabIndex = 7;
            // 
            // label_BookTitle
            // 
            this.label_BookTitle.AutoSize = true;
            this.label_BookTitle.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookTitle.Location = new System.Drawing.Point(12, 107);
            this.label_BookTitle.Name = "label_BookTitle";
            this.label_BookTitle.Size = new System.Drawing.Size(104, 23);
            this.label_BookTitle.TabIndex = 47;
            this.label_BookTitle.Text = "Book Title :";
            // 
            // textBox_BookTitle
            // 
            this.textBox_BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BookTitle.Location = new System.Drawing.Point(125, 103);
            this.textBox_BookTitle.Name = "textBox_BookTitle";
            this.textBox_BookTitle.Size = new System.Drawing.Size(170, 29);
            this.textBox_BookTitle.TabIndex = 46;
            this.textBox_BookTitle.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ISBN.Location = new System.Drawing.Point(12, 52);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(61, 23);
            this.label_ISBN.TabIndex = 47;
            this.label_ISBN.Text = "ISBN :";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ISBN.Location = new System.Drawing.Point(125, 48);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(170, 29);
            this.textBox_ISBN.TabIndex = 46;
            this.textBox_ISBN.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // flowLayoutPanel_SearchResult
            // 
            this.flowLayoutPanel_SearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_SearchResult.Location = new System.Drawing.Point(300, 56);
            this.flowLayoutPanel_SearchResult.Name = "flowLayoutPanel_SearchResult";
            this.flowLayoutPanel_SearchResult.Size = new System.Drawing.Size(627, 569);
            this.flowLayoutPanel_SearchResult.TabIndex = 8;
            // 
            // AdvancedSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 625);
            this.Controls.Add(this.flowLayoutPanel_SearchResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTopSideAddBook);
            this.Name = "AdvancedSearchForm";
            this.Text = "AdvancedSearchForm";
            this.panelTopSideAddBook.ResumeLayout(false);
            this.panelTopSideAddBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSideAddBook;
        private System.Windows.Forms.Label label_AdvancedSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SearchResult;
        private System.Windows.Forms.Label label_BookTitle;
        private System.Windows.Forms.TextBox textBox_BookTitle;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.TextBox textBox_ISBN;
    }
}