using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;

namespace LibraryAplication.Factories
{
    class UserFactory : IUserFactory
    {
        public IUser create(string firstName, string lastName, int userId, DateTime registrationDate, string phoneNumber)
        {
            IUser user = new User(firstName, lastName, userId, registrationDate, phoneNumber);
            return user;
        }
    }
}
