using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication.Containers
{
    [Serializable]
    class Settings : ISettings
    {
        Color theme;
        int defaltDays;

        [field: NonSerialized]
        public event EventHandler ThemeChanged;
        [field:NonSerialized]
        public event EventHandler DefaultDaysChanged;

        public Settings()
        {

        }


        public Color Theme
        {
            get
            {
                return theme;
            }
            set
            {
                theme = value;
                ThemeChanged?.Invoke(this, null);
            }
        }
        public int DefaultDays
        {
            get
            {
                return defaltDays;
            }
            set
            {
                defaltDays = value;
                DefaultDaysChanged?.Invoke(this,null);
            }

        }

        public void ChangeTheme(Color otherTheme)
        {
            theme = otherTheme;
        }


    }
}
