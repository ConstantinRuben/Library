using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    [Serializable]
    class User:IUser
    {
        string firstName;
        string lastName;
        int userId;
        DateTime registrationDate;
        string phoneNumber;
        IList<IBookBorrowed> booksReturned;
        IList<IBookBorrowed> currentBooksBorrowed;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public DateTime RegistrationDate
        {
            get
            {
                return registrationDate;
            }

            set
            {
                registrationDate = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public IList<IBookBorrowed> BooksReturned
        {
            get
            {
                return booksReturned;
            }

            set
            {
                booksReturned = value;
            }
        }

        public IList<IBookBorrowed> CurrentBooksBorrowed
        {
            get
            {
                return currentBooksBorrowed;
            }

            set
            {
                currentBooksBorrowed = value;
            }
        }

        public User(string firstName, string lastName, int userId, DateTime registrationDate, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userId = userId;
            this.registrationDate = registrationDate;
            this.phoneNumber = phoneNumber;
            booksReturned = new List<IBookBorrowed>();
            currentBooksBorrowed = new List<IBookBorrowed>();
        }

        public void BarrowBook(IBookBorrowed book)
        {
            currentBooksBorrowed.Add(book);
        }

        public void ReturnBook(IBookBorrowed book, DateTime returnDate)
        {
            currentBooksBorrowed.Remove(book);
            book.AddReturnDate(returnDate);
            booksReturned.Add(book);
            
        }

    }
}
