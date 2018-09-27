using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using LibraryAplication.Data;

namespace LibraryAplication.Containers
{
    [Serializable]
    class BorrowedContainer:IBorrowedContainer
    {
        IList<IBookBorrowed> TotalBarrowedList;
   
        public event EventHandler BorrowedContainerChanged;
        
        BinaryFormatter format = new BinaryFormatter();
        public BorrowedContainer()
        {

        }

        public BorrowedContainer(IList<IBookBorrowed> totalBarrowedList)
        {
            TotalBarrowedList = totalBarrowedList;
        }

        public void Add(IBookBorrowed book)
        {
            TotalBarrowedList.Add(book);
            SaveForBinary();
            BorrowedContainerChanged?.Invoke(this,null);
        }

        public IList<IBookBorrowed> GetAllRecords()
        {
            return TotalBarrowedList;
        }

        public void Remove(IBookBorrowed book)
        {
            TotalBarrowedList.Remove(book);
            SaveForBinary();
        }

        public void SaveForBinary()
        {
            FileStream stream = File.Create("BookBarrowed.data");
            format.Serialize(stream, TotalBarrowedList);
            stream.Close();
        }

        public void UpdateSerializedData()
        {
            try
            {
                FileStream stream = File.OpenRead("BookBarrowed.data");
                TotalBarrowedList = (IList<IBookBorrowed>)format.Deserialize(stream);
                stream.Close();
            }
            catch
            {
                
            }
        }
   
    }
}
