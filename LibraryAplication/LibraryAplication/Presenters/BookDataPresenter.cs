using LibraryAplication.Data;
using LibraryAplication.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication.Presenters
{
    class BookDataPresenter
    {
        ILibraryPresenter _libraryPresenter;
        ToolTip toolTip;
        ValidationHelper validate;
        IBook book;
        public BookDataPresenter(IBook aBook, ILibraryPresenter librarypresenter)
        {
            _libraryPresenter = librarypresenter;
            book = aBook;
            validate = new ValidationHelper(_libraryPresenter);
            Initialize();
        }
        private void Initialize()
        {
            toolTip = new ToolTip();
            toolTip.InitialDelay = 100;
            toolTip.IsBalloon = true;
           // libraryPresenter.Container.categories.ChategoryContainerChanged += RefreshCategories;
           // libraryPresenter.Container.authors.AuthorContainerChanged += RefreshAuthors;


        }


        public void EditClicked(object sender, EventArgs e)
        {


            if (sender is TextBox)
            {
                TextBox textBoxTemp = sender as TextBox;
                textBoxTemp.Enabled = true;
            }
            if (sender is Button)
            {
                Button buttonTemp = sender as Button;
                buttonTemp.Enabled = false;
            }
        }


        public string GetCategory(IBook book)
        {
            StringBuilder categories = new StringBuilder();
            foreach (string category in book.Categories)
            {
                if (book.Categories.IndexOf(category) == book.Categories.Count - 1)

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

        public void CheckISBN(TextBox textBox_ISBN, PictureBox pictureBoxISBN)
        {

            if (validate.HasLetters(textBox_ISBN.Text) || validate.IsEmpty(textBox_ISBN.Text))
            {
                pictureBoxISBN.Visible = true;
                toolTip.SetToolTip(pictureBoxISBN, "Enter only digits");
            }
            else if (validate.NumberLengthGreatherThan(textBox_ISBN.Text, 12))
            {
                pictureBoxISBN.Visible = true;
                toolTip.SetToolTip(pictureBoxISBN, "Enter a valid number");
            }
            else if (validate.CheckIsbnForEdit(textBox_ISBN.Text,book.ISBN))
            {
                pictureBoxISBN.Visible = true;
                toolTip.SetToolTip(pictureBoxISBN, "Other book has this ISBN");
            }
            else
            {
                pictureBoxISBN.Visible = false;
            }
        }

        public void ChangeCover(Image image, string text)
        {
            try
            {
                BookCover cover = new BookCover(image, text);
                book.AddCover(cover);
            }
            catch
            {

            }
        }

        public void CheckCopies(TextBox textBox_Copies, PictureBox pictureBoxCopies)
        {
            if (validate.HasLetters(textBox_Copies.Text) || validate.NumberLengthGreatherThan(textBox_Copies.Text, 5))
            {
                pictureBoxCopies.Visible = true;
                toolTip.SetToolTip(pictureBoxCopies, "Enter a valid number");
            }
            else
            {
                pictureBoxCopies.Visible = false;
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

        public void Removebook(BookData bookData)
        {
            IList<IUser> usersWithThisBook = GetUserWithThisBook(book);
            if (usersWithThisBook.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _libraryPresenter.Container.books.Remove(book);
                    _libraryPresenter.Container.Save();
                    MessageBox.Show("Removed");
                    bookData.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Cancel Delete
                }
               
            }
            else
            {
                 
                DialogResult dialogResult = MessageBox.Show(GetUserForDisplay(usersWithThisBook),"Delete" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            }

        }
        private string GetUserForDisplay(IList<IUser>users)
        {
            string msg = "This book is currently borrowed by:" + Environment.NewLine;
            foreach (IUser user in users)
            {
                msg += user.FirstName+" "+user.LastName+ "  ID :"+user.UserId+Environment.NewLine;
            }
            return msg;
        }

        private IList<IUser>GetUserWithThisBook(IBook book)
        {
            IList<IUser> usersWithThisBook = new List<IUser>();
            foreach (IBookBorrowed bookBorrowed in _libraryPresenter.Container.borrowed.GetAllRecords()) 
            {
                if(bookBorrowed.ReturnDate == default(DateTime)&&bookBorrowed.Book.Equals(book))
                {
                    usersWithThisBook.Add(bookBorrowed.User);
                }

            }

            return usersWithThisBook;
        }
        
    }
    }
