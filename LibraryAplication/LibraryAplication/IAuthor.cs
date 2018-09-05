using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication
{
    interface IAuthor
    {
       void  AddBook(IBook book);
        string authorName();

    }
}
