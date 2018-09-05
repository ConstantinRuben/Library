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

namespace LibraryAplication.User_Controls
{
    public partial class AuthorsList : UserControl
    {
        LibraryContainer library = new LibraryContainer();
        IAuthorFactory factory = new AuthorFactory();
     
        public AuthorsList()
        {
            InitializeComponent();
            library.initialize();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void AuthorsList_Load(object sender, EventArgs e)
        {
            library.initialize();
            testcomboboxdata();
        }

        private void testcomboboxdata()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();

            var authors = library.authors.get();
            foreach (var iterator in authors)
            {
                test.Add(authors.IndexOf(iterator).ToString(), iterator.authorName());

            }

            //  comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value;

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var author =factory.create(textBoxAuthorName.Text);
            library.authors.add(author);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testcomboboxdata();
        }
    }
}
