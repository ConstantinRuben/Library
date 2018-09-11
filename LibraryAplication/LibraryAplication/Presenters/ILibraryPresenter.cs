using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication.Presenters
{
     internal interface ILibraryPresenter
    {
        IList<IBook> GetBooks();
        void displayAllBooks(FlowLayoutPanel panel);

    }
}
