using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Containers;
using LibraryAplication.Data;
using LibraryAplication.Presenters;

namespace LibraryAplication.Helper
{
    class GeneralSearchHelper : ISearchHelper
    {
      
        private ILibraryPresenter _libraryPresenter;

        IList<IBook> allBooks;

        public GeneralSearchHelper(ILibraryPresenter presenter)
        {
            this._libraryPresenter = presenter;
            allBooks = _libraryPresenter.GetBooks();
        }

        public IList<IBook> SearchByBookTitle(string searchText)
        {
            var searchResult = from books in allBooks
                               where books.BookTitle.ToLower().Contains(searchText.ToLower()) 
                               orderby books.BookTitle ascending
                               select books;

            return searchResult.ToList();
        }

     


        private IList<IAuthor> SearchByAuthor(string searchText)
        {
            IList<IAuthor> allAuthors = _libraryPresenter.GetAuthors();

            var searchResult = from author in allAuthors
                               where author.authorName().ToLower().Contains(searchText.ToLower())
                               orderby author.authorName() ascending
                               select author;

            return searchResult.ToList();
        }

        public IList<IBook> SearchBookByAuthor(string searchText)
        {
            IList<IBook> searchResult = new List<IBook>();
            foreach (var author in SearchByAuthor(searchText))
            {
                searchResult = searchResult.Union(author.GetWrittenBooks()).ToList();
            }

            return searchResult;
        }

        public IList<IBook> SearchBookByAuthorAndBookTitle(string searchText)
        {
            IList<IBook> searchResult = new List<IBook>();
            searchResult = SearchByBookTitle(searchText).Union(SearchBookByAuthor(searchText)).ToList();

            return searchResult;
        }


        private IList<string> SearchByCategory(string searchText)
        {
            IList<string>allCategories= new List<string>();

            var searchResult = from category in allCategories
                               where category.ToLower().Contains(searchText.ToLower())
                               select category;


            return searchResult.ToList();
        }


        public IList<IBook> SearchByMultipleFields(string ISBN, string bookTitle)
        {

            var searchResult = from book in allBooks
                               where book.BookTitle.ToLower().Contains(bookTitle.ToLower())
                               where book.ISBN.Contains(ISBN)
                               orderby book.BookTitle ascending
                               select book;

            //IList<IBook> result = new List<IBook>();
            //result = searchResult.ToList().Union(SearchBookByAuthor(author)).ToList();
            return searchResult.ToList();
        }

        public IList<IBook> SearchBookByCategory(string text)
        {
            var searchResult = from book in allBooks
                               where book.Categories.Contains(text)
                               orderby book.BookTitle ascending
                               select book;
            return searchResult.ToList();

        }
    }
}
