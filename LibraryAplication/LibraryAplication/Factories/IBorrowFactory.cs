using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;

namespace LibraryAplication.Factories
{
    interface IBorrowFactory
    {

        IBookBorrowed create(DateTime barrowedDate,int allocatedDays, IBook book,IUser user);
    }
}
