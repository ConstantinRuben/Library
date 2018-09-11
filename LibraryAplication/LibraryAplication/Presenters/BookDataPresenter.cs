using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication.Presenters
{
    class BookDataPresenter
    {
        BookData _bookData;
        public BookDataPresenter(BookData bookData)
        {
            _bookData = bookData;
        }


        public void EditClicked(object sender, EventArgs e)
        {


            if (sender is TextBox)
            {
                TextBox textBoxTemp = sender as TextBox;
                textBoxTemp.Enabled = true;
            }
            if (sender is Button)
            {
                Button buttonTemp = sender as Button;
                buttonTemp.Enabled = false;
            }
        }

        public void Display()
        {


        }

        public string GetCategory(IBook book)
        {
            StringBuilder categories = new StringBuilder();
            foreach (string category in book.Category)
            {
                if (book.Category.IndexOf(category) == book.Category.Count - 1)

                {
                    categories.Append(category);
                }

                else
                {
                    categories.Append(category + ",");
                }

            }
            return categories.ToString();

        }
        }
    }
