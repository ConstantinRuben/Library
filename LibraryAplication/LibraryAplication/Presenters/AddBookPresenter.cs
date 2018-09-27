using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Containers;
using LibraryAplication.Data;
using LibraryAplication.Factories;
using LibraryAplication.Helper;
using LibraryAplication.User_Controls;

namespace LibraryAplication.Presenters
{
    class AddBookPresenter
    {

        IBookFactory bookfactory = new BookFactory();
        ILibraryPresenter libraryPresenter;
        IBook book;
        ToolTip toolTip;
        ValidationHelper validate;
        private ComboBox _comboBoxCategiries;
        private ComboBox _comboBoxAuthors;
        

        public AddBookPresenter(ILibraryPresenter presenter)
        {

            libraryPresenter = presenter;
            validate = new ValidationHelper(libraryPresenter);
            Initialize();

        }

        private void Initialize()
        {
            toolTip = new ToolTip();
            toolTip.InitialDelay = 100;
            toolTip.IsBalloon = true;
            libraryPresenter.Container.categories.ChategoryContainerChanged+= RefreshCategories;
            libraryPresenter.Container.authors.AuthorContainerChanged += RefreshAuthors;
           
           
        }

        public void AddBook(string isbn, string bookTitle, string copies, string publisher, DateTime dateTime, IList<IAuthor> authors, IList<string> categories)
        {
            try
            {
            book = bookfactory.Create(isbn, bookTitle, Convert.ToInt32(copies), publisher, dateTime, authors, categories);
            }
            catch
            {
                MessageBox.Show("Complete the fields");
            }
        }



        public void AddCover(Image image, string coverId)
        {
            try
            {
                BookCover cover = new BookCover(image, coverId);
                book.AddCover(cover);
                libraryPresenter.Container.books.Add(book);
                libraryPresenter.Container.Save();
                MessageBox.Show("Done");
            }
            catch
            {

            }
        

        }

        public void CheckISBN(TextBox textBox_ISBN, PictureBox pictureBox)
        {

            if (validate.HasLetters(textBox_ISBN.Text) || validate.IsEmpty(textBox_ISBN.Text))
            {
                pictureBox.Visible = true;
                toolTip.SetToolTip(pictureBox, "Enter only digits");
            }
            else if(validate.NumberLengthGreatherThan(textBox_ISBN.Text,13))
            {
                pictureBox.Visible = true;
                toolTip.SetToolTip(pictureBox, "Enter a valid number");
            }
            else if (validate.ISBNExist(textBox_ISBN.Text))
            {
                pictureBox.Visible = true;
                toolTip.SetToolTip(pictureBox, "Other book has this ISBN");
            }
            else
            {
                pictureBox.Visible = false;
            }


        }

        public void CHeckBookTitle(TextBox textBox_BookTitle, PictureBox pictureBoxBookTitle)
        {
            if (validate.HasDigits(textBox_BookTitle.Text) || validate.IsEmpty(textBox_BookTitle.Text))
            {
                pictureBoxBookTitle.Visible = true;
                toolTip.SetToolTip(pictureBoxBookTitle, "Book Title Can't have numbers");
            }

            else
            {
                pictureBoxBookTitle.Visible = false;
            }
        }

        public void CheckCopies(TextBox textBox_Copies, PictureBox pictureBoxCopies)
        {
            if (validate.HasLetters(textBox_Copies.Text)||validate.NumberLengthGreatherThan(textBox_Copies.Text,5))
            {
                pictureBoxCopies.Visible = true;
                toolTip.SetToolTip(pictureBoxCopies, "Enter a valid number");
            }
            else
            {
                pictureBoxCopies.Visible = false;
            }
        }
        public void CompleteAuthorList(ComboBox comboBoxAuthors)
        {
            _comboBoxAuthors = comboBoxAuthors;
            comboBoxAuthors.DataSource = libraryPresenter.GetAuthors();
            comboBoxAuthors.AutoCompleteMode.ToString();
            comboBoxAuthors.Text = "";

        }
        public void CompleteCategoriesList(ComboBox comboBoxCategiries)
        {
            _comboBoxCategiries = comboBoxCategiries;
            comboBoxCategiries.DataSource = libraryPresenter.Container.categories.Get();
            comboBoxCategiries.AutoCompleteMode.ToString();
            comboBoxCategiries.Text = "";

        }
        public void RefreshCategories(object sender,EventArgs e)
        {

            _comboBoxCategiries.DataSource = null;
            _comboBoxCategiries.Items.Clear();
            _comboBoxCategiries.DataSource = libraryPresenter.Container.categories.Get();
            _comboBoxCategiries.AutoCompleteMode.ToString();
            _comboBoxCategiries.Text = "";

        }
        public void RefreshAuthors(object sender, EventArgs e)
        {
            _comboBoxAuthors.DataSource = null;
            _comboBoxAuthors.Items.Clear();
            _comboBoxAuthors.DataSource = libraryPresenter.GetAuthors();
            _comboBoxAuthors.AutoCompleteMode.ToString();
            _comboBoxAuthors.Text = "";
        }

    }
}
