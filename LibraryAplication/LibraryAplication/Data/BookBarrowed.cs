using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    [Serializable]
    class BookBarrowed : IBookBorrowed
    {
        DateTime barowedDate;
        DateTime returnDate;
        int allocatedDays;
        IUser user;
        IBook book;
        #region prop
        public IBook Book
        {
            get
            {
                return book;
            }

            set
            {
                book = value;
            }
        }
        public DateTime BarowedDate
        {
            get
            {
                return barowedDate;
            }

            set
            {
                barowedDate = value;
            }
        }

        public DateTime ReturnDate
        {
            get
            {
                return returnDate;
            }

            set
            {
                returnDate = value;
            }
        }

        public int AllocatedDays
        {
            get
            {
                return allocatedDays;
            }

            set
            {
                allocatedDays = value;
            }
        }

        public IUser User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }

        }
        #endregion
        public BookBarrowed(DateTime barowedDate, int allocatedDays, IBook book,IUser user)
        {
            this.barowedDate = barowedDate;
            this.Book = book;
            this.allocatedDays = allocatedDays;
            this.user = user;
        }



        public void AddReturnDate(DateTime dateTime)
        {
            returnDate = dateTime;
        }

        public int NumberOfDaysLeft()
        {
            int days = 0;
            days = allocatedDays-(int)((DateTime.Now - barowedDate).TotalDays);
            return days;
        }
    }
}
