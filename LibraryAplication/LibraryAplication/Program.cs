using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Presenters;

namespace LibraryAplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HomeForm home = new HomeForm();
          //  ILibraryPresenter presenter = new LibraryPresenter(home);
            Application.Run(home);
            
        }
    }
}
