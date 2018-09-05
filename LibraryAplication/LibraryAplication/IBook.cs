using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication
{
    interface IBook
    {
        bool IsAvalabile();
        void AddAuthor(IAuthor author);
        string ISBN1 { get; set; }
        string BookTitle { get; set; }

        int NumberOfCopies { get; set; }

        string Publisher { get; set; }
        DateTime RelaseDate { get; set; }
        IList<string> Category { get; set; }
       
    }
}
