using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Data;
using LibraryAplication.User_Controls;
using LibraryAplication.Helper;

namespace LibraryAplication.Presenters
{
    class UserMenuPresenter
    {
        private ILibraryPresenter _libraryPresenter;
        private IUser user;
        private BookDataControler bookDataControler;
        private IBookBorrowed book;


        public UserMenuPresenter(ILibraryPresenter libraryPresenter, IUser user)
        {
            _libraryPresenter = libraryPresenter;

            this.user = user;
        }

        public void DisplayUserDataOn(Panel panelUserData)
        {
            
            UserDataControler userDataControler = new UserDataControler(_libraryPresenter, user);
            panelUserData.Controls.Add(userDataControler);
            userDataControler.BringToFront();
        }

        public void LoadCurrentBooksBorrowed(DataGridView dataGridViewCurrentBooksBorrowed)
        {
            if (user.CurrentBooksBorrowed.Count > 0)
                dataGridViewCurrentBooksBorrowed.DataSource = GetBookDataFromList(user.CurrentBooksBorrowed);
        }

        public void ClearBookDataFromScreen(Button btnReturn)
        {
            bookDataControler.Visible = false;
            btnReturn.Visible = false;
        }

        public void LoadReturnedBooks(DataGridView dataGridViewBooksReturned)
        {
            if (user.BooksReturned.Count > 0)
                dataGridViewBooksReturned.DataSource = GetBookDataFromList(user.BooksReturned);
        }

        public void ReturnSelectedBook()
        {
            IReturnManager manager = new ReturnManager(_libraryPresenter);

            manager.Return(user, book);
            MessageBox.Show("Done");




        }

        private DataTable GetBookDataFromList(IList<IBookBorrowed> booklist)
        {

            DataTable dataTable = new DataTable();

                dataTable.Columns.Add("ISBN");
                dataTable.Columns.Add("BookTitle");
                dataTable.Columns.Add("Author");
                dataTable.Columns.Add("BarrowedDate");
            if (booklist.First().ReturnDate == default(DateTime))
            {
                dataTable.Columns.Add("DaysLeft");
            }
            else
            {
                dataTable.Columns.Add("ReturnDate");
            }

            try
            {

                foreach (IBookBorrowed item in booklist)
                {
                    var row = dataTable.NewRow();

                    row["ISBN"] = item.Book.ISBN;
                    row["BookTitle"] = item.Book.BookTitle;
                    row["Author"] = item.Book.Authors.First().ToString();
                    row["BarrowedDate"] = item.BarowedDate.Date.ToShortDateString();

                    if (item.ReturnDate == default(DateTime))
                    {
                        string daysleft = item.NumberOfDaysLeft().ToString();
                        row["DaysLeft"] = daysleft;
                    }
                    else
                    {
                        row["ReturnDate"] = item.ReturnDate.Date.ToShortDateString();
                    }


                    dataTable.Rows.Add(row);
                }
            }
            catch
            {
                MessageBox.Show("Data Error");
            }
            return dataTable;

        }

        public void DisplayBookData(string cellclicked, Panel panelBookData, Button btnReturn)
        {

            try
            {
                bookDataControler.Visible = false;

            }
            catch
            {

            }
            IBookBorrowed selectedbook = null;
            foreach (var item in user.CurrentBooksBorrowed)
            {
                if (item.Book.ISBN.ToString().Equals(cellclicked))
                {
                    selectedbook = item;
                }
            }
            if (selectedbook != null)
            {
                book = selectedbook;
                bookDataControler = new BookDataControler(_libraryPresenter, selectedbook);
                panelBookData.Visible = true;
                btnReturn.Visible = true;
                btnReturn.BringToFront();
                bookDataControler.Visible = true;
                panelBookData.Controls.Add(bookDataControler);

            }

        }



    }
}
