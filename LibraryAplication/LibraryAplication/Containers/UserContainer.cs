using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    class UserContainer:IUserContainer
    {
        BinaryFormatter format = new BinaryFormatter();
        IList<IUser> users = new List<IUser>();

        public event EventHandler UserContainerChanged;
        
        public UserContainer()
        {

        }

        public UserContainer(IList<IUser> users)
        {
            this.users = users;
        }


        public void Add(IUser user)
        {
            users.Add(user);
            SaveForBinary();
            UserContainerChanged?.Invoke(this, null);
        }

        public IList<IUser> Get()
        {
            return users;
        }

        public void Remove(IUser user)
        {
            users.Remove(user);
            UserContainerChanged?.Invoke(this, null);
        }

        public void SaveForBinary()
        {
            FileStream stream = File.Create("User.data");
            format.Serialize(stream, users);
            stream.Close();
        }

        public void UpdateSerializedData()
        {
            try
            {
                FileStream stream = File.OpenRead("User.data");
                users = (IList<IUser>)format.Deserialize(stream);
                stream.Close();
            }
            catch
            {
                //System.Windows.Forms.MessageBox.Show("Mising AuthorData");
            }
        }
    }
}
