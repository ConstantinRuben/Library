using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Factories
{
    interface IBookFactory
    {
        IBook Create(string isbn, string bookTitle, int copies, string publisher,DateTime dateTime, IList<IAuthor> authors, IList<string> categories);
    }
}
