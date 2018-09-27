using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;

namespace LibraryAplication.Factories
{
    class BorrowFactory : IBorrowFactory
    {
        public IBookBorrowed create(DateTime barrowedDate,int allocatedDays, IBook book,IUser user)
        {
            IBookBorrowed bookBorrowed = new BookBarrowed(barrowedDate, allocatedDays,book,user);
            bookBorrowed.Book.BookCopies.Borrow();
            return bookBorrowed;
        }
    }
}
