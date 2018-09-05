using LibraryAplication.Containers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication
{
    class BookProvider
    {
        IAuthorContainer authors;
        IBookContainer books;
        ICategoryContainer categories;

        public BookProvider(IBookContainer books)
        {
            this.books = books;
        }

        public  DataTable getBookDatatable()
        {
            DataTable dt = new DataTable();
            var bookslist = books.get();


            dt.Columns.Add("ISBN");
            dt.Columns.Add("BookTitle");
            dt.Columns.Add("NumberOFCopies");
            //dt.Columns.Add("Publisher");
            //dt.Columns.Add("RelaseDate");
            foreach (var item in bookslist)
            {
                var row = dt.NewRow();

                row["ISBN"] = item.ISBN1;
                row["BookTitle"] = Convert.ToString(item.BookTitle);
                row["NumberOFCopies"] = item.NumberOfCopies.ToString();

                dt.Rows.Add(row);
            }

            return dt;



            
        }


    }
}
