using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Data;
using LibraryAplication.Helper;
using LibraryAplication.User_Controls;

namespace LibraryAplication.Presenters
{
    class BookSearchPresenter
    {
        ISearchHelper helper;
        IList<BookUserControler> bookUserControlersMain = new List<BookUserControler>();
        IList<BookUserControler> bookUserControlersMostRead = new List<BookUserControler>();
        ILibraryPresenter _libraryPresenter;
        IList<IBookBorrowed> borrowedbooks = new List<IBookBorrowed>();
        public BookSearchPresenter(ILibraryPresenter presenter)
        {

            _libraryPresenter = presenter;
            borrowedbooks = _libraryPresenter.Container.borrowed.GetAllRecords();
            helper = new GeneralSearchHelper(presenter);
        }


        public void Search(FlowLayoutPanel panel, string Search)
        {
            IList<IBook> books = helper.SearchBookByAuthorAndBookTitle(Search);

            ClearLastResult(panel, bookUserControlersMain);
            foreach (var book in books)
            {
                BookUserControler bookUserControler = new BookUserControler(book, _libraryPresenter);
                panel.Controls.Add(bookUserControler);
                bookUserControlersMain.Add(bookUserControler);
            }

        }

        private void ClearLastResult(FlowLayoutPanel panel,IList<BookUserControler> list)
        {
            foreach (BookUserControler item in list)
            {

                item.Visible = false;

            }
        }


        public void GetMostReadBooks(FlowLayoutPanel panel, int numberOfBooks)
        {

            
            var mostRead = borrowedbooks.GroupBy(q => q.Book)
                                        .OrderByDescending(gp => gp.Count())
                                        .Take(numberOfBooks)
                                        .Select(g => g.Key).ToList();

            ClearLastResult(panel, bookUserControlersMostRead);
            foreach (var book in mostRead)
            {
                BookUserControler bookUserControler = new BookUserControler(book, _libraryPresenter);
                panel.Controls.Add(bookUserControler);
                bookUserControlersMostRead.Add(bookUserControler);
            }

            


        }
    }
}
