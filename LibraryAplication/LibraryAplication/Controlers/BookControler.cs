using LibraryAplication.Containers;
using LibraryAplication.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Controlers
{
    class BookControler
    {
        IBookContainer bookContainer;
        IBookFactory bookFactory = new BookFactory();
        

        public BookControler(IBookContainer bookContainer)
        {
            this.bookContainer = bookContainer;
        }

        public void AddBook()
        {
         // var book= bookFactory.create()
           // bookContainer.add()
            
        }
    }
}
