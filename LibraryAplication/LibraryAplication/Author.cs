using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication
{
    [Serializable]
    class Author:IAuthor
    {
        string name;


        IList<IBook> books = new List<IBook>();

   

        public Author(string name)
        {
            this.name = name;
        }

        public void AddBook(IBook book)
        {
            books.Add(book);
        }

        public string authorName()
        {
            return name;
        }
    }
}
