using LibraryAplication.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;

namespace LibraryAplication.Helper
{
    class UserSearchHelper:IUserSearchHelper
    {
        ILibraryPresenter presenter;
        IList<IUser> usersList;

        public UserSearchHelper(ILibraryPresenter presenter)
        {
            this.presenter = presenter;
            usersList = presenter.GetUsers();
        }

        public IList<IUser> Search(string textSearched)
        {
            return SearchByUserName(textSearched);
        }

        private IList<IUser> SearchByUserName(string textSearched)
        {

           var searchResult = from user in usersList
                               where user.FirstName.ToLower().Contains(textSearched.ToLower())
                              || user.LastName.ToLower().Contains(textSearched.ToLower())
                               select user;


            return searchResult.ToList();
        }


    }
}
