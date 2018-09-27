using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    [Serializable]
    class LibraryContainer:ILibraryContainer
    {


       public IAuthorContainer authors { get; set; }
       public IBookContainer books { get; set; }
       public  ICategoryContainer categories { get; set; }
       public IUserContainer users { get; set; }
       public IBorrowedContainer borrowed { get; set; }
       public ISettingsContainer settings { get; set; }

        BinaryFormatter format = new BinaryFormatter();

        public LibraryContainer()
        {

        }

        public LibraryContainer(IAuthorContainer authors, IBookContainer books, ICategoryContainer categories,IUserContainer users,IBorrowedContainer borrowed,ISettingsContainer settings)
        {
            this.authors = authors;
            this.books = books;
            this.categories = categories;
            this.users = users;
            this.borrowed = borrowed;
            this.settings = settings;
        }
        public void Initialize()
        {
            authors =new AuthorContainer(new List<IAuthor>());
             books = new BookContainer(new List<IBook>());
            categories = new CategoryContainer(new List<string>());
            users = new UserContainer(new List<IUser>());
            borrowed = new BorrowedContainer(new List<IBookBorrowed>());
            settings = new SettingsContainer(new Settings());
            try
            {
                authors.UpdateSerializedData();
                books.UpdateSerializedData();
                categories.UpdateSerializedData();
                users.UpdateSerializedData();
                borrowed.UpdateSerializedData();
                settings.UpdateSerializedData();

            }
            catch
            {

            }
         

        }

        public void Save()
        {
            authors.SaveForBinary();
            books.SaveForBinary();
            categories.SaveForBinary();
            users.SaveForBinary();
            borrowed.SaveForBinary();
            settings.SaveForBinary();
        }
    }
}
