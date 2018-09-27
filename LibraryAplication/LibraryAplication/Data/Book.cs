using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Data
{
    [Serializable]
    class Book : IBook
    {
        public Book()
        {

        }
        string isbn;
        string bookTitle;
        IBookCopies bookCopies;
        string publisher;
        DateTime relaseDate;
        BookCover cover = new BookCover();
        IList<string> categories;
         IList<IAuthor> authors;


        [field:NonSerialized]
        public event EventHandler BookEdited;


        #region Prop
        public string ISBN
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
                BookEdited?.Invoke(this,null);
            }
        }

        public string BookTitle
        {
            get
            {
                return bookTitle;
            }

            set
            {
                bookTitle = value;
              //  BookEdited?.Invoke(this, null);
            }
        }

        public IBookCopies BookCopies
        {
            get
            {
                return bookCopies;
            }

            set
            {
                bookCopies = value;
            }
        }


        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

        public DateTime RelaseDate
        {
            get
            {
                return relaseDate;
            }

            set
            {
                relaseDate = value;
            }
        }

        public IList<string> Categories
        {
            get
            {
                return categories;
            }

            set
            {
                categories = value;
            }
        }

        public IList<IAuthor> Authors
        {
            get
            {
                return authors;
            }

            set
            {
                authors = value;
            }
        }
        #endregion

        public Book(string iSBN, string bookTitle, int numberOfCopies, string publisher, DateTime dateTime, IList<string> category)
        {
            isbn = iSBN;
            this.BookTitle = bookTitle;
            bookCopies = new BookCopies(numberOfCopies);
            this.Publisher = publisher;
            this.relaseDate = dateTime;
            categories = category;
            authors = new List<IAuthor>();
            
        }

       public  void AddAuthor(IAuthor author)
        {
            authors.Add(author);
            author.AddBook(this);
        }

        public bool IsAvalabile()
        {
            return BookCopies.NumberOfBookLeft > 0;
        }


        public void AddCover(BookCover cover)
        {
            this.cover = cover;
        }

        public void RemoveAuthor(IAuthor author)
        {
            authors.Remove(author);
            author.RemoveBook(this);
        }
        public Image DisplayCover()
        {
            return cover.Get();
            
        }
        
        public override bool Equals(object obj)
        {
            var ob = obj as IBook;

            if (ob == null) return false;

            return isbn.Equals(ob.ISBN);

        }

        public override int GetHashCode()
        {
            return isbn.GetHashCode();
        }
        private void ModifyNumberOfCopies()
        {


        }

    }
}
