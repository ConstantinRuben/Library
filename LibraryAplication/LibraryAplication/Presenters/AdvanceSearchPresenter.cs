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
    class AdvanceSearchPresenter
    {

        ILibraryPresenter _libraryPresenter;
        FlowLayoutPanel _panelSearchResult;
        ISearchHelper searchHelper;
        IList<IBook> result;
        IList<BookUserControler> bookUserControlers;

        public AdvanceSearchPresenter(ILibraryPresenter libraryPresenter, FlowLayoutPanel panelSearchResult)
        {
            _libraryPresenter = libraryPresenter;
            _panelSearchResult = panelSearchResult;
            searchHelper = new GeneralSearchHelper(_libraryPresenter);
            bookUserControlers = new List<BookUserControler>();
        }

        public void SetFieldsSearched(string ISBN, string bookTitle)
        {
            
            result=searchHelper.SearchByMultipleFields(ISBN,bookTitle);
        }

        public void GetSearchResult()
        {
            ClearLastResult();
            foreach (var book in result)
            {
                BookUserControler bookUserControler = new BookUserControler(book, _libraryPresenter);
                _panelSearchResult.Controls.Add(bookUserControler);
                bookUserControlers.Add(bookUserControler);
            }

        }
        private void ClearLastResult()
        {
            foreach (BookUserControler item in bookUserControlers)
            {

                item.Visible = false;

            }
        }
    }
}
