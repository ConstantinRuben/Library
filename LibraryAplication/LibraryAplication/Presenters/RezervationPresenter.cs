using LibraryAplication.Data;
using LibraryAplication.Helper;
using LibraryAplication.User_Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication.Presenters
{
    class RezervationPresenter
    {

        ILibraryPresenter _libraryPresenter;
        ISearchHelper helper;
        IList<BookUserControler> controlerList;
        IUserSearchHelper userHelper;
        UserDataControler userdataControler;
        IUser selectedUser;
        IList<IBook> booksSelectedForBorrowing;
        public RezervationPresenter(ILibraryPresenter libraryPresenter)
        {
            _libraryPresenter = libraryPresenter;
            helper = new GeneralSearchHelper(_libraryPresenter);
            controlerList = new List<BookUserControler>();
            userHelper = new UserSearchHelper(_libraryPresenter);
        }

        public void LoadBookData(FlowLayoutPanel flowLayoutPanelBooks)
        {
            //ClearLastResult(flowLayoutPanelBooks);
            //foreach (var item in _libraryPresenter.GetBooks())
            //{
            //    BookUserControler bookUserControler = new BookUserControler(item);
            //    flowLayoutPanelBooks.Controls.Add(bookUserControler);
            //    controlerList.Add(bookUserControler);
            //}

        }

        public void SearchUsers(string text, DataGridView dataGridViewUsers)
        {
            try {
            userdataControler.Visible = false;
            }
            catch
            {
            }
            dataGridViewUsers.Visible = true;

            dataGridViewUsers.DataSource = GetUserDataFromList(userHelper.Search(text));
        }

        public void DisplayUserDataAfterClick(DataGridViewCellEventArgs e, DataGridView dataGridViewUsers,Panel panel,Button userButton)
        {
            dataGridViewUsers.Visible = false;
            IUser user = null;
            try
            {
                string cellclicked = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                foreach (var item in _libraryPresenter.Container.users.Get())
                {
                    if (item.UserId.ToString().Equals(cellclicked))
                        user = item;
                }
            }
            catch
            {

            }
   
            if(user!=null)
            {
                selectedUser = user;
                userdataControler = new UserDataControler(_libraryPresenter, user);
                userdataControler.Visible = true;
                userButton.Text = user.FirstName + " " + user.LastName+" Menu";
                userButton.Visible = true;
                panel.Controls.Add(userdataControler);
            }
        }

        public void OpenUserMenu()
        {
            UserMenuForm userform = new UserMenuForm(_libraryPresenter,selectedUser);
            userform.Show();
        }

        public void BorrowSelectedBooks(int allocatedDays)
        {
            if (selectedUser == null) MessageBox.Show("Select a user");
            if (booksSelectedForBorrowing==null) MessageBox.Show("Select a book");
            IBorrowManager borrowManager = new BorrowManager(_libraryPresenter);
            borrowManager.Barrow(selectedUser, allocatedDays, booksSelectedForBorrowing);
        }

        public void Search(string text, FlowLayoutPanel flowLayoutPanelBooks)
        {
            ClearLastResult(flowLayoutPanelBooks);

            foreach (var item in helper.SearchByBookTitle(text))
            {
                BookUserControler bookUserControler = new BookUserControler(item, _libraryPresenter);

                if (item.BookCopies.NumberOfBookLeft > 0)
                {
                    CheckBox checkbox = new CheckBox();
                    //to DO
                    //  checkbox.CheckedChanged += Checkbox_CheckedChanged;
                    bookUserControler.Controls.Add(checkbox);

                }
             
                flowLayoutPanelBooks.Controls.Add(bookUserControler);
                controlerList.Add(bookUserControler);
            }



        }
   

        public void GetSelectedBooksIn(DataGridView dataGridViewRezervedBooks)
        {
            IList<IBook> selectedBooks = new List<IBook>();

            foreach (BookUserControler controler in controlerList)
            {
                if(controler.Visible==true)
                foreach (var checkbox in controler.Controls)
                {
                    if(checkbox is CheckBox )
                    {

                        if (((CheckBox)checkbox).Checked == true) selectedBooks.Add(controler.GetBookData());

                    }
                }
            }

            booksSelectedForBorrowing = selectedBooks;
           dataGridViewRezervedBooks.DataSource= GetBookDataFromList(selectedBooks);
        }

        private void ClearLastResult(FlowLayoutPanel panel)
        {

            foreach (var item in controlerList)
            {

                item.Visible = false;
            }

        }
        private DataTable GetUserDataFromList(IList<IUser> usersList)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("UserId");
            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("LastName");


            foreach (IUser user in usersList)
            {
                var row = dataTable.NewRow();

                row["UserId"] = user.UserId;
                row["FirstName"] = user.FirstName;
                row["LastName"] = user.LastName;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private DataTable GetBookDataFromList(IList<IBook> booklist)
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ISBN");
            dataTable.Columns.Add("BookTitle");
            dataTable.Columns.Add("Author");


            foreach (IBook book in booklist)
            {
                var row = dataTable.NewRow();

                row["ISBN"] = book.ISBN;
                row["BookTitle"] = book.BookTitle;
                row["Author"] = book.Authors.First().ToString();
                dataTable.Rows.Add(row);
            }

            return dataTable;

        }


    }
}
