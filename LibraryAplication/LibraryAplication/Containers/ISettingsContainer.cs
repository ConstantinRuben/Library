using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    public interface ISettingsContainer
    {
        
        ISettings GetSettings();
        void UpdateSerializedData();
        void SaveForBinary();
    }
}
