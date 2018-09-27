namespace LibraryAplication
{
    partial class UserMenuForm
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
            this.panelUserData = new System.Windows.Forms.Panel();
            this.panelUnreturnedBooks = new System.Windows.Forms.Panel();
            this.panelAllBorrowedBooks = new System.Windows.Forms.Panel();
            this.dataGridViewReturnedBooks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCurrentBooksBorrowed = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelBookData = new System.Windows.Forms.Panel();
            this.panelAllBorrowedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnedBooks)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentBooksBorrowed)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelBookData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserData
            // 
            this.panelUserData.AutoSize = true;
            this.panelUserData.Location = new System.Drawing.Point(35, 12);
            this.panelUserData.Name = "panelUserData";
            this.panelUserData.Size = new System.Drawing.Size(178, 112);
            this.panelUserData.TabIndex = 0;
            // 
            // panelUnreturnedBooks
            // 
            this.panelUnreturnedBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUnreturnedBooks.Location = new System.Drawing.Point(0, 516);
            this.panelUnreturnedBooks.Name = "panelUnreturnedBooks";
            this.panelUnreturnedBooks.Size = new System.Drawing.Size(938, 41);
            this.panelUnreturnedBooks.TabIndex = 1;
            // 
            // panelAllBorrowedBooks
            // 
            this.panelAllBorrowedBooks.Controls.Add(this.dataGridViewReturnedBooks);
            this.panelAllBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAllBorrowedBooks.Location = new System.Drawing.Point(0, 399);
            this.panelAllBorrowedBooks.Name = "panelAllBorrowedBooks";
            this.panelAllBorrowedBooks.Size = new System.Drawing.Size(938, 117);
            this.panelAllBorrowedBooks.TabIndex = 2;
            // 
            // dataGridViewReturnedBooks
            // 
            this.dataGridViewReturnedBooks.AllowUserToAddRows = false;
            this.dataGridViewReturnedBooks.AllowUserToDeleteRows = false;
            this.dataGridViewReturnedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewReturnedBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReturnedBooks.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridViewReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReturnedBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReturnedBooks.Name = "dataGridViewReturnedBooks";
            this.dataGridViewReturnedBooks.ReadOnly = true;
            this.dataGridViewReturnedBooks.RowHeadersVisible = false;
            this.dataGridViewReturnedBooks.ShowEditingIcon = false;
            this.dataGridViewReturnedBooks.Size = new System.Drawing.Size(938, 117);
            this.dataGridViewReturnedBooks.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 43);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridViewCurrentBooksBorrowed);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 133);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewCurrentBooksBorrowed
            // 
            this.dataGridViewCurrentBooksBorrowed.AllowUserToAddRows = false;
            this.dataGridViewCurrentBooksBorrowed.AllowUserToDeleteRows = false;
            this.dataGridViewCurrentBooksBorrowed.AllowUserToOrderColumns = true;
            this.dataGridViewCurrentBooksBorrowed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCurrentBooksBorrowed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCurrentBooksBorrowed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCurrentBooksBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrentBooksBorrowed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCurrentBooksBorrowed.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCurrentBooksBorrowed.Name = "dataGridViewCurrentBooksBorrowed";
            this.dataGridViewCurrentBooksBorrowed.ReadOnly = true;
            this.dataGridViewCurrentBooksBorrowed.RowHeadersVisible = false;
            this.dataGridViewCurrentBooksBorrowed.ShowEditingIcon = false;
            this.dataGridViewCurrentBooksBorrowed.Size = new System.Drawing.Size(938, 133);
            this.dataGridViewCurrentBooksBorrowed.TabIndex = 0;
            this.dataGridViewCurrentBooksBorrowed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCurrentBooksBorrowed_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelUserData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 223);
            this.panel3.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Silver;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(14, 158);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(129, 41);
            this.btnReturn.TabIndex = 59;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panelBookData
            // 
            this.panelBookData.Controls.Add(this.btnReturn);
            this.panelBookData.Location = new System.Drawing.Point(419, 0);
            this.panelBookData.Name = "panelBookData";
            this.panelBookData.Size = new System.Drawing.Size(460, 202);
            this.panelBookData.TabIndex = 6;
            this.panelBookData.Visible = false;
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 557);
            this.Controls.Add(this.panelBookData);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAllBorrowedBooks);
            this.Controls.Add(this.panelUnreturnedBooks);
            this.Name = "UserMenuForm";
            this.Text = "UserMenuForm";
            this.panelAllBorrowedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnedBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentBooksBorrowed)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelBookData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserData;
        private System.Windows.Forms.Panel panelUnreturnedBooks;
        private System.Windows.Forms.Panel panelAllBorrowedBooks;
        private System.Windows.Forms.DataGridView dataGridViewReturnedBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dataGridViewCurrentBooksBorrowed;
        private System.Windows.Forms.Panel panelBookData;
    }
}