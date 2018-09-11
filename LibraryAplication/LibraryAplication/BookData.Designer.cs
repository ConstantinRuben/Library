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
            this.textBoxAddCategories = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_cagegories = new System.Windows.Forms.Label();
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChangeCover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddCategories
            // 
            this.textBoxAddCategories.Enabled = false;
            this.textBoxAddCategories.Location = new System.Drawing.Point(121, 281);
            this.textBoxAddCategories.Name = "textBoxAddCategories";
            this.textBoxAddCategories.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCategories.TabIndex = 33;
            this.textBoxAddCategories.EnabledChanged += new System.EventHandler(this.btnEdit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.EnabledChanged += new System.EventHandler(this.btnEdit_Click);
            // 
            // label_cagegories
            // 
            this.label_cagegories.AutoSize = true;
            this.label_cagegories.Location = new System.Drawing.Point(49, 281);
            this.label_cagegories.Name = "label_cagegories";
            this.label_cagegories.Size = new System.Drawing.Size(52, 13);
            this.label_cagegories.TabIndex = 28;
            this.label_cagegories.Text = "Cagegory";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(49, 255);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 29;
            this.label_date.Text = "Date";
            // 
            // label_Publisher
            // 
            this.label_Publisher.AutoSize = true;
            this.label_Publisher.Location = new System.Drawing.Point(49, 232);
            this.label_Publisher.Name = "label_Publisher";
            this.label_Publisher.Size = new System.Drawing.Size(50, 13);
            this.label_Publisher.TabIndex = 30;
            this.label_Publisher.Text = "Publisher";
            // 
            // label_numberOfCopies
            // 
            this.label_numberOfCopies.AutoSize = true;
            this.label_numberOfCopies.Location = new System.Drawing.Point(49, 206);
            this.label_numberOfCopies.Name = "label_numberOfCopies";
            this.label_numberOfCopies.Size = new System.Drawing.Size(39, 13);
            this.label_numberOfCopies.TabIndex = 31;
            this.label_numberOfCopies.Text = "Copies";
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
            this.textBox_Publisher.Location = new System.Drawing.Point(121, 225);
            this.textBox_Publisher.Name = "textBox_Publisher";
            this.textBox_Publisher.Size = new System.Drawing.Size(100, 20);
            this.textBox_Publisher.TabIndex = 22;
            this.textBox_Publisher.EnabledChanged += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBox_Copies
            // 
            this.textBox_Copies.Enabled = false;
            this.textBox_Copies.Location = new System.Drawing.Point(121, 199);
            this.textBox_Copies.Name = "textBox_Copies";
            this.textBox_Copies.Size = new System.Drawing.Size(100, 20);
            this.textBox_Copies.TabIndex = 23;
            this.textBox_Copies.EnabledChanged += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBox_BookTitle
            // 
            this.textBox_BookTitle.Enabled = false;
            this.textBox_BookTitle.Location = new System.Drawing.Point(121, 175);
            this.textBox_BookTitle.Name = "textBox_BookTitle";
            this.textBox_BookTitle.Size = new System.Drawing.Size(100, 20);
            this.textBox_BookTitle.TabIndex = 24;
            this.textBox_BookTitle.EnabledChanged += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Enabled = false;
            this.textBox_ISBN.Location = new System.Drawing.Point(121, 149);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(100, 20);
            this.textBox_ISBN.TabIndex = 25;
            this.textBox_ISBN.EnabledChanged += new System.EventHandler(this.btnEdit_Click);
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(62, 325);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(156, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
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
            // 
            // BookData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 377);
            this.Controls.Add(this.btnChangeCover);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.textBoxAddCategories);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_cagegories);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_Publisher);
            this.Controls.Add(this.label_numberOfCopies);
            this.Controls.Add(this.label_BookTitle);
            this.Controls.Add(this.label_ISBN);
            this.Controls.Add(this.textBox_Publisher);
            this.Controls.Add(this.textBox_Copies);
            this.Controls.Add(this.textBox_BookTitle);
            this.Controls.Add(this.textBox_ISBN);
            this.Name = "BookData";
            this.Text = "BookData";
            this.Load += new System.EventHandler(this.BookData_Load);
            this.EnabledChanged += new System.EventHandler(this.btnEdit_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddCategories;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_cagegories;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_Publisher;
        private System.Windows.Forms.Label label_numberOfCopies;
        private System.Windows.Forms.Label label_BookTitle;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.TextBox textBox_Publisher;
        private System.Windows.Forms.TextBox textBox_Copies;
        private System.Windows.Forms.TextBox textBox_BookTitle;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangeCover;
    }
}