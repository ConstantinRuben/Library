using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Data;
using LibraryAplication.Presenters;

namespace LibraryAplication.User_Controls
{
    public partial class BookDataControler : UserControl
    {
        ILibraryPresenter _libraryPresenter;
        IBookBorrowed borrowedBook;
        public BookDataControler(ILibraryPresenter libraryPresenter,IBookBorrowed bookdata)
        {
            _libraryPresenter = libraryPresenter;
            borrowedBook = bookdata;
            InitializeComponent();
            Initialize();

        }
        public BookDataControler()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            pictureBoxCover.Image = borrowedBook.Book.DisplayCover();
            label_BookTitle.Text = borrowedBook.Book.BookTitle;
            label_ISBN.Text = borrowedBook.Book.ISBN;
            label_TotalNumberOfCopies.Text = borrowedBook.Book.BookCopies.TotalnumberOfCopies.ToString();
            label_NumberOfCopiesLeft.Text = borrowedBook.Book.BookCopies.NumberOfBookLeft.ToString();
            label_Publisher.Text = borrowedBook.Book.Publisher;
            label_categories.Text = GetCategory();
            label_date.Text = borrowedBook.Book.RelaseDate.ToShortDateString();
            labelAuthor.Text = borrowedBook.Book.Authors.First().authorName();

        }
        private string GetCategory()
        {
            StringBuilder categories = new StringBuilder();
            IList<string> categoryList = borrowedBook.Book.Categories;
            foreach (string category in categoryList)
            {
                if (categoryList.IndexOf(category) == categoryList.Count - 1 && categoryList.IndexOf(category) < 2)

                {
                    categories.Append(category);
                }

                else
                {
                    categories.Append(category + ",");
                }

            }
            return categories.ToString();
            

        }

    }
}
