namespace LibraryAplication
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.panelTopSideAddBook = new System.Windows.Forms.Panel();
            this.labelAddBooks = new System.Windows.Forms.Label();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.btnCategoryPanel = new System.Windows.Forms.Button();
            this.btnAuthorPanel = new System.Windows.Forms.Button();
            this.btnCategoryLoad = new System.Windows.Forms.Button();
            this.openFileDialogBookCover = new System.Windows.Forms.OpenFileDialog();
            this.btnAddCover = new System.Windows.Forms.Button();
            this.panelAuthorControl = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearSelectedAuthors = new System.Windows.Forms.Button();
            this.btnaddAtuhorFromComboBox = new System.Windows.Forms.Button();
            this.textBoxSelectedAuthors = new System.Windows.Forms.TextBox();
            this.pictureBoxCopies = new System.Windows.Forms.PictureBox();
            this.pictureBoxBookTitle = new System.Windows.Forms.PictureBox();
            this.pictureBoxISBN = new System.Windows.Forms.PictureBox();
            this.comboBoxCategiries = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.label_categories = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_Publisher = new System.Windows.Forms.Label();
            this.label_numberOfCopies = new System.Windows.Forms.Label();
            this.label_BookTitle = new System.Windows.Forms.Label();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.textBox_Publisher = new System.Windows.Forms.TextBox();
            this.textBox_Copies = new System.Windows.Forms.TextBox();
            this.textBox_BookTitle = new System.Windows.Forms.TextBox();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.btnAuthorLoad = new System.Windows.Forms.Button();
            this.panelCategoryControler = new System.Windows.Forms.Panel();
            this.panelTopSideAddBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopSideAddBook
            // 
            this.panelTopSideAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.panelTopSideAddBook.Controls.Add(this.labelAddBooks);
            this.panelTopSideAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSideAddBook.Location = new System.Drawing.Point(0, 0);
            this.panelTopSideAddBook.Name = "panelTopSideAddBook";
            this.panelTopSideAddBook.Size = new System.Drawing.Size(688, 56);
            this.panelTopSideAddBook.TabIndex = 4;
            // 
            // labelAddBooks
            // 
            this.labelAddBooks.AutoSize = true;
            this.labelAddBooks.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBooks.ForeColor = System.Drawing.Color.White;
            this.labelAddBooks.Location = new System.Drawing.Point(85, 9);
            this.labelAddBooks.Name = "labelAddBooks";
            this.labelAddBooks.Size = new System.Drawing.Size(141, 33);
            this.labelAddBooks.TabIndex = 10;
            this.labelAddBooks.Text = "Add Books";
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(196, 370);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(75, 23);
            this.btn_AddBook.TabIndex = 11;
            this.btn_AddBook.Text = "Add Book";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // btnCategoryPanel
            // 
            this.btnCategoryPanel.Location = new System.Drawing.Point(252, 220);
            this.btnCategoryPanel.Name = "btnCategoryPanel";
            this.btnCategoryPanel.Size = new System.Drawing.Size(99, 23);
            this.btnCategoryPanel.TabIndex = 14;
            this.btnCategoryPanel.Text = "Category Panel";
            this.btnCategoryPanel.UseVisualStyleBackColor = true;
            this.btnCategoryPanel.Click += new System.EventHandler(this.btnCategoryPanel_Click);
            // 
            // btnAuthorPanel
            // 
            this.btnAuthorPanel.Location = new System.Drawing.Point(252, 249);
            this.btnAuthorPanel.Name = "btnAuthorPanel";
            this.btnAuthorPanel.Size = new System.Drawing.Size(99, 23);
            this.btnAuthorPanel.TabIndex = 14;
            this.btnAuthorPanel.Text = "Author Panel";
            this.btnAuthorPanel.UseVisualStyleBackColor = true;
            this.btnAuthorPanel.Click += new System.EventHandler(this.btnAuthorPanel_Click);
            // 
            // btnCategoryLoad
            // 
            this.btnCategoryLoad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCategoryLoad.Location = new System.Drawing.Point(523, 450);
            this.btnCategoryLoad.Name = "btnCategoryLoad";
            this.btnCategoryLoad.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryLoad.TabIndex = 20;
            this.btnCategoryLoad.Text = "Load";
            this.btnCategoryLoad.UseVisualStyleBackColor = true;
            this.btnCategoryLoad.Visible = false;
            this.btnCategoryLoad.Click += new System.EventHandler(this.buttonCategoryLoad_Click);
            // 
            // openFileDialogBookCover
            // 
            this.openFileDialogBookCover.FileName = "openFileDialog1";
            // 
            // btnAddCover
            // 
            this.btnAddCover.Location = new System.Drawing.Point(252, 191);
            this.btnAddCover.Name = "btnAddCover";
            this.btnAddCover.Size = new System.Drawing.Size(97, 23);
            this.btnAddCover.TabIndex = 25;
            this.btnAddCover.Text = "Add Cover";
            this.btnAddCover.UseVisualStyleBackColor = true;
            this.btnAddCover.Click += new System.EventHandler(this.btnAddCover_Click);
            // 
            // panelAuthorControl
            // 
            this.panelAuthorControl.AutoSize = true;
            this.panelAuthorControl.Location = new System.Drawing.Point(413, 59);
            this.panelAuthorControl.Name = "panelAuthorControl";
            this.panelAuthorControl.Size = new System.Drawing.Size(185, 213);
            this.panelAuthorControl.TabIndex = 28;
            this.panelAuthorControl.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearSelectedAuthors);
            this.groupBox1.Controls.Add(this.btnaddAtuhorFromComboBox);
            this.groupBox1.Controls.Add(this.textBoxSelectedAuthors);
            this.groupBox1.Controls.Add(this.pictureBoxCopies);
            this.groupBox1.Controls.Add(this.pictureBoxBookTitle);
            this.groupBox1.Controls.Add(this.pictureBoxISBN);
            this.groupBox1.Controls.Add(this.comboBoxCategiries);
            this.groupBox1.Controls.Add(this.comboBoxAuthors);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.labelAuthor);
            this.groupBox1.Controls.Add(this.label_categories);
            this.groupBox1.Controls.Add(this.label_date);
            this.groupBox1.Controls.Add(this.label_Publisher);
            this.groupBox1.Controls.Add(this.label_numberOfCopies);
            this.groupBox1.Controls.Add(this.label_BookTitle);
            this.groupBox1.Controls.Add(this.label_ISBN);
            this.groupBox1.Controls.Add(this.textBox_Publisher);
            this.groupBox1.Controls.Add(this.textBox_Copies);
            this.groupBox1.Controls.Add(this.textBox_BookTitle);
            this.groupBox1.Controls.Add(this.textBox_ISBN);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 273);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // btnClearSelectedAuthors
            // 
            this.btnClearSelectedAuthors.Location = new System.Drawing.Point(191, 219);
            this.btnClearSelectedAuthors.Name = "btnClearSelectedAuthors";
            this.btnClearSelectedAuthors.Size = new System.Drawing.Size(43, 23);
            this.btnClearSelectedAuthors.TabIndex = 45;
            this.btnClearSelectedAuthors.Text = "Clear";
            this.btnClearSelectedAuthors.UseVisualStyleBackColor = true;
            this.btnClearSelectedAuthors.Click += new System.EventHandler(this.btnClearSelectedAuthors_Click);
            // 
            // btnaddAtuhorFromComboBox
            // 
            this.btnaddAtuhorFromComboBox.Location = new System.Drawing.Point(193, 189);
            this.btnaddAtuhorFromComboBox.Name = "btnaddAtuhorFromComboBox";
            this.btnaddAtuhorFromComboBox.Size = new System.Drawing.Size(35, 23);
            this.btnaddAtuhorFromComboBox.TabIndex = 44;
            this.btnaddAtuhorFromComboBox.Text = "Add";
            this.btnaddAtuhorFromComboBox.UseVisualStyleBackColor = true;
            this.btnaddAtuhorFromComboBox.Click += new System.EventHandler(this.btnaddAtuhorFromComboBox_Click);
            // 
            // textBoxSelectedAuthors
            // 
            this.textBoxSelectedAuthors.Location = new System.Drawing.Point(86, 219);
            this.textBoxSelectedAuthors.Multiline = true;
            this.textBoxSelectedAuthors.Name = "textBoxSelectedAuthors";
            this.textBoxSelectedAuthors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSelectedAuthors.Size = new System.Drawing.Size(100, 40);
            this.textBoxSelectedAuthors.TabIndex = 43;
            // 
            // pictureBoxCopies
            // 
            this.pictureBoxCopies.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCopies.Image")));
            this.pictureBoxCopies.Location = new System.Drawing.Point(192, 81);
            this.pictureBoxCopies.Name = "pictureBoxCopies";
            this.pictureBoxCopies.Size = new System.Drawing.Size(26, 17);
            this.pictureBoxCopies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCopies.TabIndex = 42;
            this.pictureBoxCopies.TabStop = false;
            this.pictureBoxCopies.Tag = "";
            this.pictureBoxCopies.Visible = false;
            // 
            // pictureBoxBookTitle
            // 
            this.pictureBoxBookTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookTitle.Image")));
            this.pictureBoxBookTitle.Location = new System.Drawing.Point(192, 56);
            this.pictureBoxBookTitle.Name = "pictureBoxBookTitle";
            this.pictureBoxBookTitle.Size = new System.Drawing.Size(26, 17);
            this.pictureBoxBookTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookTitle.TabIndex = 42;
            this.pictureBoxBookTitle.TabStop = false;
            this.pictureBoxBookTitle.Tag = "";
            this.pictureBoxBookTitle.Visible = false;
            // 
            // pictureBoxISBN
            // 
            this.pictureBoxISBN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxISBN.Image")));
            this.pictureBoxISBN.Location = new System.Drawing.Point(192, 30);
            this.pictureBoxISBN.Name = "pictureBoxISBN";
            this.pictureBoxISBN.Size = new System.Drawing.Size(26, 17);
            this.pictureBoxISBN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxISBN.TabIndex = 42;
            this.pictureBoxISBN.TabStop = false;
            this.pictureBoxISBN.Tag = "";
            this.pictureBoxISBN.Visible = false;
            // 
            // comboBoxCategiries
            // 
            this.comboBoxCategiries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategiries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategiries.FormattingEnabled = true;
            this.comboBoxCategiries.Location = new System.Drawing.Point(86, 163);
            this.comboBoxCategiries.Name = "comboBoxCategiries";
            this.comboBoxCategiries.Size = new System.Drawing.Size(99, 21);
            this.comboBoxCategiries.TabIndex = 41;
            this.comboBoxCategiries.Text = " ";
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAuthors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(87, 192);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(99, 21);
            this.comboBoxAuthors.TabIndex = 41;
            this.comboBoxAuthors.Text = " ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(14, 200);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 36;
            this.labelAuthor.Text = "Author";
            // 
            // label_categories
            // 
            this.label_categories.AutoSize = true;
            this.label_categories.Location = new System.Drawing.Point(14, 163);
            this.label_categories.Name = "label_categories";
            this.label_categories.Size = new System.Drawing.Size(49, 13);
            this.label_categories.TabIndex = 37;
            this.label_categories.Text = "Category";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(14, 137);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 38;
            this.label_date.Text = "Date";
            // 
            // label_Publisher
            // 
            this.label_Publisher.AutoSize = true;
            this.label_Publisher.Location = new System.Drawing.Point(14, 114);
            this.label_Publisher.Name = "label_Publisher";
            this.label_Publisher.Size = new System.Drawing.Size(50, 13);
            this.label_Publisher.TabIndex = 39;
            this.label_Publisher.Text = "Publisher";
            // 
            // label_numberOfCopies
            // 
            this.label_numberOfCopies.AutoSize = true;
            this.label_numberOfCopies.Location = new System.Drawing.Point(14, 88);
            this.label_numberOfCopies.Name = "label_numberOfCopies";
            this.label_numberOfCopies.Size = new System.Drawing.Size(39, 13);
            this.label_numberOfCopies.TabIndex = 40;
            this.label_numberOfCopies.Text = "Copies";
            // 
            // label_BookTitle
            // 
            this.label_BookTitle.AutoSize = true;
            this.label_BookTitle.Location = new System.Drawing.Point(14, 60);
            this.label_BookTitle.Name = "label_BookTitle";
            this.label_BookTitle.Size = new System.Drawing.Size(52, 13);
            this.label_BookTitle.TabIndex = 34;
            this.label_BookTitle.Text = "BookTitle";
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Location = new System.Drawing.Point(14, 34);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(32, 13);
            this.label_ISBN.TabIndex = 35;
            this.label_ISBN.Tag = "";
            this.label_ISBN.Text = "ISBN";
            // 
            // textBox_Publisher
            // 
            this.textBox_Publisher.Location = new System.Drawing.Point(86, 107);
            this.textBox_Publisher.Name = "textBox_Publisher";
            this.textBox_Publisher.Size = new System.Drawing.Size(100, 20);
            this.textBox_Publisher.TabIndex = 31;
            // 
            // textBox_Copies
            // 
            this.textBox_Copies.Location = new System.Drawing.Point(86, 81);
            this.textBox_Copies.Name = "textBox_Copies";
            this.textBox_Copies.Size = new System.Drawing.Size(100, 20);
            this.textBox_Copies.TabIndex = 30;
            this.textBox_Copies.TextChanged += new System.EventHandler(this.textBox_Copies_TextChanged);
            // 
            // textBox_BookTitle
            // 
            this.textBox_BookTitle.Location = new System.Drawing.Point(86, 57);
            this.textBox_BookTitle.Name = "textBox_BookTitle";
            this.textBox_BookTitle.Size = new System.Drawing.Size(100, 20);
            this.textBox_BookTitle.TabIndex = 29;
            this.textBox_BookTitle.TextChanged += new System.EventHandler(this.textBox_BookTitle_TextChanged);
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(86, 31);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(100, 20);
            this.textBox_ISBN.TabIndex = 28;
            this.textBox_ISBN.TextChanged += new System.EventHandler(this.textBox_ISBN_TextChanged);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Image = global::LibraryAplication.Properties.Resources.LibraryNoImage;
            this.pictureBoxCover.Location = new System.Drawing.Point(249, 70);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(100, 108);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 24;
            this.pictureBoxCover.TabStop = false;
            // 
            // btnAuthorLoad
            // 
            this.btnAuthorLoad.Location = new System.Drawing.Point(511, 450);
            this.btnAuthorLoad.Name = "btnAuthorLoad";
            this.btnAuthorLoad.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorLoad.TabIndex = 30;
            this.btnAuthorLoad.Text = "Load";
            this.btnAuthorLoad.UseVisualStyleBackColor = true;
            this.btnAuthorLoad.Visible = false;
            this.btnAuthorLoad.Click += new System.EventHandler(this.btnAuthorLoad_Click);
            // 
            // panelCategoryControler
            // 
            this.panelCategoryControler.AutoSize = true;
            this.panelCategoryControler.Location = new System.Drawing.Point(398, 62);
            this.panelCategoryControler.Name = "panelCategoryControler";
            this.panelCategoryControler.Size = new System.Drawing.Size(188, 184);
            this.panelCategoryControler.TabIndex = 31;
            this.panelCategoryControler.Visible = false;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(688, 490);
            this.Controls.Add(this.panelCategoryControler);
            this.Controls.Add(this.btnAuthorLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelAuthorControl);
            this.Controls.Add(this.btnAddCover);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.btnCategoryLoad);
            this.Controls.Add(this.btnAuthorPanel);
            this.Controls.Add(this.btnCategoryPanel);
            this.Controls.Add(this.panelTopSideAddBook);
            this.Controls.Add(this.btn_AddBook);
            this.Name = "AddBookForm";
            this.Text = "Author";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.panelTopSideAddBook.ResumeLayout(false);
            this.panelTopSideAddBook.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSideAddBook;
        private System.Windows.Forms.Label labelAddBooks;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button btnCategoryPanel;
        private System.Windows.Forms.Button btnAuthorPanel;
        private System.Windows.Forms.Button btnCategoryLoad;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.OpenFileDialog openFileDialogBookCover;
        private System.Windows.Forms.Button btnAddCover;
        private System.Windows.Forms.Panel panelAuthorControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label label_categories;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_Publisher;
        private System.Windows.Forms.Label label_numberOfCopies;
        private System.Windows.Forms.Label label_BookTitle;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.TextBox textBox_Publisher;
        private System.Windows.Forms.TextBox textBox_Copies;
        private System.Windows.Forms.TextBox textBox_BookTitle;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.PictureBox pictureBoxISBN;
        private System.Windows.Forms.PictureBox pictureBoxBookTitle;
        private System.Windows.Forms.PictureBox pictureBoxCopies;
        private System.Windows.Forms.ComboBox comboBoxCategiries;
        private System.Windows.Forms.Button btnAuthorLoad;
        private System.Windows.Forms.Button btnaddAtuhorFromComboBox;
        private System.Windows.Forms.TextBox textBoxSelectedAuthors;
        private System.Windows.Forms.Button btnClearSelectedAuthors;
        private System.Windows.Forms.Panel panelCategoryControler;
    }
}