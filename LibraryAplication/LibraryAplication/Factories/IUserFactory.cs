using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Factories
{
    interface IUserFactory
    {
        IUser create(string firstName, string lastName, int userId, DateTime registrationDate, string phoneNumber);
    }
}
