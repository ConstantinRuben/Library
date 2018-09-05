using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Factories
{
    class BookFactory : IBookFactory
    {


        public IBook create(string isbn, string bookTitle, int copies, string publisher, IList<IAuthor> authors, IList<string> categories)
        {
            IBook book = new Book(isbn, bookTitle, copies, publisher,categories);

            foreach (IAuthor author in authors)
            {
                book.AddAuthor(author);
            }

            return book;
        }
    }
}
