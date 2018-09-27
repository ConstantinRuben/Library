using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;

namespace LibraryAplication.Helper
{
    interface IBorrowManager
    {
        void Barrow(IUser selectedUser,int alocatedDays, IList<IBook> booksSelectedForBorrowing);
    }
}
