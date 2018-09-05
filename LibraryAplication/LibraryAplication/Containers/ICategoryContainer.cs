using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    interface ICategoryContainer
    {
        void add(string category);
        void remove(string category);
        IList<string> Get();
        void updateSerialize();
    }
}
