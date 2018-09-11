using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Presenters;
using LibraryAplication.User_Controls;

namespace LibraryAplication
{
    public partial class BookData : Form
    {
        IBook Book;
        BookDataPresenter presenter;

        public BookData()
        {
            InitializeComponent();
            presenter = new BookDataPresenter(this);
        }

        internal IBook Book1 { get => Book; set => Book = value; }

        public void Display()
        {



            pictureBoxCover.Image = Book.DisplayCover();

            textBox_BookTitle.Text = Book.BookTitle;
            textBox_ISBN.Text = Book.ISBN1;
            textBox_Publisher.Text = Book.Publisher;
            textBoxAddCategories.Text = presenter.GetCategory(Book);
            dateTimePicker1.Value= Book.RelaseDate;



        }

        private void BookData_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

           
        }
    }
}
