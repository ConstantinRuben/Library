using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Factories
{
    class AuthorFactory : IAuthorFactory
    {
        

        public IAuthor create(string authorName)
        {
            IAuthor author = new Author(authorName);
            return author;
        }
    }
}
