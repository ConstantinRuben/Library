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
        }
    }
}
