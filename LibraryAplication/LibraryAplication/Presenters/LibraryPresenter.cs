using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Containers;
using LibraryAplication.User_Controls;

namespace LibraryAplication.Presenters
{
   class LibraryPresenter:ILibraryPresenter
    {
        LibraryContainer container = new LibraryContainer();
        HomeForm home;
        public LibraryPresenter()
        {
            container.initialize();
        }

        public LibraryPresenter(HomeForm home)
        {
            this.home = home;
            container.initialize();
        }

        public IList<IBook> GetBooks()
        {
            return container.books.get();
        }


        public void displayAllBooks(FlowLayoutPanel panel)
        {

            foreach (var item in container.books.get())
            {
                
                BookUserControler bookcontroler = new BookUserControler();
                bookcontroler.Book = item;
                panel.Controls.Add(bookcontroler);
            }
        }
    }
}
