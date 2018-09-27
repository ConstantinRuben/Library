using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Helper
{
    interface IReturnManager
    {
        void Return(IUser selectedUser,IBookBorrowed borrowedBook);
    }
}
