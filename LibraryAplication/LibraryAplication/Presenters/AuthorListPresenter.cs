using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Containers;
using LibraryAplication.Factories;
using LibraryAplication.User_Controls;
using LibraryAplication.Data;

namespace LibraryAplication.Presenters
{
    class AuthorListPresenter
    {
        AuthorsList authorsList;

        IAuthorFactory factory = new AuthorFactory();
         ILibraryPresenter libraryPresenter;


        public AuthorListPresenter(ILibraryPresenter libraryPresenter, AuthorsList authorsList)
        {
            this.libraryPresenter = libraryPresenter;
            this.authorsList = authorsList;
        }

        public void AddNewAuthor(string authorName,string id)
        {
            int number;
            bool idvalid= int.TryParse(id,out number);
            IAuthor author = factory.Create(authorName,number);
            libraryPresenter.Container.authors.Add(author);

        }
    }
}
