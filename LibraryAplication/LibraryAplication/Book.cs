using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication
{
    [Serializable]
    class Book:IBook
    {
        public Book()
        {

        }
        string ISBN;
        string bookTitle;

        int numberOfCopies;
       
        string publisher;
        DateTime relaseDate;
        IList<IAuthor> authors = new List<IAuthor>();


        BookCover cover = new BookCover();

        public string ISBN1
        {
            get
            {
                return ISBN;
            }

            set
            {
                ISBN = value;
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
            }
        }

        public int NumberOfCopies
        {
            get
            {
                return numberOfCopies;
            }

            set
            {
                numberOfCopies = value;
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

        public IList<string> Category { get; set; }
        

        public Book(string iSBN, string bookTitle, int numberOfCopies, string publisher, IList<string> category)
        {
            ISBN = iSBN;
            this.BookTitle = bookTitle;
            this.NumberOfCopies = numberOfCopies;
            this.Publisher = publisher;
           // this.relaseDate = relaseDate;
            Category = category;

    }

        void AddAuthor(IAuthor author)
        {
            authors.Add(author);
            author.AddBook(this);
        }

        public bool IsAvalabile()
        {
            return NumberOfCopies > 0;
        }

        void IBook.AddAuthor(IAuthor author)
        {
            authors.Add(author);
            author.AddBook(this);
        }

        public void addCover(BookCover cover)
        {
            this.cover = cover;
        }

        public Image DisplayCover()
        {
            return cover.get();
        }
    }
}
