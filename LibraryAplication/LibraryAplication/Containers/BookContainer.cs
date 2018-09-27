using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LibraryAplication.Containers
{
    [Serializable]
    class BookContainer:IBookContainer
    {
        IList<IBook> booksList;

        public event EventHandler BookContainerChanged;

        BinaryFormatter format = new BinaryFormatter();
        public BookContainer()
        {
        }

        public BookContainer(IList<IBook> booksList)
        {
            this.booksList = booksList;

        }

    

        public void Add(IBook book)
        {
            booksList.Add(book);
            SaveForBinary();
            BookContainerChanged?.Invoke(this,null);
        }

        public IList<IBook> Get()
        {
           // UpdateSerializedData();
            return booksList;
        }

     

        public void Remove(IBook book)
        {
            foreach (var item in book.Authors)
            {
                item.RemoveBook(book);
            }
            booksList.Remove(book);
            SaveForBinary();
            BookContainerChanged?.Invoke(this, null);
        }
        public void SaveforXML()
        {

            
            //string path = @"E:\itSix2\LUCRU\3007\LibraryAplication\LibraryAplication";
            //using (FileStream filestream = new FileStream("bookList", FileMode.Create))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            //    serializer.Serialize(filestream, typeof(List<Book>));
            //}
        }
        public void SaveForBinary()
        {
            FileStream stream = File.Create("booksData.data");
            format.Serialize(stream, booksList);
            stream.Close();


        }
        public void UpdateSerializedData()
        {
            try
            {
                FileStream stream = File.OpenRead("booksData.data");
                booksList = (IList<IBook>)format.Deserialize(stream);
                stream.Close();
            }
            catch
            {
              // System.Windows.Forms.MessageBox.Show("Mising booksData");
            }
        }
        
    }
}
