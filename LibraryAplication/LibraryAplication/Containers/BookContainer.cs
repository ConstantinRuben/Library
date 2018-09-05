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

       
        BinaryFormatter format = new BinaryFormatter();
        public BookContainer()
        {
        }

        public BookContainer(IList<IBook> booksList)
        {
            this.booksList = booksList;

        }

    

        public void add(IBook book)
        {
            booksList.Add(book);
            SaveForBinary();
        }

        public IList<IBook> get()
        {
         //   updateSerialize();
            return booksList;
        }

     

        public void remove(IBook book)
        {
            booksList.Remove(book);
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
        public void updateSerialize()
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
