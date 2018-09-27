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
    class UserFormPresenter
    {
        UserForm _userForm;
        ILibraryPresenter _libraryPresenter;
        DataGridView dataGridViewForUsers;

        AddUserControler addUserControler;
        public UserFormPresenter(UserForm userForm,ILibraryPresenter libraryPresenter, DataGridView dataGridView)
        {
            _userForm = userForm;
            _libraryPresenter = libraryPresenter;
            dataGridViewForUsers = dataGridView;
            addUserControler = new AddUserControler(_libraryPresenter);
            addUserControler.UserDataChanged += BookDatataChanging;
            SetControlerPosition();

        }

        private void SetControlerPosition()
        {
           // addUserControler.Left = (_userForm.ClientSize.Width - addUserControler.Width) / 2;
           // addUserControler.Top = (_userForm.ClientSize.Height - addUserControler.Height) / 2;

        }
        public void ShowAddUserForm()
        {
       
            _userForm.Controls.Add(addUserControler);
            addUserControler.Visible = true;
            addUserControler.BringToFront();
          
        }

        public void OpenUserMenu(DataGridViewCellEventArgs e, DataGridView dataGridViewUsers)
        {
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

            if (user != null)
            {

                UserMenuForm userform = new UserMenuForm(_libraryPresenter, user);
                userform.Show();
            }
        }

        public void BookDatataChanging(object sender ,EventArgs e)
        {

            DisplayAllUsers();
        }

        public void DisplayAllUsers()
        {

            dataGridViewForUsers.DataSource = GetUserDataFromList(_libraryPresenter.GetUsers());
        }

        public void Search(string text)
        {
            dataGridViewForUsers.DataSource = GetUserSearchResult(text);
  
        }

        private DataTable GetUserSearchResult(string text)
        {
            IUserSearchHelper helper = new UserSearchHelper(_libraryPresenter);
            IList<IUser> userlist = helper.Search(text);
            DataTable dataTable = GetUserDataFromList(userlist);
           

            return dataTable;
        }

        private DataTable GetUserDataFromList(IList<IUser>usersList)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("UserId");
            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("LastName");
            dataTable.Columns.Add("RegistrationDate");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Books to Return");
            dataTable.Columns.Add("Total Books Barrowed");

            foreach (IUser user in usersList)
            {
                var row = dataTable.NewRow();

                row["UserId"] = user.UserId;
                row["FirstName"] = user.FirstName;
                row["LastName"] = user.LastName;
                row["RegistrationDate"] = user.RegistrationDate.ToShortDateString();
                row["Phone"] = user.PhoneNumber;
                row["Books to Return"] = user.CurrentBooksBorrowed.Count.ToString();
                row["Total Books Barrowed"] = user.BooksReturned.Count.ToString();
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        
    }
}
