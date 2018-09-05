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

namespace LibraryAplication.User_Controls
{
    public partial class CategoriesList : UserControl
    {
        LibraryContainer library = new LibraryContainer();
        List<CheckBox> checkBoxes = new List<CheckBox>();

        public CategoriesList()
        {
            InitializeComponent();
            library.initialize();

        }



        private void CategoriesList_Load(object sender, EventArgs e)
        {

            LoadCategoriesList();

        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            if (textBoxNewCategory.Text == "")
                MessageBox.Show("Can't add an empty field");

            library.initialize();
            library.categories.add(textBoxNewCategory.Text);
            foreach (CheckBox checkbox in checkBoxes)
            {
                panelCategories.Controls.Remove(checkbox);
            }
            LoadCategoriesList();

            textBoxNewCategory.Text = "";

        }
        private void LoadCategoriesList()
        {

            IList<string> categories;


            foreach (CheckBox checkbox in checkBoxes)
            {
                checkbox.Visible = false;
            }


            categories = library.categories.Get();
            foreach (string item in categories)
            {
                CheckBox box;
                box = new CheckBox();
                panelCategories.Controls.Add(box);
                box.Tag = categories.IndexOf(item).ToString();
                box.Text = item;
                box.AutoSize = true;
                box.Location = new Point(10, categories.IndexOf(item) * 30);

                //   MessageBox.Show("test");
                //  checkBoxes.Add(box);

            }



        }






        private void btnSearch_Click(object sender, EventArgs e)
        {

            IList<string> categories = library.categories.Get();
            var searchVal = textBoxSearchbar.Text;
            var searchResult = (from item in categories
                                where item.Contains(searchVal)
                                select item);

            foreach (CheckBox checkbox in panelCategories.Controls)
            {
                checkbox.Visible = false;
            }

            CheckBox box;
            foreach (string iterator in searchResult)
            {

                box = new CheckBox();
                panelCategories.Controls.Add(box);
                box.Tag = searchResult.ToList().IndexOf(iterator).ToString();
                box.Text = iterator;
                box.AutoSize = true;
                box.Location = new Point(10, searchResult.ToList().IndexOf(iterator) * 30);
              //  checkBoxes.Add(box);

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

        private void btnAddNewCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewCategory.PerformClick();
            }
        }

        private void textBoxNewCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewCategory.PerformClick();
            }
        }

      
    }
}
