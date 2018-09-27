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

        public event EventHandler ChategoryContainerChanged;

        public CategoryContainer()
        {
                
        }

        public CategoryContainer(IList<string> categories)
        {
            this.categories = categories;
        }

        public void Add(string category)
        {
            
            categories.Add(category);
            SaveForBinary();
            ChategoryContainerChanged?.Invoke(this,null);
        }

        public IList<string> Get()
        {
           // UpdateSerializedData();
            return categories;
        }

        public void Remove(string category)
        {
            categories.Remove(category);
            SaveForBinary();
            ChategoryContainerChanged?.Invoke(this, null);
        }

        public void SaveForBinary()
        {
            FileStream stream = File.Create("Category.data");
            format.Serialize(stream, categories);
            stream.Close();


        }
        public void UpdateSerializedData()
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
