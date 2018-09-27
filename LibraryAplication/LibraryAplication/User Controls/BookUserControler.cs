using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Containers;
using LibraryAplication.Presenters;
using LibraryAplication.Data;

namespace LibraryAplication.User_Controls
{
    public partial class BookUserControler : UserControl
    {
        IBook book;

        ILibraryPresenter _libraryPresenter;

        public BookUserControler(IBook otherBook,ILibraryPresenter libraryPresenter)
        {
            InitializeComponent();
            book = otherBook;
            _libraryPresenter = libraryPresenter;

        }

        private void BookUserControler_Load(object sender, EventArgs e)
        {

            try
            {

            pictureBox1.Image = book.DisplayCover();
            }
            catch
            { }
            
            labelBookTitle.Text = book.BookTitle;
            IAuthor authorbook = book.Authors.First();
            labelAuthorName.Text = authorbook.authorName();
        }

        private void labelBookTitle_MouseHover(object sender, EventArgs e)
        {
            Label labeltemp = sender as Label;
            Color col = Color.FromArgb(209, 61, 25);
            labeltemp.ForeColor = col;

        }

        private void labelBookTitle_MouseLeave(object sender, EventArgs e)
        {
            Label labeltemp = sender as Label;
            labeltemp.ForeColor = Color.Black;
        }

        private void labelBookTitle_Click(object sender, EventArgs e)
        {

            BookData form = new BookData(book,_libraryPresenter);
            form.Show();

        }
        public IBook GetBookData()
        {

            return book;
        }
       
    }
}
