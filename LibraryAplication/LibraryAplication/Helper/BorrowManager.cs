using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Data;
using LibraryAplication.Factories;
using LibraryAplication.Presenters;

namespace LibraryAplication.Helper
{
    class BorrowManager : IBorrowManager
    {

        ILibraryPresenter _libraryPresenter;
        IBorrowFactory factory = new BorrowFactory();
        public BorrowManager(ILibraryPresenter libraryPresenter)
        {
            _libraryPresenter = libraryPresenter;
        }

        public void Barrow(IUser selectedUser, int AlocatedDays, IList<IBook> booksSelectedForBorrowing)
        {
            if (BarrowingIsValid(selectedUser, booksSelectedForBorrowing))
            {
                foreach (var item in booksSelectedForBorrowing)
                {
                    IBookBorrowed bookBorrowed;

                    bookBorrowed = factory.create(DateTime.Now, AlocatedDays, item,selectedUser);
                    
                    
                    _libraryPresenter.Container.borrowed.Add(bookBorrowed);
                    selectedUser.BarrowBook(bookBorrowed);

                }


                MessageBox.Show(booksSelectedForBorrowing.Count.ToString() + " Borrowed");
                _libraryPresenter.Container.Save();
            }


        }


        private bool BarrowingIsValid(IUser selectedUser, IList<IBook> booksSelectedForBorrowing)
        {

            foreach (IBook book in booksSelectedForBorrowing)
            {
                if (HasTheUserBarrowedThisBookAndNotReturned(selectedUser, book))
                {
                    MessageBox.Show(selectedUser.FirstName + " " + selectedUser.LastName + " has already barrowed " + book.BookTitle);
                    return false;
                }
            }
            return true;
        }

        private bool HasTheUserBarrowedThisBookAndNotReturned(IUser user, IBook book)
        {

            foreach (IBookBorrowed barrowed in user.CurrentBooksBorrowed)
            {
                if (barrowed.Book.Equals(book))
                {
                    return true;
                }
            }
            return false;
        }



    }
}
