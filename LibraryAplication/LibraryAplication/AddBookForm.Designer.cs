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
            this.panelTopSideAddBook = new System.Windows.Forms.Panel();
            this.labelAddBooks = new System.Windows.Forms.Label();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.label_BookTitle = new System.Windows.Forms.Label();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.textBox_BookTitle = new System.Windows.Forms.TextBox();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.label_numberOfCopies = new System.Windows.Forms.Label();
            this.textBox_Copies = new System.Windows.Forms.TextBox();
            this.textBox_Publisher = new System.Windows.Forms.TextBox();
            this.label_Publisher = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddCategories = new System.Windows.Forms.Button();
            this.btnAddAuthors = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnCategoryLoad = new System.Windows.Forms.Button();
            this.textBoxAddCategories = new System.Windows.Forms.TextBox();
            this.label_cagegories = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialogBookCover = new System.Windows.Forms.OpenFileDialog();
            this.btnAddCover = new System.Windows.Forms.Button();
            this.categoriesList1 = new LibraryAplication.User_Controls.CategoriesList();
            this.panelTopSideAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopSideAddBook
            // 
            this.panelTopSideAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.panelTopSideAddBook.Controls.Add(this.labelAddBooks);
            this.panelTopSideAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSideAddBook.Location = new System.Drawing.Point(0, 0);
            this.panelTopSideAddBook.Name = "panelTopSideAddBook";
            this.panelTopSideAddBook.Size = new System.Drawing.Size(919, 56);
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
            this.btn_AddBook.Location = new System.Drawing.Point(91, 328);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(75, 23);
            this.btn_AddBook.TabIndex = 11;
            this.btn_AddBook.Text = "Add";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // label_BookTitle
            // 
            this.label_BookTitle.AutoSize = true;
            this.label_BookTitle.Location = new System.Drawing.Point(35, 137);
            this.label_BookTitle.Name = "label_BookTitle";
            this.label_BookTitle.Size = new System.Drawing.Size(52, 13);
            this.label_BookTitle.TabIndex = 9;
            this.label_BookTitle.Text = "BookTitle";
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Location = new System.Drawing.Point(35, 111);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(32, 13);
            this.label_ISBN.TabIndex = 10;
            this.label_ISBN.Text = "ISBN";
            // 
            // textBox_BookTitle
            // 
            this.textBox_BookTitle.Location = new System.Drawing.Point(107, 134);
            this.textBox_BookTitle.Name = "textBox_BookTitle";
            this.textBox_BookTitle.Size = new System.Drawing.Size(100, 20);
            this.textBox_BookTitle.TabIndex = 6;
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(107, 108);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(100, 20);
            this.textBox_ISBN.TabIndex = 7;
            // 
            // label_numberOfCopies
            // 
            this.label_numberOfCopies.AutoSize = true;
            this.label_numberOfCopies.Location = new System.Drawing.Point(35, 165);
            this.label_numberOfCopies.Name = "label_numberOfCopies";
            this.label_numberOfCopies.Size = new System.Drawing.Size(39, 13);
            this.label_numberOfCopies.TabIndex = 12;
            this.label_numberOfCopies.Text = "Copies";
            // 
            // textBox_Copies
            // 
            this.textBox_Copies.Location = new System.Drawing.Point(107, 158);
            this.textBox_Copies.Name = "textBox_Copies";
            this.textBox_Copies.Size = new System.Drawing.Size(100, 20);
            this.textBox_Copies.TabIndex = 6;
            // 
            // textBox_Publisher
            // 
            this.textBox_Publisher.Location = new System.Drawing.Point(107, 184);
            this.textBox_Publisher.Name = "textBox_Publisher";
            this.textBox_Publisher.Size = new System.Drawing.Size(100, 20);
            this.textBox_Publisher.TabIndex = 6;
            // 
            // label_Publisher
            // 
            this.label_Publisher.AutoSize = true;
            this.label_Publisher.Location = new System.Drawing.Point(35, 191);
            this.label_Publisher.Name = "label_Publisher";
            this.label_Publisher.Size = new System.Drawing.Size(50, 13);
            this.label_Publisher.TabIndex = 12;
            this.label_Publisher.Text = "Publisher";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.Location = new System.Drawing.Point(228, 240);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.Size = new System.Drawing.Size(99, 23);
            this.btnAddCategories.TabIndex = 14;
            this.btnAddCategories.Text = "Cagegory Panel";
            this.btnAddCategories.UseVisualStyleBackColor = true;
            this.btnAddCategories.Click += new System.EventHandler(this.btnAddCategories_Click);
            // 
            // btnAddAuthors
            // 
            this.btnAddAuthors.Location = new System.Drawing.Point(228, 269);
            this.btnAddAuthors.Name = "btnAddAuthors";
            this.btnAddAuthors.Size = new System.Drawing.Size(99, 23);
            this.btnAddAuthors.TabIndex = 14;
            this.btnAddAuthors.Text = "Add  Authors";
            this.btnAddAuthors.UseVisualStyleBackColor = true;
            this.btnAddAuthors.Click += new System.EventHandler(this.btnAddAuthors_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(35, 214);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 12;
            this.label_date.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 242);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(22, 519);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 16;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnCategoryLoad
            // 
            this.btnCategoryLoad.Location = new System.Drawing.Point(634, 408);
            this.btnCategoryLoad.Name = "btnCategoryLoad";
            this.btnCategoryLoad.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryLoad.TabIndex = 20;
            this.btnCategoryLoad.Text = "Load";
            this.btnCategoryLoad.UseVisualStyleBackColor = true;
            this.btnCategoryLoad.Visible = false;
            this.btnCategoryLoad.Click += new System.EventHandler(this.buttonCategoryLoad_Click);
            // 
            // textBoxAddCategories
            // 
            this.textBoxAddCategories.Location = new System.Drawing.Point(107, 240);
            this.textBoxAddCategories.Name = "textBoxAddCategories";
            this.textBoxAddCategories.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCategories.TabIndex = 21;
            // 
            // label_cagegories
            // 
            this.label_cagegories.AutoSize = true;
            this.label_cagegories.Location = new System.Drawing.Point(35, 240);
            this.label_cagegories.Name = "label_cagegories";
            this.label_cagegories.Size = new System.Drawing.Size(52, 13);
            this.label_cagegories.TabIndex = 12;
            this.label_cagegories.Text = "Cagegory";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "test1",
            "dsadsa",
            "ana",
            "are ",
            "mere"});
            this.comboBox1.Location = new System.Drawing.Point(796, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryAplication.Properties.Resources.LibraryNoImage;
            this.pictureBox1.Location = new System.Drawing.Point(358, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialogBookCover
            // 
            this.openFileDialogBookCover.FileName = "openFileDialog1";
            // 
            // btnAddCover
            // 
            this.btnAddCover.Location = new System.Drawing.Point(368, 198);
            this.btnAddCover.Name = "btnAddCover";
            this.btnAddCover.Size = new System.Drawing.Size(75, 23);
            this.btnAddCover.TabIndex = 25;
            this.btnAddCover.Text = "Add Cover";
            this.btnAddCover.UseVisualStyleBackColor = true;
            this.btnAddCover.Click += new System.EventHandler(this.btnAddCover_Click);
            // 
            // categoriesList1
            // 
            this.categoriesList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(178)))), ((int)(((byte)(180)))));
            this.categoriesList1.Location = new System.Drawing.Point(547, 53);
            this.categoriesList1.Name = "categoriesList1";
            this.categoriesList1.Size = new System.Drawing.Size(243, 388);
            this.categoriesList1.TabIndex = 18;
            this.categoriesList1.Visible = false;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(919, 662);
            this.Controls.Add(this.btnAddCover);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxAddCategories);
            this.Controls.Add(this.btnCategoryLoad);
            this.Controls.Add(this.categoriesList1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddAuthors);
            this.Controls.Add(this.btnAddCategories);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_cagegories);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_Publisher);
            this.Controls.Add(this.label_numberOfCopies);
            this.Controls.Add(this.panelTopSideAddBook);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.label_BookTitle);
            this.Controls.Add(this.label_ISBN);
            this.Controls.Add(this.textBox_Publisher);
            this.Controls.Add(this.textBox_Copies);
            this.Controls.Add(this.textBox_BookTitle);
            this.Controls.Add(this.textBox_ISBN);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.panelTopSideAddBook.ResumeLayout(false);
            this.panelTopSideAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSideAddBook;
        private System.Windows.Forms.Label labelAddBooks;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Label label_BookTitle;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.TextBox textBox_BookTitle;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.Label label_numberOfCopies;
        private System.Windows.Forms.TextBox textBox_Copies;
        private System.Windows.Forms.TextBox textBox_Publisher;
        private System.Windows.Forms.Label label_Publisher;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddCategories;
        private System.Windows.Forms.Button btnAddAuthors;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDisplay;
        private User_Controls.CategoriesList categoriesList1;
        private System.Windows.Forms.Button btnCategoryLoad;
        private System.Windows.Forms.TextBox textBoxAddCategories;
        private System.Windows.Forms.Label label_cagegories;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialogBookCover;
        private System.Windows.Forms.Button btnAddCover;
    }
}