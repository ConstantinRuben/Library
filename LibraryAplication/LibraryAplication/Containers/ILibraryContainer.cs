using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    interface ILibraryContainer
    {
        IAuthorContainer authors { get; set; }
        IBookContainer Books { get; set; }
        ICategoryContainer Categories { get; set; }
    }
}
