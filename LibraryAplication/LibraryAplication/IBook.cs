using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication
{
    public interface IBook
    {
        bool IsAvalabile();
        void AddAuthor(IAuthor author);
        string ISBN1 { get; set; }
        string BookTitle { get; set; }

        int NumberOfCopies { get; set; }

        string Publisher { get; set; }
        DateTime RelaseDate { get; set; }
        IList<string> Category { get; set; }
        void addCover(BookCover cover);
        Image DisplayCover();
        IList<IAuthor> Authors { get; }


    }
}
