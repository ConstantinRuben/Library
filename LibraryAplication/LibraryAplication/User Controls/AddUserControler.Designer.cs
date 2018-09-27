namespace LibraryAplication.User_Controls
{
    partial class AddUserControler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserControler));
            this.label_phone = new System.Windows.Forms.Label();
            this.label_userId = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_IdUser = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.groupBoxuserForm = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelTopSideAddBook = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labe_User = new System.Windows.Forms.Label();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.groupBoxuserForm.SuspendLayout();
            this.panelTopSideAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(11, 166);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(72, 23);
            this.label_phone.TabIndex = 48;
            this.label_phone.Text = "Phone :";
            // 
            // label_userId
            // 
            this.label_userId.AutoSize = true;
            this.label_userId.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userId.Location = new System.Drawing.Point(11, 115);
            this.label_userId.Name = "label_userId";
            this.label_userId.Size = new System.Drawing.Size(82, 23);
            this.label_userId.TabIndex = 49;
            this.label_userId.Text = "ID User :";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(11, 69);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(108, 23);
            this.label_lastName.TabIndex = 44;
            this.label_lastName.Text = "Last Name :";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(11, 22);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(110, 23);
            this.label_firstName.TabIndex = 45;
            this.label_firstName.Text = "First Name :";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstName.Location = new System.Drawing.Point(127, 18);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(170, 29);
            this.textBox_firstName.TabIndex = 43;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastName.Location = new System.Drawing.Point(127, 65);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(170, 29);
            this.textBox_lastName.TabIndex = 50;
            // 
            // textBox_IdUser
            // 
            this.textBox_IdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IdUser.Location = new System.Drawing.Point(127, 111);
            this.textBox_IdUser.Name = "textBox_IdUser";
            this.textBox_IdUser.Size = new System.Drawing.Size(170, 29);
            this.textBox_IdUser.TabIndex = 51;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(127, 162);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(170, 29);
            this.textBox_phone.TabIndex = 52;
            this.textBox_phone.TextChanged += new System.EventHandler(this.textBox_phone_TextChanged);
            // 
            // groupBoxuserForm
            // 
            this.groupBoxuserForm.BackColor = System.Drawing.Color.DimGray;
            this.groupBoxuserForm.Controls.Add(this.pictureBoxPhone);
            this.groupBoxuserForm.Controls.Add(this.label1);
            this.groupBoxuserForm.Controls.Add(this.btnAddUser);
            this.groupBoxuserForm.Controls.Add(this.label_firstName);
            this.groupBoxuserForm.Controls.Add(this.textBox_phone);
            this.groupBoxuserForm.Controls.Add(this.textBox_firstName);
            this.groupBoxuserForm.Controls.Add(this.textBox_IdUser);
            this.groupBoxuserForm.Controls.Add(this.label_lastName);
            this.groupBoxuserForm.Controls.Add(this.textBox_lastName);
            this.groupBoxuserForm.Controls.Add(this.label_userId);
            this.groupBoxuserForm.Controls.Add(this.label_phone);
            this.groupBoxuserForm.Location = new System.Drawing.Point(31, 74);
            this.groupBoxuserForm.Name = "groupBoxuserForm";
            this.groupBoxuserForm.Size = new System.Drawing.Size(331, 297);
            this.groupBoxuserForm.TabIndex = 53;
            this.groupBoxuserForm.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "______________________________________________";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Gray;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(61)))), ((int)(((byte)(25)))));
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(92, 236);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(153, 48);
            this.btnAddUser.TabIndex = 54;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(396, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 396);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 1);
            this.panel2.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 395);
            this.panel3.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 1);
            this.panel4.TabIndex = 57;
            // 
            // panelTopSideAddBook
            // 
            this.panelTopSideAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.panelTopSideAddBook.Controls.Add(this.btnClose);
            this.panelTopSideAddBook.Controls.Add(this.labe_User);
            this.panelTopSideAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSideAddBook.Location = new System.Drawing.Point(1, 1);
            this.panelTopSideAddBook.Name = "panelTopSideAddBook";
            this.panelTopSideAddBook.Size = new System.Drawing.Size(395, 50);
            this.panelTopSideAddBook.TabIndex = 59;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(117)))), ((int)(((byte)(9)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(342, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labe_User
            // 
            this.labe_User.AutoSize = true;
            this.labe_User.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_User.ForeColor = System.Drawing.Color.White;
            this.labe_User.Location = new System.Drawing.Point(24, 9);
            this.labe_User.Name = "labe_User";
            this.labe_User.Size = new System.Drawing.Size(68, 33);
            this.labe_User.TabIndex = 10;
            this.labe_User.Text = "User";
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhone.Image")));
            this.pictureBoxPhone.Location = new System.Drawing.Point(299, 166);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(26, 17);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhone.TabIndex = 56;
            this.pictureBoxPhone.TabStop = false;
            this.pictureBoxPhone.Tag = "";
            this.pictureBoxPhone.Visible = false;
            // 
            // AddUserControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(220)))), ((int)(((byte)(197)))));
            this.Controls.Add(this.panelTopSideAddBook);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxuserForm);
            this.Name = "AddUserControler";
            this.Size = new System.Drawing.Size(397, 396);
            this.groupBoxuserForm.ResumeLayout(false);
            this.groupBoxuserForm.PerformLayout();
            this.panelTopSideAddBook.ResumeLayout(false);
            this.panelTopSideAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_userId;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_IdUser;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.GroupBox groupBoxuserForm;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelTopSideAddBook;
        private System.Windows.Forms.Label labe_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
    }
}
