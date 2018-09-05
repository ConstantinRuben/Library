using LibraryAplication.Containers;
using LibraryAplication.Factories;
using LibraryAplication.Prezenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        AddBookPrezenter addBookPrezenter = new AddBookPrezenter();

        public AddBookForm()
        {
            InitializeComponent();
            library.initialize();

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            library.initialize();
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {

            Author a = new Author("TEST11");
            IList<IAuthor> authors = new List<IAuthor>();
            authors.Add(a);

            IList<string> categories = new List<string>();
            categories = categoriesList1.GetSelectedCategory();

            IBook book = bookfactory.create(textBox_ISBN.Text, textBox_BookTitle.Text, Convert.ToInt32(textBox_Copies.Text), textBox_Publisher.Text, authors, categories);
            library.books.add(book);
            MessageBox.Show("Done");






        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var bookslist = library.books.get();


            dt.Columns.Add("ISBN");
            dt.Columns.Add("BookTitle");
            dt.Columns.Add("NumberOFCopies");
            //dt.Columns.Add("Publisher");
            //dt.Columns.Add("RelaseDate");
            foreach (var item in bookslist)
            {
                var row = dt.NewRow();

                row["ISBN"] = item.ISBN1;
                row["BookTitle"] = Convert.ToString(item.BookTitle);
                row["NumberOFCopies"] = item.NumberOfCopies.ToString();

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
    }
}
