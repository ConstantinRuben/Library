using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    public interface ICategoryContainer
    {
        void Add(string category);
        void Remove(string category);
        IList<string> Get();
        void UpdateSerializedData();
        void SaveForBinary();
        event EventHandler ChategoryContainerChanged;
    }
}
