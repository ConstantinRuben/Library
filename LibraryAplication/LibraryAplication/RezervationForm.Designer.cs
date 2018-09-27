namespace LibraryAplication
{
    partial class RezervationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelTopSideAddBook = new System.Windows.Forms.Panel();
            this.btnUserBooks = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.textboxSearchUser = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.groupBoxReservedBooks = new System.Windows.Forms.GroupBox();
            this.dataGridViewRezervedBooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUserData = new System.Windows.Forms.Panel();
            this.panelUserSearch = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDays = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTopSideAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.groupBoxReservedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervedBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelUserData.SuspendLayout();
            this.panelUserSearch.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSearch.Controls.Add(this.flowLayoutPanelBooks);
            this.panelSearch.Controls.Add(this.panel2);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(873, 456);
            this.panelSearch.TabIndex = 8;
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(873, 391);
            this.flowLayoutPanelBooks.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 65);
            this.panel2.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(61)))), ((int)(((byte)(25)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(61)))), ((int)(((byte)(25)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(483, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 29);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "___________________________________________________________";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(311, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(166, 29);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panelTopSideAddBook
            // 
            this.panelTopSideAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.panelTopSideAddBook.Controls.Add(this.btnUserBooks);
            this.panelTopSideAddBook.Controls.Add(this.labelUser);
            this.panelTopSideAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSideAddBook.Location = new System.Drawing.Point(0, 0);
            this.panelTopSideAddBook.Name = "panelTopSideAddBook";
            this.panelTopSideAddBook.Size = new System.Drawing.Size(1344, 56);
            this.panelTopSideAddBook.TabIndex = 7;
            // 
            // btnUserBooks
            // 
            this.btnUserBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserBooks.AutoSize = true;
            this.btnUserBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnUserBooks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUserBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnUserBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnUserBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserBooks.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserBooks.ForeColor = System.Drawing.Color.White;
            this.btnUserBooks.Location = new System.Drawing.Point(1176, 12);
            this.btnUserBooks.Name = "btnUserBooks";
            this.btnUserBooks.Size = new System.Drawing.Size(129, 41);
            this.btnUserBooks.TabIndex = 11;
            this.btnUserBooks.Text = "User Books";
            this.btnUserBooks.UseVisualStyleBackColor = false;
            this.btnUserBooks.Visible = false;
            this.btnUserBooks.Click += new System.EventHandler(this.btnUserBooks_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(45, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(79, 33);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "Users";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(61)))), ((int)(((byte)(25)))));
            this.btnSearchUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(61)))), ((int)(((byte)(25)))));
            this.btnSearchUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(264, 8);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(127, 29);
            this.btnSearchUser.TabIndex = 7;
            this.btnSearchUser.Text = "SEARCH";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // textboxSearchUser
            // 
            this.textboxSearchUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textboxSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSearchUser.Location = new System.Drawing.Point(92, 7);
            this.textboxSearchUser.Name = "textboxSearchUser";
            this.textboxSearchUser.Size = new System.Drawing.Size(166, 29);
            this.textboxSearchUser.TabIndex = 8;
            this.textboxSearchUser.TextChanged += new System.EventHandler(this.textboxSearchUser_TextChanged);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.Size = new System.Drawing.Size(394, 182);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // groupBoxReservedBooks
            // 
            this.groupBoxReservedBooks.BackColor = System.Drawing.Color.DimGray;
            this.groupBoxReservedBooks.Controls.Add(this.dataGridViewRezervedBooks);
            this.groupBoxReservedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReservedBooks.Location = new System.Drawing.Point(0, 261);
            this.groupBoxReservedBooks.Name = "groupBoxReservedBooks";
            this.groupBoxReservedBooks.Size = new System.Drawing.Size(406, 209);
            this.groupBoxReservedBooks.TabIndex = 10;
            this.groupBoxReservedBooks.TabStop = false;
            this.groupBoxReservedBooks.Text = "Rezerve Books";
            // 
            // dataGridViewRezervedBooks
            // 
            this.dataGridViewRezervedBooks.AllowUserToAddRows = false;
            this.dataGridViewRezervedBooks.AllowUserToDeleteRows = false;
            this.dataGridViewRezervedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRezervedBooks.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewRezervedBooks.Name = "dataGridViewRezervedBooks";
            this.dataGridViewRezervedBooks.RowHeadersVisible = false;
            this.dataGridViewRezervedBooks.ShowEditingIcon = false;
            this.dataGridViewRezervedBooks.Size = new System.Drawing.Size(400, 184);
            this.dataGridViewRezervedBooks.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnReserve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(173, 37);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(129, 41);
            this.btnReserve.TabIndex = 57;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(753, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 41);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panelUserData);
            this.panel1.Controls.Add(this.panelUserSearch);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 238);
            this.panel1.TabIndex = 59;
            // 
            // panelUserData
            // 
            this.panelUserData.Controls.Add(this.dataGridViewUsers);
            this.panelUserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserData.Location = new System.Drawing.Point(0, 47);
            this.panelUserData.Name = "panelUserData";
            this.panelUserData.Size = new System.Drawing.Size(403, 191);
            this.panelUserData.TabIndex = 10;
            // 
            // panelUserSearch
            // 
            this.panelUserSearch.Controls.Add(this.label3);
            this.panelUserSearch.Controls.Add(this.textboxSearchUser);
            this.panelUserSearch.Controls.Add(this.btnSearchUser);
            this.panelUserSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserSearch.Location = new System.Drawing.Point(0, 0);
            this.panelUserSearch.Name = "panelUserSearch";
            this.panelUserSearch.Size = new System.Drawing.Size(403, 47);
            this.panelUserSearch.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "User";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1311, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 570);
            this.panel3.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelDays);
            this.panel4.Controls.Add(this.textBoxDays);
            this.panel4.Controls.Add(this.btnReserve);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 526);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1311, 100);
            this.panel4.TabIndex = 61;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(47, 49);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(51, 19);
            this.labelDays.TabIndex = 60;
            this.labelDays.Text = "Days:";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(104, 48);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(31, 20);
            this.textBoxDays.TabIndex = 59;
            this.textBoxDays.Text = "10";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.groupBoxReservedBooks);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(409, 470);
            this.panel5.TabIndex = 62;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(409, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 470);
            this.panel6.TabIndex = 63;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(438, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(873, 14);
            this.panel7.TabIndex = 64;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panelSearch);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(438, 70);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(873, 456);
            this.panel8.TabIndex = 65;
            // 
            // RezervationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(220)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1344, 626);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTopSideAddBook);
            this.Name = "RezervationForm";
            this.Text = "RezervationForm";
            this.Load += new System.EventHandler(this.RezervationForm_Load);
            this.panelSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTopSideAddBook.ResumeLayout(false);
            this.panelTopSideAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.groupBoxReservedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervedBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelUserData.ResumeLayout(false);
            this.panelUserSearch.ResumeLayout(false);
            this.panelUserSearch.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelTopSideAddBook;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxReservedBooks;
        private System.Windows.Forms.Button btnUserBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox textboxSearchUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewRezervedBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUserData;
        private System.Windows.Forms.Panel panelUserSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.TextBox textBoxDays;
    }
}