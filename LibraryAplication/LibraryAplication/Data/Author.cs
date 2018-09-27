using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    [Serializable]
    class Author:IAuthor
    {
        int id;
        string name;
        //DateTime DateOfBirth;


        IList<IBook> books = new List<IBook>();


        public Author(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void AddBook(IBook book)
        {
            books.Add(book);
        }
        public void RemoveBook(IBook book)
        {
            books.Remove(book);
        }

        public string authorName()
        {
            return name;
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public override string ToString()
        {
            return name;

        }

        public IList<IBook> GetWrittenBooks()
        {
            return books;
        }

        public override bool Equals(object obj)
        {
            var ob = obj as IAuthor;

            if (ob == null) return false;

            return id.Equals(ob.Id);

        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

    }
}
