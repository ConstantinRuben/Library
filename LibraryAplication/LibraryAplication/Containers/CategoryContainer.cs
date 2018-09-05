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
    class CategoryContainer:ICategoryContainer
    {
        BinaryFormatter format = new BinaryFormatter();

        IList<string> categories = new List<string>();
        public CategoryContainer()
        {
                
        }

        public CategoryContainer(IList<string> categories)
        {
            this.categories = categories;
        }

        public void add(string category)
        {
            categories.Add(category);
            SaveForBinary();
        }

        public IList<string> Get()
        {
           // updateSerialize();
            return categories;
        }

        public void remove(string category)
        {
            categories.Remove(category);
        }

        public void SaveForBinary()
        {
            FileStream stream = File.Create("Category.data");
            format.Serialize(stream, categories);
            stream.Close();


        }
        public void updateSerialize()
        {
            try
            {
                FileStream stream = File.OpenRead("Category.data");
                categories = (IList<string>)format.Deserialize(stream);
                stream.Close();
            }
            catch
            {
                //System.Windows.Forms.MessageBox.Show("Mising Category");
            }
        }
    }
}
