using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    interface IAuthorContainer
    {
        void add(IAuthor author);
        void removeAuthor(IAuthor author);
        IList<IAuthor> get();
        void updateSerialize();
    }
}
