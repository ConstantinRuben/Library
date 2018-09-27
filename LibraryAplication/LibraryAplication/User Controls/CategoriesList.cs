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
    public partial class CategoriesList : UserControl
    {
        ILibraryPresenter presenter;
        List<CheckBox> checkBoxes = new List<CheckBox>();

        public CategoriesList(ILibraryPresenter libraryPresenter)
        {
            InitializeComponent();
            presenter = libraryPresenter;

        }



        private void CategoriesList_Load(object sender, EventArgs e)
        {

            LoadCategoriesList();

        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            if (textBoxNewCategory.Text == "")
                MessageBox.Show("Can't add an empty field");
            else
            {
                
                presenter.Container.categories.Add(textBoxNewCategory.Text);
                foreach (CheckBox checkbox in checkBoxes)
                {
                    checkbox.Checked = false;
                    panelCategories.Controls.Remove(checkbox);
                }
                LoadCategoriesList();

                textBoxNewCategory.Text = "";
            }
        }
        private void LoadCategoriesList()
        {

            IList<string> categories;
            categories = presenter.Container.categories.Get();

            ClearCategory();

            foreach (string item in categories)
            {
                CheckBox box;
                box = new CheckBox();
                panelCategories.Controls.Add(box);
                box.Tag = categories.IndexOf(item).ToString();
                box.Text = item;
                box.AutoSize = true;
                box.Location = new Point(10, categories.IndexOf(item) * 30);

                  checkBoxes.Add(box);

            }



        }

        private void ClearCategory()
        {
            for(int category=0;category< checkBoxes.Count;category++)
            {
                panelCategories.Controls.Remove(checkBoxes[category]);
            }

        }






        private void btnSearch_Click(object sender, EventArgs e)
        {

            IList<string> categories = presenter.Container.categories.Get();
            var searchVal = textBoxSearchbar.Text;
            var searchResult = (from item in categories
                                where item.Contains(searchVal)
                                select item);

            ClearCategory();

            CheckBox box;
            foreach (string iterator in searchResult)
            {

                box = new CheckBox();
                panelCategories.Controls.Add(box);
                box.Tag = searchResult.ToList().IndexOf(iterator).ToString();
                box.Text = iterator;
                box.AutoSize = true;
                box.Location = new Point(10, searchResult.ToList().IndexOf(iterator) * 30);
                  checkBoxes.Add(box);

            }



        }

        public List<string> GetSelectedCategory()
        {
            List<string> list = new List<string>();

            foreach (CheckBox c in panelCategories.Controls)
            {
                if (c.Checked)
                    list.Add(c.Text);

            }

            return list;
        }


        private void textBoxNewCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewCategory.PerformClick();
            }
        }

        private void textBoxSearchbar_TextChanged(object sender, EventArgs e)
        {
            IList<string> categories = presenter.Container.categories.Get();
            string searchVal = textBoxSearchbar.Text;

            var searchResult = (from item in categories
                                where item.ToLower().Contains(searchVal.ToLower())
                                orderby item[0] ascending
                                select item);

            ClearCategory();

            CheckBox box;
            foreach (string iterator in searchResult)
            {

                box = new CheckBox();
                panelCategories.Controls.Add(box);
                box.Tag = searchResult.ToList().IndexOf(iterator).ToString();
                box.Text = iterator;
                box.AutoSize = true;
                box.Location = new Point(10, searchResult.ToList().IndexOf(iterator) * 30);
                  checkBoxes.Add(box);

            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();

            foreach (CheckBox c in panelCategories.Controls)
            {
                if (c.Checked)
                    presenter.Container.categories.Remove(c.Text);

            }
            ClearCategory();
            LoadCategoriesList();
        }
    }
}
