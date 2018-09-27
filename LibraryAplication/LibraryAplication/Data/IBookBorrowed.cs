using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    public interface IBookBorrowed
    {
        void AddReturnDate(DateTime dateTime);
        int NumberOfDaysLeft();
        IBook Book { get; set; }
        DateTime BarowedDate { get; set; }
        DateTime ReturnDate { get; set; }
        int AllocatedDays { get; set; }
        IUser User { get; set; }
    }
}
