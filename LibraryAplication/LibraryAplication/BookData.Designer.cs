namespace LibraryAplication
{
    partial class BookData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookData));
            this.textBoxAddCategories = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_cagegories = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_Publisher = new System.Windows.Forms.Label();
            this.label_TotalNumberOfCopies = new System.Windows.Forms.Label();
            this.label_BookTitle = new System.Windows.Forms.Label();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.textBox_Publisher = new System.Windows.Forms.TextBox();
            this.textBox_TotalCopies = new System.Windows.Forms.TextBox();
            this.textBox_BookTitle = new System.Windows.Forms.TextBox();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChangeCover = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBoxCopies = new System.Windows.Forms.PictureBox();
            this.pictureBoxBookTitle = new System.Windows.Forms.PictureBox();
            this.pictureBoxISBN = new System.Windows.Forms.PictureBox();
            this.openFileDialogBookCover = new System.Windows.Forms.OpenFileDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox_CopiesLeft = new System.Windows.Forms.TextBox();
            this.label_NumberOfCopiesLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxISBN)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddCategories
            // 
            this.textBoxAddCategories.Enabled = false;
            this.textBoxAddCategories.Location = new System.Drawing.Point(123, 309);
            this.textBoxAddCategories.Name = "textBoxAddCategories";
            this.textBoxAddCategories.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCategories.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 283);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // label_cagegories
            // 
            this.label_cagegories.AutoSize = true;
            this.label_cagegories.Location = new System.Drawing.Point(51, 309);
            this.label_cagegories.Name = "label_cagegories";
            this.label_cagegories.Size = new System.Drawing.Size(52, 13);
            this.label_cagegories.TabIndex = 28;
            this.label_cagegories.Text = "Cagegory";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(51, 283);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 29;
            this.label_date.Text = "Date";
            // 
            // label_Publisher
            // 
            this.label_Publisher.AutoSize = true;
            this.label_Publisher.Location = new System.Drawing.Point(51, 260);
            this.label_Publisher.Name = "label_Publisher";
            this.label_Publisher.Size = new System.Drawing.Size(50, 13);
            this.label_Publisher.TabIndex = 30;
            this.label_Publisher.Text = "Publisher";
            // 
            // label_TotalNumberOfCopies
            // 
            this.label_TotalNumberOfCopies.AutoSize = true;
            this.label_TotalNumberOfCopies.Location = new System.Drawing.Point(49, 207);
            this.label_TotalNumberOfCopies.Name = "label_TotalNumberOfCopies";
            this.label_TotalNumberOfCopies.Size = new System.Drawing.Size(66, 13);
            this.label_TotalNumberOfCopies.TabIndex = 31;
            this.label_TotalNumberOfCopies.Text = "Total Copies";
            // 
            // label_BookTitle
            // 
            this.label_BookTitle.AutoSize = true;
            this.label_BookTitle.Location = new System.Drawing.Point(49, 178);
            this.label_BookTitle.Name = "label_BookTitle";
            this.label_BookTitle.Size = new System.Drawing.Size(52, 13);
            this.label_BookTitle.TabIndex = 26;
            this.label_BookTitle.Text = "BookTitle";
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Location = new System.Drawing.Point(49, 152);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(32, 13);
            this.label_ISBN.TabIndex = 27;
            this.label_ISBN.Text = "ISBN";
            // 
            // textBox_Publisher
            // 
            this.textBox_Publisher.Enabled = false;
            this.textBox_Publisher.Location = new System.Drawing.Point(123, 253);
            this.textBox_Publisher.Name = "textBox_Publisher";
            this.textBox_Publisher.Size = new System.Drawing.Size(100, 20);
            this.textBox_Publisher.TabIndex = 22;
            // 
            // textBox_TotalCopies
            // 
            this.textBox_TotalCopies.Enabled = false;
            this.textBox_TotalCopies.Location = new System.Drawing.Point(121, 199);
            this.textBox_TotalCopies.Name = "textBox_TotalCopies";
            this.textBox_TotalCopies.Size = new System.Drawing.Size(100, 20);
            this.textBox_TotalCopies.TabIndex = 23;
            this.textBox_TotalCopies.TextChanged += new System.EventHandler(this.textBox_Copies_TextChanged);
            // 
            // textBox_BookTitle
            // 
            this.textBox_BookTitle.Enabled = false;
            this.textBox_BookTitle.Location = new System.Drawing.Point(121, 175);
            this.textBox_BookTitle.Name = "textBox_BookTitle";
            this.textBox_BookTitle.Size = new System.Drawing.Size(100, 20);
            this.textBox_BookTitle.TabIndex = 24;
            this.textBox_BookTitle.TextChanged += new System.EventHandler(this.textBox_BookTitle_TextChanged);
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Enabled = false;
            this.textBox_ISBN.Location = new System.Drawing.Point(121, 149);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(100, 20);
            this.textBox_ISBN.TabIndex = 25;
            this.textBox_ISBN.TextChanged += new System.EventHandler(this.textBox_ISBN_TextChanged);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Image = global::LibraryAplication.Properties.Resources.LibraryNoImage;
            this.pictureBoxCover.Location = new System.Drawing.Point(52, 26);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(100, 108);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 34;
            this.pictureBoxCover.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(157, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChangeCover
            // 
            this.btnChangeCover.Location = new System.Drawing.Point(158, 64);
            this.btnChangeCover.Name = "btnChangeCover";
            this.btnChangeCover.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCover.TabIndex = 37;
            this.btnChangeCover.Text = "Change";
            this.btnChangeCover.UseVisualStyleBackColor = true;
            this.btnChangeCover.Visible = false;
            this.btnChangeCover.Click += new System.EventHandler(this.btnChangeCover_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Enabled = false;
            this.textBoxAuthor.Location = new System.Drawing.Point(124, 339);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAuthor.Size = new System.Drawing.Size(131, 42);
            this.textBoxAuthor.TabIndex = 38;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAuthor.Location = new System.Drawing.Point(60, 342);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 39;
            this.labelAuthor.Text = "Author";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(63, 387);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBoxCopies
            // 
            this.pictureBoxCopies.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCopies.Image")));
            this.pictureBoxCopies.Location = new System.Drawing.Point(227, 203);
            this.pictureBoxCopies.Name = "pictureBoxCopies";
            this.pictureBoxCopies.Size = new System.Drawing.Size(26, 17);
            this.pictureBoxCopies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCopies.TabIndex = 43;
            this.pictureBoxCopies.TabStop = false;
            this.pictureBoxCopies.Tag = "";
            this.pictureBoxCopies.Visible = false;
            // 
            // pictureBoxBookTitle
            // 
            this.pictureBoxBookTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookTitle.Image")));
            this.pictureBoxBookTitle.Location = new System.Drawing.Point(227, 178);
            this.pictureBoxBookTitle.Name = "pictureBoxBookTitle";
            this.pictureBoxBookTitle.Size = new System.Drawing.Size(26, 17);
            this.pictureBoxBookTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookTitle.TabIndex = 44;
            this.pictureBoxBookTitle.TabStop = false;
            this.pictureBoxBookTitle.Tag = "";
            this.pictureBoxBookTitle.Visible = false;
            // 
            // pictureBoxISBN
            // 
            this.pictureBoxISBN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxISBN.Image")));
            this.pictureBoxISBN.Location = new System.Drawing.Point(227, 152);
            this.pictureBoxISBN.Name = "pictureBoxISBN";
            this.pictureBoxISBN.Size = new System.Drawing.Size(26, 17);
            this.pictureBoxISBN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxISBN.TabIndex = 45;
            this.pictureBoxISBN.TabStop = false;
            this.pictureBoxISBN.Tag = "";
            this.pictureBoxISBN.Visible = false;
            // 
            // openFileDialogBookCover
            // 
            this.openFileDialogBookCover.FileName = "openFileDialog1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(134, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox_CopiesLeft
            // 
            this.textBox_CopiesLeft.Enabled = false;
            this.textBox_CopiesLeft.Location = new System.Drawing.Point(123, 225);
            this.textBox_CopiesLeft.Name = "textBox_CopiesLeft";
            this.textBox_CopiesLeft.Size = new System.Drawing.Size(100, 20);
            this.textBox_CopiesLeft.TabIndex = 23;
            // 
            // label_NumberOfCopiesLeft
            // 
            this.label_NumberOfCopiesLeft.AutoSize = true;
            this.label_NumberOfCopiesLeft.Location = new System.Drawing.Point(49, 232);
            this.label_NumberOfCopiesLeft.Name = "label_NumberOfCopiesLeft";
            this.label_NumberOfCopiesLeft.Size = new System.Drawing.Size(60, 13);
            this.label_NumberOfCopiesLeft.TabIndex = 31;
            this.label_NumberOfCopiesLeft.Text = "Copies Left";
            // 
            // BookData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 443);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBoxCopies);
            this.Controls.Add(this.pictureBoxBookTitle);
            this.Controls.Add(this.pictureBoxISBN);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.btnChangeCover);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.textBoxAddCategories);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_cagegories);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_Publisher);
            this.Controls.Add(this.label_NumberOfCopiesLeft);
            this.Controls.Add(this.label_TotalNumberOfCopies);
            this.Controls.Add(this.label_BookTitle);
            this.Controls.Add(this.label_ISBN);
            this.Controls.Add(this.textBox_Publisher);
            this.Controls.Add(this.textBox_CopiesLeft);
            this.Controls.Add(this.textBox_TotalCopies);
            this.Controls.Add(this.textBox_BookTitle);
            this.Controls.Add(this.textBox_ISBN);
            this.Name = "BookData";
            this.Text = "BookData";
            this.Load += new System.EventHandler(this.BookData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxISBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddCategories;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_cagegories;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_Publisher;
        private System.Windows.Forms.Label label_TotalNumberOfCopies;
        private System.Windows.Forms.Label label_BookTitle;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.TextBox textBox_Publisher;
        private System.Windows.Forms.TextBox textBox_TotalCopies;
        private System.Windows.Forms.TextBox textBox_BookTitle;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangeCover;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pictureBoxCopies;
        private System.Windows.Forms.PictureBox pictureBoxBookTitle;
        private System.Windows.Forms.PictureBox pictureBoxISBN;
        private System.Windows.Forms.OpenFileDialog openFileDialogBookCover;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox_CopiesLeft;
        private System.Windows.Forms.Label label_NumberOfCopiesLeft;
    }
}