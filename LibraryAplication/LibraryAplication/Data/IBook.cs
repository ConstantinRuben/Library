using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    public interface IBook
    {
        bool IsAvalabile();
        void AddAuthor(IAuthor author);
        void RemoveAuthor(IAuthor author);
        void AddCover(BookCover cover);
        Image DisplayCover();

        string ISBN { get; set; }
        string BookTitle { get; set; }
        IBookCopies BookCopies { get; set; }
        string Publisher { get; set; }
        DateTime RelaseDate { get; set; }
        IList<string> Categories { get; set; }
        IList<IAuthor> Authors { get; set; }

        event EventHandler BookEdited;



    }
}
