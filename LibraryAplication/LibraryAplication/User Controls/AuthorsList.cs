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
using LibraryAplication.Data;

namespace LibraryAplication.User_Controls
{
    public partial class AuthorsList : UserControl
    {
        AuthorListPresenter presenter;
        List<CheckBox> checkBoxes = new List<CheckBox>();
        ILibraryPresenter _librarypresenter;


        public AuthorsList(ILibraryPresenter libraryPresenter)
        {
            InitializeComponent();
            _librarypresenter = libraryPresenter;
            presenter = new AuthorListPresenter(libraryPresenter, this);


        }



        private void AuthorsList_Load(object sender, EventArgs e)
        {
            int id = 1;
            LoadCheckboxes();
            try
            {
                 id = _librarypresenter.GetAuthors().Last().Id + 1;
            }
            catch
            {

            }
            textBoxAuthorId.Text = id.ToString();
        }




        private void LoadCheckboxes()
        {

            IList<IAuthor> authors;
            foreach (CheckBox item in PanelAuthors.Controls)
            {
                item.Visible = false;
                item.Checked = false;
            }


            authors = _librarypresenter.GetAuthors();
            foreach (IAuthor item in authors)
            {
                CheckBox box;
                box = new CheckBox();
                PanelAuthors.Controls.Add(box);
                box.Tag = item;
                box.Text = item.authorName();
                box.AutoSize = true;
                checkBoxes.Add(box);


            }

        }
        private void ClearAuthorsList()
        {
            for (int author = 0; author < checkBoxes.Count; author++)
            {
                PanelAuthors.Controls.Remove(checkBoxes[author]);
            }

        }

        private void btnNewAuthor_Click(object sender, EventArgs e)
        {

            if (textBoxAuthorName.Text == "")
                MessageBox.Show("Can't add an empty field");
            else
            {


                presenter.AddNewAuthor(textBoxAuthorName.Text, textBoxAuthorId.Text);
                textBoxAuthorId.Text = (Convert.ToInt32(textBoxAuthorId.Text) + 1).ToString();
                LoadCheckboxes();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IList<IAuthor> authors = _librarypresenter.GetAuthors();
            string searchVal = textBoxSearchbar.Text;

            var searchResult = (from item in authors
                                where item.authorName().ToLower().Contains(searchVal.ToLower())
                                orderby item.authorName() ascending
                                select item);

            ClearAuthorsList();

            CheckBox box;
            foreach (IAuthor iterator in searchResult)
            {
                box = new CheckBox();
                PanelAuthors.Controls.Add(box);
                box.Tag = iterator;
                box.Text = iterator.authorName();
                box.AutoSize = true;
                checkBoxes.Add(box);
            }
        }

        private void textBoxSearchbar_TextChanged(object sender, EventArgs e)
        {
            IList<IAuthor> authors = _librarypresenter.GetAuthors();
            string searchVal = textBoxSearchbar.Text;

            var searchResult = (from item in authors
                                where item.authorName().ToLower().Contains(searchVal.ToLower())
                                orderby item.authorName() ascending
                                select item);

            ClearAuthorsList();

            CheckBox box;
            foreach (IAuthor iterator in searchResult)
            {

                box = new CheckBox();
                PanelAuthors.Controls.Add(box);
                box.Tag = iterator;
                box.Text = iterator.authorName();
                box.AutoSize = true;
                checkBoxes.Add(box);

            }
        }
        public List<IAuthor> GetSelectedAuthors()
        {
            List<IAuthor> list = new List<IAuthor>();
            try
            {
                foreach (CheckBox c in PanelAuthors.Controls)
                {
                    if (c.Checked)
                    {

                        IAuthor author = (IAuthor)c.Tag;
                        list.Add(author);
                    }


                }
            }
            catch
            {

            }


            return list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (CheckBox c in PanelAuthors.Controls)
            {
                if (c.Checked)
                {


                    _librarypresenter.Container.authors.Remove((IAuthor)c.Tag);
                    _librarypresenter.Container.Save();

                }

            }
            ClearAuthorsList();
            LoadCheckboxes();
        }

    }
}
