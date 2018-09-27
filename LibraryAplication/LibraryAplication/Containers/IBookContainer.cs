using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    public interface IBookContainer
    {
        void Add(IBook book);
        void Remove(IBook book);
        IList<IBook> Get();
        void UpdateSerializedData();
        void SaveForBinary();

        event EventHandler BookContainerChanged;


    }
}
