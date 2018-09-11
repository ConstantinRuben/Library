using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Containers;
using LibraryAplication.Factories;

namespace LibraryAplication.Presenters
{
    class AddBookPresenter
    {

        IBookFactory bookfactory = new BookFactory();
        LibraryContainer libraryContainer = new LibraryContainer();
        public AddBookPresenter()
        {

        }

        public void addBook()
        {
            //Author a = new Author("TEST11");
            //IList<IAuthor> authors = new List<IAuthor>();
            //authors.Add(a);
            //category = new CategoryContainer();
            //category.add("dsada");
            //IList<string> cat = new List<string>();
            //cat.Add("cattest1");

            //IBook book = bookfactory.create(textBox_ISBN.Text, textBox_BookTitle.Text, Convert.ToInt32(textBox_Copies.Text), textBox_Publisher.Text, authors, cat);
            //books.add(book);
            //MessageBox.Show("Done");



        }




    }
}
