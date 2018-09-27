using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Factories
{
    interface IAuthorFactory
    {
        IAuthor Create(string authorName, int id);
    }
}
