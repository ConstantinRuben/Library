using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;

namespace LibraryAplication.Containers
{
    public interface IBorrowedContainer
    {
        void Add(IBookBorrowed book);
        void Remove(IBookBorrowed book);
        IList<IBookBorrowed> GetAllRecords();
        void UpdateSerializedData();
        void SaveForBinary();
        event EventHandler BorrowedContainerChanged;
    }
}
