using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Containers;
using LibraryAplication.User_Controls;
using LibraryAplication.Data;

namespace LibraryAplication.Presenters
{
   class LibraryPresenter:ILibraryPresenter
    {
        ILibraryContainer container;

        public ILibraryContainer Container
        {
            get
            {
                return container;
            }

            set
            {
                container = value;
            }
        }


        public LibraryPresenter()
        {
            container = new LibraryContainer();
            container.Initialize();
        }

        public IList<IBook> GetBooks()
        {
            return container.books.Get();
        }

        public IList<IAuthor> GetAuthors()
        {
            return container.authors.Get();
        }

        public IList<IUser> GetUsers()
        {
            return container.users.Get();
        }


    }
}
