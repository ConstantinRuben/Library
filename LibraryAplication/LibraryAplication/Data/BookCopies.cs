using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{   
    [Serializable]
     class BookCopies:IBookCopies
    {
        int totalnumberOfCopies;
        int numberOfBookLeft;
        public int TotalnumberOfCopies
        {
            get
            {
                return totalnumberOfCopies;
            }
        }
            
        public int NumberOfBookLeft
        {
            get
            {
                return numberOfBookLeft;
            }
        }

    public BookCopies(int copies)
        {
            totalnumberOfCopies = copies;
            numberOfBookLeft = copies;
        }

        
        public void EditTotalOfCopies(int number)
        {
            int tempvalue;
            tempvalue = totalnumberOfCopies - numberOfBookLeft;
            totalnumberOfCopies = number;
            numberOfBookLeft = number - tempvalue;

        }

        public void Borrow()
        {
            numberOfBookLeft = numberOfBookLeft - 1;
        }

        public void Return()
        {
            numberOfBookLeft = numberOfBookLeft + 1;
        }

        public bool ValidateNumberForEdit(int v)
        {
            int tempvalue;
            tempvalue = totalnumberOfCopies - numberOfBookLeft;
            if (numberOfBookLeft == 0 && v > numberOfBookLeft + tempvalue)
            {
                return true;
            }
            else if(v>=tempvalue)
            {
                return true;
            }
            return false;
        }
    }
}
