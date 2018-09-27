using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;
using LibraryAplication.Presenters;

namespace LibraryAplication.Helper
{
    class ReturnManager : IReturnManager
    {
        ILibraryPresenter _libraryPresente;

        public ReturnManager(ILibraryPresenter libraryPresenter)
        {
            _libraryPresente = libraryPresenter;
        }
        public void Return(IUser selectedUser, IBookBorrowed borrowedBook)
        {
            selectedUser.ReturnBook(borrowedBook, DateTime.Now);
            borrowedBook.Book.BookCopies.Return();
            _libraryPresente.Container.Save();
        }
    }
}
