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

namespace LibraryAplication.User_Controls
{
    public partial class BookUserControler : UserControl
    {
        Image image;
        string bookTitle;
        IBook book;

        internal IBook Book { get => book; set => book = value; }

        public BookUserControler()
        {
            InitializeComponent();


        }

        
      

      

        public BookUserControler(Image image, string bookTitle)
        {
            InitializeComponent();
            this.image = image;
            this.bookTitle = bookTitle;
           
        }

      

        private void BookUserControler_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = book.DisplayCover();
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
        private void BookClick(object sender, EventArgs e)
        {
           
            
        }

        private void labelBookTitle_Click(object sender, EventArgs e)
        {
         
            BookData form = new BookData();
            form.Book1 = book;
            form.Show();
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Color col = Color.FromArgb(255, 255, 192);

            this.BackColor = col;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
