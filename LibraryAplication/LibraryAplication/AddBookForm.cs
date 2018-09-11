using LibraryAplication.Containers;
using LibraryAplication.Factories;
using LibraryAplication.Presenters;
using LibraryAplication.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication
{
    public partial class AddBookForm : Form
    {
        IBookFactory bookfactory = new BookFactory();
        IAuthorFactory authorfactory = new AuthorFactory();
        LibraryContainer library = new LibraryContainer();

        AddBookPresenter addBookPresenter = new AddBookPresenter();

        public AddBookForm()
        {
            InitializeComponent();
            library.initialize();
          

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            library.initialize();
            comboBox1.AutoCompleteMode.ToString();
            CompleteAuthorList();
            
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {

            Author a = new Author("Author Test1");
            
            IList<IAuthor> authors = new List<IAuthor>();
            authors.Add(a);

            IList<string> categories = new List<string>();
            categories = categoriesList1.GetSelectedCategory();

            IBook book = bookfactory.create(textBox_ISBN.Text, textBox_BookTitle.Text, Convert.ToInt32(textBox_Copies.Text), textBox_Publisher.Text,dateTimePicker1.Value, authors, categories);
           
            Image image = pictureBoxCover.Image;
            BookCover cover = new BookCover(image, textBox_ISBN.Text);
            book.addCover(cover);
            library.books.add(book);

            //Add image to resources

            //try
            //{
            //   string picturePath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            //    File.Copy(openFileDialogBookCover.FileName, picturePath + "\\Resources\\CoverImages\\" + textBox_ISBN.Text + ".jpg",true);
            //    //BookCover cover = new BookCover(new Bitmap(Image.FromFile(openFileDialogBookCover.FileName)), textBox_ISBN.Text);
            //}
            //catch
            //{
          
            //}




            MessageBox.Show("Done");

            




        }
        private void CompleteAuthorList()
        {
            List<string>list=new List<string>();
            foreach (var item in library.authors.get())
            {
                list.Add(item.authorName());
            }

            comboBoxAuthors.DataSource = list;
            
            comboBoxAuthors.AutoCompleteMode.ToString();
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var bookslist = library.books.get();
           

            dt.Columns.Add("ISBN");
            dt.Columns.Add("BookTitle");
            dt.Columns.Add("NumberOFCopies");
            dt.Columns.Add("Image", typeof(Image));
            dt.Columns.Add("Author");
            //dt.Columns.Add("Publisher");
            //dt.Columns.Add("RelaseDate");
            foreach (var item in bookslist)
            {
                var row = dt.NewRow();

                row["ISBN"] = item.ISBN1;
                row["BookTitle"] = Convert.ToString(item.BookTitle);
                row["NumberOFCopies"] = item.NumberOfCopies.ToString();
                row["Image"] = item.DisplayCover();
                row["Author"] = item.Authors.First<IAuthor>().authorName();

                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnAddAuthors_Click(object sender, EventArgs e)
        {

            if (authorsList1.Visible)
            {
                authorsList1.Visible = false;
            }
            else
            {
                authorsList1.Visible = true;
            }
        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {

            if (categoriesList1.Visible)
            {
                categoriesList1.Visible = false;
                btnCategoryLoad.Visible = false;

            }
            else
            {
                categoriesList1.Visible = true;
                btnCategoryLoad.Visible = true;
                btnCategoryLoad.BringToFront();
            }
        }



        private void buttonCategoryLoad_Click(object sender, EventArgs e)
        {
            textBoxAddCategories.Text = "";
            foreach (string category in categoriesList1.GetSelectedCategory())
            {
                if (categoriesList1.GetSelectedCategory().IndexOf(category) == categoriesList1.GetSelectedCategory().Count - 1)
                    textBoxAddCategories.Text += category;
                else
                    textBoxAddCategories.Text += category + ", ";


            }

        }

        private void btnAddCover_Click(object sender, EventArgs e)
        {
            if (openFileDialogBookCover.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCover.Image = Image.FromFile(openFileDialogBookCover.FileName);

            }
           
        }

       
    }
}
