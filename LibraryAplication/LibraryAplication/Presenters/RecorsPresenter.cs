using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Data;
using System.Data;

namespace LibraryAplication.Presenters
{
    class RecorsPresenter
    {
        ILibraryPresenter _libraryPresenter;
        DataGridView dataGridViewRecords;
        public RecorsPresenter(ILibraryPresenter libraryPresenter)
        {
            _libraryPresenter = libraryPresenter;
        }

        public void LoadReservationDaTa(DataGridView dataGridRecords)
        {
            dataGridViewRecords = dataGridRecords;

            dataGridViewRecords.DataSource = GetDataFromList(_libraryPresenter.Container.borrowed.GetAllRecords());
        }

        private object GetDataFromList(IList<IBookBorrowed> list)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ISBN");
            dataTable.Columns.Add("BookTitle");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("User");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("BorrowedDate");
            dataTable.Columns.Add("DaysLeft");
            dataTable.Columns.Add("ReturnDate");


                foreach (IBookBorrowed book in list)
                {
                    var row = dataTable.NewRow();

                    row["ISBN"] = book.Book.ISBN;
                    row["BookTitle"] = book.Book.BookTitle;
                    row["Author"] = book.Book.Authors.First();
                    row["User"] = book.User.FirstName + " " + book.User.LastName;
                    row["Phone"] = book.User.PhoneNumber;
                    row["BorrowedDate"] = book.BarowedDate.ToString();
                    if (book.ReturnDate == null || book.ReturnDate == default(DateTime))
                    {
                        row["ReturnDate"] = "-";
                        row["DaysLeft"] = book.NumberOfDaysLeft();
                    }
                    else
                    {
                        row["ReturnDate"] = book.ReturnDate.ToShortDateString();
                        row["DaysLeft"] = "Returned";
                    }
                    dataTable.Rows.Add(row);
                }
            
            return dataTable;
        }
    }
}
