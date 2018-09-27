using LibraryAplication.Data;
using LibraryAplication.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication.Helper
{
    class ValidationHelper
    {
        ILibraryPresenter _libraryPresenter;
        public ValidationHelper(ILibraryPresenter libraryPresenter)
        {
            _libraryPresenter = libraryPresenter;
        }


        public bool HasDigits(string text)
        {
            if (Regex.IsMatch(text, "[0-9]"))
            {
                return true;
            }
            return false;



        }

        public bool HasLetters(string text)
        {
            if (Regex.IsMatch(text, "[^0-9]"))
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public bool ISBNExist(string text)
        {
            foreach (IBook book in _libraryPresenter.GetBooks())
            {
                if (book.ISBN.Equals(text))
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckIsbnForEdit(string text, string isbn)
        {
            if (text.Equals(isbn)) return false;
            foreach (IBook book in _libraryPresenter.GetBooks())
            {
                if (book.ISBN.Equals(text))
                {
                    return true;
                }
            }
            return false;

        }
        public bool NumberLengthGreatherThan(string text, int number)
        {
            if (text.Length > number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PhoneExist(string text)
        {
            foreach (IUser user in _libraryPresenter.GetUsers())
            {
                if (user.PhoneNumber.Equals(text)) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
