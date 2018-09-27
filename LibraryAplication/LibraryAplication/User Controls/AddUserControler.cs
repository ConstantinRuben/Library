using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Presenters;

namespace LibraryAplication.User_Controls
{
    public partial class AddUserControler : UserControl
    {
        ILibraryPresenter _libraryPresenter;
        AddUserPresenter presenter;


        public event EventHandler UserDataChanged;

        public AddUserControler(ILibraryPresenter libraryPresenter)
        {

            InitializeComponent();
            _libraryPresenter = libraryPresenter;
            presenter = new AddUserPresenter(_libraryPresenter);
            Initialize();


        }

        private void Initialize()
        {
            textBox_IdUser.Enabled = false;
            try
            {
                textBox_IdUser.Text = (_libraryPresenter.GetUsers().Last().UserId + 1).ToString();
            }
            catch
            {
                textBox_IdUser.Text = "1";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            presenter.AddNewUser(textBox_firstName.Text, textBox_lastName.Text, textBox_IdUser.Text, textBox_phone.Text);
            UserDataChanged?.Invoke(this, null);

            MessageBox.Show("Done");
            textBox_firstName.Text = "";
            textBox_lastName.Text = "";
            try
            {
                textBox_IdUser.Text = (_libraryPresenter.GetUsers().Last().UserId + 1).ToString();
            }
            catch
            {
                textBox_IdUser.Text = "1";
            }
            textBox_phone.Text = "";
            pictureBoxPhone.Visible = false;



        }

        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {
            presenter.CheckPhoneNumber(textBox_phone, pictureBoxPhone);
        }
    }
}
