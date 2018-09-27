using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    public interface IUser
    {
        void BarrowBook(IBookBorrowed book);
        void ReturnBook(IBookBorrowed book,DateTime returnDate);

        string FirstName { get; set; }
        string LastName { get; set; }
        int UserId { get; set; }
        DateTime RegistrationDate { get; set; }
        string PhoneNumber { get; set; }
        IList<IBookBorrowed> BooksReturned { get; set; }
        IList<IBookBorrowed> CurrentBooksBorrowed { get; set; }
    }
}
