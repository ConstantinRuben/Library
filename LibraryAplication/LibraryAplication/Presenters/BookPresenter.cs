using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.User_Controls;

namespace LibraryAplication.Presenters
{
     class BookPresenter:IBookPresenter
    {

        BookUserControler bookdata;

        public BookPresenter(BookUserControler book)
        {
            bookdata = book;
        }

        public void BookDetails()
        {
            throw new NotImplementedException();
        }

      
    }
}
