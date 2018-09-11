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
    public partial class BookListUserControl : UserControl
    {
        LibraryContainer library = new LibraryContainer();
        public BookListUserControl()
        {
            InitializeComponent();
            library.initialize();
        }

        private void BookListUserControl_Load(object sender, EventArgs e)
        {
            foreach (var item in library.books.get())
            {

                BookUserControler bookcontroler = new BookUserControler(item.DisplayCover(), item.BookTitle);
                flowLayoutPanel1.Controls.Add(bookcontroler);
            }
            
        }
    }
}
