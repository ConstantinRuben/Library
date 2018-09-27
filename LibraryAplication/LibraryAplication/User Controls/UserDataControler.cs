using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Data;
using LibraryAplication.Presenters;

namespace LibraryAplication.User_Controls
{
    public partial class UserDataControler : UserControl
    {
        ILibraryPresenter _libraryPresenter;
        IUser userData;
        public UserDataControler(ILibraryPresenter libraryPresenter, IUser user)
        {
            _libraryPresenter = libraryPresenter;
            userData = user;
            InitializeComponent();
            Initialize();

        }

        private void Initialize()
        {
            firstName.Text = userData.FirstName;
            lastName.Text = userData.LastName;
            userId.Text = userData.UserId.ToString();
            phone.Text = userData.PhoneNumber;
            currentBook.Text = userData.CurrentBooksBorrowed.Count.ToString();
            returnedBooks.Text = userData.BooksReturned.Count.ToString();
            registrationDate.Text = userData.RegistrationDate.ToShortDateString();

        }
    }
}
