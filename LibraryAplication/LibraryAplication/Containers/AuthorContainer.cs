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
    class AuthorContainer : IAuthorContainer
    {
        BinaryFormatter format = new BinaryFormatter();

        IList<IAuthor> authors;
        public AuthorContainer()
        {
                
        }

        public AuthorContainer(IList<IAuthor> authors)
        {
            this.authors = authors;
        }

        public void add(IAuthor author)
        {
            authors.Add(author);
            SaveForBinary();
        }

        public IList<IAuthor> get()
        {
           //updateSerialize();
            return authors;
        }

        public void removeAuthor(IAuthor author)
        {
            authors.Remove(author);
        }



        public void SaveForBinary()
        {
            FileStream stream = File.Create("AuthorData.data");
            format.Serialize(stream, authors);
            stream.Close();


        }
        public void updateSerialize()
        {
            try
            {
                FileStream stream = File.OpenRead("AuthorData.data");
                authors = (IList<IAuthor>)format.Deserialize(stream);
                stream.Close();
            }
            catch
            {
              //System.Windows.Forms.MessageBox.Show("Mising AuthorData");
            }
        }


    }
}
