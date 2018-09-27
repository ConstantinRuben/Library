using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Factories
{
    class AuthorFactory : IAuthorFactory
    {
        

        public IAuthor Create(string authorName,int id)
        {
            IAuthor author = new Author(authorName,id);
            return author;
        }
    }
}
