using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    [Serializable]
    class LibraryContainer
    {


       public IAuthorContainer authors { get; set; }
       public IBookContainer books { get; set; }
       public  ICategoryContainer categories { get; set; }

        BinaryFormatter format = new BinaryFormatter();

        public LibraryContainer()
        {

        }

        public LibraryContainer(IAuthorContainer authors, IBookContainer books, ICategoryContainer categories)
        {
            this.authors = authors;
            this.books = books;
            this.categories = categories;
        }
        public void initialize()
        {
            authors =new AuthorContainer(new List<IAuthor>());
             books = new BookContainer(new List<IBook>());
            categories = new CategoryContainer(new List<string>());
            try
            {
                authors.updateSerialize();
                books.updateSerialize();
                categories.updateSerialize();

            }
            catch
            {

            }
         

        }




    }
}
