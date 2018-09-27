using LibraryAplication.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication
{
    public partial class UserForm : Form
    {

        ILibraryPresenter _libraryPresenter;
        UserFormPresenter presenter;
        public UserForm(ILibraryPresenter libraryPresenter)
        {
            InitializeComponent();
            _libraryPresenter = libraryPresenter;
            presenter = new UserFormPresenter(this, _libraryPresenter, dataGridViewUsers);
            _libraryPresenter.Container.settings.GetSettings().ThemeChanged += ChangeTheme;
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            presenter.ShowAddUserForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            presenter.DisplayAllUsers();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            presenter.Search(textBoxSearch.Text);
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.OpenUserMenu(e,dataGridViewUsers);
        }
        public void ChangeTheme(object sender, EventArgs e)
        {
            BackColor = _libraryPresenter.Container.settings.GetSettings().Theme;

        }
    }
}
