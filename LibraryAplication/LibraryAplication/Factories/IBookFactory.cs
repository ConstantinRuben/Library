using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Factories
{
    interface IBookFactory
    {
        IBook create(string isbn, string bookTitle, int copies, string publisher, IList<IAuthor> authors, IList<string> categories);
    }
}
