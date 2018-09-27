using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Data;
using LibraryAplication.Presenters;
using LibraryAplication.User_Controls;

namespace LibraryAplication
{
    public partial class UserMenuForm : Form
    {

        ILibraryPresenter _libraryPresenter;
        IUser user;
        UserMenuPresenter presenter;
        public UserMenuForm(ILibraryPresenter libraryPresenter, IUser userdata)
        {
            _libraryPresenter = libraryPresenter;
            InitializeComponent();
            user = userdata;
            presenter = new UserMenuPresenter(_libraryPresenter, user);
            Initilize();
        }

        private void Initilize()
        {
            presenter.DisplayUserDataOn(panelUserData);
            presenter.LoadCurrentBooksBorrowed(dataGridViewCurrentBooksBorrowed);
            presenter.LoadReturnedBooks(dataGridViewReturnedBooks);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            presenter.ReturnSelectedBook();
            presenter.ClearBookDataFromScreen(btnReturn);
            presenter.DisplayUserDataOn(panelUserData);
            presenter.LoadCurrentBooksBorrowed(dataGridViewCurrentBooksBorrowed);
            presenter.LoadReturnedBooks(dataGridViewReturnedBooks);

        }

        private void dataGridViewCurrentBooksBorrowed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cellclicked = dataGridViewCurrentBooksBorrowed.Rows[e.RowIndex].Cells[0].Value.ToString();
                presenter.DisplayBookData(cellclicked, panelBookData, btnReturn);
            }
            catch
            {

            }

        }
    }
}
