using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Containers;
using LibraryAplication.Factories;
using LibraryAplication.User_Controls;

namespace LibraryAplication.Presenters
{
    class AuthorListPresenter
    {
        AuthorsList _authorsList;
        LibraryContainer container = new LibraryContainer();
        AuthorFactory factory = new AuthorFactory();
        public AuthorListPresenter(AuthorsList authorsList)
        {
            _authorsList = authorsList;
            container.initialize();
        }

        public void AddNewAuthor(string authorName)
        {
            IAuthor author = factory.create(authorName);
            container.authors.add(author);

        }
    }
}
