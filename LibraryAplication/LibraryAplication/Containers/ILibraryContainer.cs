using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    public interface ILibraryContainer
    {
        IAuthorContainer authors { get; set; }
        IBookContainer books { get; set; }
        ICategoryContainer categories { get; set; }
        IUserContainer users { get; set; }
        IBorrowedContainer borrowed { get; set; }
        ISettingsContainer settings { get; set; }
        void Initialize();
        void Save();
    }
}
