using LibraryAplication.Containers;
using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication.Presenters
{
     public interface ILibraryPresenter
    {
        IList<IBook> GetBooks();
        IList<IAuthor> GetAuthors();
        IList<IUser> GetUsers();
        ILibraryContainer Container { get; set; }
    }
}
