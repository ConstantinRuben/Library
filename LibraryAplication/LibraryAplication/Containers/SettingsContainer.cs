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
    class SettingsContainer:ISettingsContainer
    {
        ISettings settings;


        BinaryFormatter format = new BinaryFormatter();

        public SettingsContainer()
        {

        }


        public SettingsContainer(ISettings settings)
        {
            this.settings = settings;
        }



        public void SaveForBinary()
        {
            FileStream stream = File.Create("Settings.data");
            format.Serialize(stream, settings);
            stream.Close();


        }
        public void UpdateSerializedData()
        {
            try
            {
                FileStream stream = File.OpenRead("Settings.data");
                settings = (ISettings)format.Deserialize(stream);
                stream.Close();
            }
            catch
            {
                // System.Windows.Forms.MessageBox.Show("Mising booksData");
            }
        }

        public ISettings GetSettings()
        {
            return settings;
        }
    }
}
