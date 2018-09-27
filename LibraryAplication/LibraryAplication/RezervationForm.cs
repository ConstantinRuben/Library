using LibraryAplication.Presenters;
using LibraryAplication.User_Controls;
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
    public partial class RezervationForm : Form
    {
        ILibraryPresenter _libraryPresenter;
        RezervationPresenter presenter;
        public RezervationForm(ILibraryPresenter libraryPresenter)
        {
            _libraryPresenter = libraryPresenter;
            presenter = new RezervationPresenter(libraryPresenter);
            _libraryPresenter.Container.settings.GetSettings().DefaultDaysChanged += ChangeDefaultDays;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        
        }

        private void RezervationForm_Load(object sender, EventArgs e)
        {
            presenter.LoadBookData(flowLayoutPanelBooks);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            presenter.Search(textBoxSearch.Text,flowLayoutPanelBooks);
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            presenter.SearchUsers(textboxSearchUser.Text,dataGridViewUsers);
        }

        private void textboxSearchUser_TextChanged(object sender, EventArgs e)
        {
            presenter.SearchUsers(textboxSearchUser.Text, dataGridViewUsers);
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.DisplayUserDataAfterClick(e,dataGridViewUsers,panelUserData,btnUserBooks);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.GetSelectedBooksIn(dataGridViewRezervedBooks);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            presenter.BorrowSelectedBooks(Int32.Parse(textBoxDays.Text));
        }

        private void btnUserBooks_Click(object sender, EventArgs e)
        {
            presenter.OpenUserMenu();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
        private void ChangeDefaultDays(object sender , EventArgs e)
        {
            textBoxDays.Text = _libraryPresenter.Container.settings.GetSettings().DefaultDays.ToString();
        }
    }
}
