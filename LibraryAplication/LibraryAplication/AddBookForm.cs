using LibraryAplication.Containers;
using LibraryAplication.Data;
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

        ILibraryPresenter libraryPresenter;
        AuthorsList authorList;
        CategoriesList categoriesListControler;
        AddBookPresenter addBookPresenter;
        IList<IAuthor> authors = new List<IAuthor>();

        public AddBookForm(ILibraryPresenter presenter)
        {
            libraryPresenter = presenter;
            InitializeComponent();

            Initialize();

        }

        private void Initialize()
        {
            addBookPresenter = new AddBookPresenter(libraryPresenter);
            addBookPresenter.CompleteAuthorList(comboBoxAuthors);
            addBookPresenter.CompleteCategoriesList(comboBoxCategiries);
            authorList = new AuthorsList(libraryPresenter);
            categoriesListControler = new CategoriesList(libraryPresenter);
            AuthorListPresenter AuthorPresenter = new AuthorListPresenter(libraryPresenter, authorList);
            panelAuthorControl.Controls.Add(authorList);
            panelCategoryControler.Controls.Add(categoriesListControler);



            textBoxSelectedAuthors.AutoSize = true;
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
   
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {

            IList<string> categories = new List<string>();
            try
            {
                categories.Add(comboBoxCategiries.Text);
                if (authors == null || authors.Count <=0)
                {
                    IAuthor author = (IAuthor)comboBoxAuthors.SelectedItem;
                    authors.Add(author);
                }
                if (authors.Count < 0)
                {
                    MessageBox.Show("Complete alld fields");
                }
                else if(pictureBoxISBN.Visible==true||pictureBoxBookTitle.Visible==true||pictureBoxCopies.Visible==true)
                {
                    MessageBox.Show("Complete all fields");
                }
                else
                {
                addBookPresenter.AddBook(textBox_ISBN.Text, textBox_BookTitle.Text, textBox_Copies.Text, textBox_Publisher.Text, dateTimePicker1.Value, authors, categories);
                addBookPresenter.AddCover(pictureBoxCover.Image, textBox_ISBN.Text);
                }

            }
            catch
            {

            }



        }


        private void btnAuthorPanel_Click(object sender, EventArgs e)
        {

            if (panelAuthorControl.Visible)
            {
                panelAuthorControl.Visible = false;
                btnAuthorLoad.Visible = false;

            }
            else
            {
                panelAuthorControl.Visible = true;
                btnAuthorLoad.Visible = true;
                panelCategoryControler.Visible = false;
                btnCategoryLoad.Visible = false;
            }
        }

        private void btnCategoryPanel_Click(object sender, EventArgs e)
        {

            if (panelCategoryControler.Visible)
            {
                panelCategoryControler.Visible = false;
                btnCategoryLoad.Visible = false;


            }
            else
            {
                panelCategoryControler.Visible = true;
                btnCategoryLoad.Visible = true;
                panelAuthorControl.Visible = false;
                btnAuthorLoad.Visible = false;
                btnCategoryLoad.BringToFront();
            }
        }



        private void buttonCategoryLoad_Click(object sender, EventArgs e)
        {
            comboBoxCategiries.Text = "";
            foreach (string category in categoriesListControler.GetSelectedCategory())
            {
                if (categoriesListControler.GetSelectedCategory().IndexOf(category) == categoriesListControler.GetSelectedCategory().Count - 1)
                    comboBoxCategiries.Text += category;
                else
                    comboBoxCategiries.Text += category + ", ";


            }

        }

        private void btnAddCover_Click(object sender, EventArgs e)
        {
            if (openFileDialogBookCover.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxCover.Image = Image.FromFile(openFileDialogBookCover.FileName);
                }
                catch
                {
                }
            }

        }

        private void textBox_ISBN_TextChanged(object sender, EventArgs e)
        {
            addBookPresenter.CheckISBN(textBox_ISBN, pictureBoxISBN);
        }

        private void textBox_BookTitle_TextChanged(object sender, EventArgs e)
        {
            addBookPresenter.CHeckBookTitle(textBox_BookTitle, pictureBoxBookTitle);
        }

        private void textBox_Copies_TextChanged(object sender, EventArgs e)
        {
            addBookPresenter.CheckCopies(textBox_Copies, pictureBoxCopies);
        }


        private void btnAuthorLoad_Click(object sender, EventArgs e)
        {
            comboBoxAuthors.Text = "";
            foreach (IAuthor author in authorList.GetSelectedAuthors())
            {
                if (authorList.GetSelectedAuthors().IndexOf(author) == authorList.GetSelectedAuthors().Count - 1)
                    textBoxSelectedAuthors.Text += author;
                else
                    textBoxSelectedAuthors.Text += author + ", ";

                authors.Add(author);

            }
        }

        private void btnaddAtuhorFromComboBox_Click(object sender, EventArgs e)
        {

            try
            {
                IAuthor author = (IAuthor)comboBoxAuthors.SelectedItem;
                authors.Add(author);

                if (textBoxSelectedAuthors.Text == "")
                {
                    textBoxSelectedAuthors.Text = author.ToString();
                }
                else
                {
                    textBoxSelectedAuthors.Text += ", " + author.ToString();
                }

            }
            catch
            {
                comboBoxAuthors.Text = "";
            }


        }

        private void btnClearSelectedAuthors_Click(object sender, EventArgs e)
        {
            authors = new List<IAuthor>();
            textBoxSelectedAuthors.Text = "";
        }
    }
}
