using LibraryAplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    public interface IAuthorContainer
    {
        void Add(IAuthor author);
        void Remove(IAuthor author);
        IList<IAuthor> Get();
        void UpdateSerializedData();
        void SaveForBinary();
        event EventHandler AuthorContainerChanged;
    }
}
