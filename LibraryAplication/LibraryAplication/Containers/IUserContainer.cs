using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    public interface IUserContainer
    {

        void Add(IUser user);
        void Remove(IUser user);
        IList<IUser> Get();
        void UpdateSerializedData();
        void SaveForBinary();
        event EventHandler UserContainerChanged;
    }
}
