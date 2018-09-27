using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;

namespace LibraryAplication.Helper
{
    interface ISearchHelper
    {
        IList<IBook> SearchByBookTitle(string searchText);
        IList<IBook> SearchBookByAuthor(string searchText);
        IList<IBook> SearchBookByAuthorAndBookTitle(string searchText);
        IList<IBook> SearchByMultipleFields(string ISBN, string bookTitle);
        IList<IBook> SearchBookByCategory(string text);
    }
}
