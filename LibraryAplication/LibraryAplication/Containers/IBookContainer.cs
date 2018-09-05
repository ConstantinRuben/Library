using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    interface IBookContainer
    {
        void add(IBook book);
        void remove(IBook book);
        IList<IBook> get();
        void updateSerialize();


    }
}
