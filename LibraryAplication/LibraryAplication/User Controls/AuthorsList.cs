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
using LibraryAplication.Factories;
using LibraryAplication.Presenters;

namespace LibraryAplication.User_Controls
{
    public partial class AuthorsList : UserControl
    {
        LibraryContainer library = new LibraryContainer();
        IAuthorFactory factory = new AuthorFactory();
        IAuthor author;
        AuthorListPresenter presenter;
     
        public AuthorsList()
        {
            InitializeComponent();
            library.initialize();
            presenter = new AuthorListPresenter(this);

        }

        public AuthorsList(IAuthor author)
        {
            this.author = author;
        }

        private void AuthorsList_Load(object sender, EventArgs e)
        {
            library.initialize();
            LoadCheckboxes();
        }

    

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var author =factory.create(textBoxAuthorName.Text);
            library.authors.add(author);
            LoadCheckboxes();
           
        }

        private void LoadCheckboxes()
        {
          
            IList<IAuthor> authors;
            foreach(CheckBox item in PanelAuthors.Controls)
            {
                item.Visible = false;
            }
        

            authors = library.authors.get();
            foreach (IAuthor item in authors)
            {
                CheckBox box;
                box = new CheckBox();
                PanelAuthors.Controls.Add(box);
                box.Tag = authors.IndexOf(item).ToString();
                box.Text = item.authorName();
                box.AutoSize = true;


            }

        }

        private void btnNewAuthor_Click(object sender, EventArgs e)
        {

            if (textBoxAuthorName.Text == "")
                MessageBox.Show("Can't add an empty field");
            else
            {

                presenter.AddNewAuthor(textBoxAuthorName.Text);
                LoadCheckboxes();
            }
        }
    }
}
