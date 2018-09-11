using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Factories
{
    class BookFactory : IBookFactory
    {


        public IBook create(string isbn, string bookTitle, int copies, string publisher,DateTime dateTime, IList<IAuthor> authors, IList<string> categories)
        {
            IBook book = new Book(isbn, bookTitle, copies, publisher,dateTime,categories);

            foreach (IAuthor author in authors)
            {
                book.AddAuthor(author);
            }
          
            return book;
        }
    }
}
