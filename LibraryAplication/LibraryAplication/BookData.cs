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
using LibraryAplication.Data;

namespace LibraryAplication
{
    public partial class BookData : Form
    {
        IBook book;
        BookDataPresenter presenter;
        ILibraryPresenter _libraryPresenter;
        bool coverChanged = false;

        public BookData(IBook abook, ILibraryPresenter libraryPresenter)
        {
            InitializeComponent();
            book = abook;
            _libraryPresenter = libraryPresenter;
            book.BookEdited += BookData_Load;
            presenter = new BookDataPresenter(book, _libraryPresenter);

        }



        public void Display()
        {

            pictureBoxCover.Image = book.DisplayCover();
            textBox_BookTitle.Text = book.BookTitle;
            textBox_ISBN.Text = book.ISBN;
            textBox_TotalCopies.Text = book.BookCopies.TotalnumberOfCopies.ToString();
            textBox_CopiesLeft.Text = book.BookCopies.NumberOfBookLeft.ToString();

            textBox_Publisher.Text = book.Publisher;
            textBoxAddCategories.Text = String.Join(", ", book.Categories);
            dateTimePicker1.Value = book.RelaseDate;
            textBoxAuthor.Text = String.Join(",", book.Authors);


        }

        private void BookData_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            textBox_BookTitle.Enabled = true;
            textBox_ISBN.Enabled = true;
            textBox_TotalCopies.Enabled = true;
            textBox_Publisher.Enabled = true;
            dateTimePicker1.Enabled = true;
          //  btnChangeCover.Visible = true;
            //textBoxAddCategories.Enabled = true;
            // textBoxAuthor.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxISBN.Visible == true || pictureBoxBookTitle.Visible == true || pictureBoxCopies.Visible == true)
            {
                MessageBox.Show("Complete all fields");
            }

            else
            {
                if (coverChanged == true)
                    presenter.ChangeCover(pictureBoxCover.Image, textBox_ISBN.Text);

                book.BookTitle = textBox_BookTitle.Text;
                if(book.BookCopies.ValidateNumberForEdit(Convert.ToInt32(textBox_TotalCopies.Text)))
                {
                book.BookCopies.EditTotalOfCopies(Convert.ToInt32(textBox_TotalCopies.Text));
                }
               

             
                book.Publisher = textBox_Publisher.Text;
                book.RelaseDate = dateTimePicker1.Value;

                book.ISBN = textBox_ISBN.Text;


                _libraryPresenter.Container.Save();

                textBox_BookTitle.Enabled = false;
                textBox_ISBN.Enabled = false;
                textBox_TotalCopies.Enabled = false;
              //  btnChangeCover.Visible = false;
                textBox_Publisher.Enabled = false;
                textBoxAddCategories.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBoxAuthor.Enabled = false;
                btnEdit.Enabled = true;

                _libraryPresenter.Container.Save();

                MessageBox.Show("Saved");
            }



        }

        private void textBox_ISBN_TextChanged(object sender, EventArgs e)
        {
            presenter.CheckISBN(textBox_ISBN, pictureBoxISBN);
        }

        private void textBox_BookTitle_TextChanged(object sender, EventArgs e)
        {
            presenter.CHeckBookTitle(textBox_BookTitle, pictureBoxBookTitle);
        }

        private void textBox_Copies_TextChanged(object sender, EventArgs e)
        {
            presenter.CheckCopies(textBox_TotalCopies, pictureBoxCopies);
        }

        private void btnChangeCover_Click(object sender, EventArgs e)
        {
            if (openFileDialogBookCover.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxCover.Image = Image.FromFile(openFileDialogBookCover.FileName);
                     coverChanged = true;
                }
                catch
                {
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            presenter.Removebook(this);
            
        }
    }
}
