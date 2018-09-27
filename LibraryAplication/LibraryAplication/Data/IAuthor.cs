using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    public interface IAuthor
    {
        void AddBook(IBook book);
        void RemoveBook(IBook book);
        string authorName();
        IList<IBook> GetWrittenBooks();
        int Id { get; set; }

    }
}
