using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    public interface IBookCopies
    {
         int TotalnumberOfCopies { get; }
         int NumberOfBookLeft { get; }
        void EditTotalOfCopies(int number);
        void Borrow();
        void Return();
        bool ValidateNumberForEdit(int v);
    }
}
