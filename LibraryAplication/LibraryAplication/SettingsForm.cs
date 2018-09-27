using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Helper;
using LibraryAplication.Presenters;

namespace LibraryAplication
{
    public partial class SettingsForm : Form
    {
        ILibraryPresenter _libraryPresenter;
        ValidationHelper validationHelper;
        public SettingsForm(ILibraryPresenter libraryPresenter)
        {
            _libraryPresenter = libraryPresenter;
            _libraryPresenter.Container.settings.GetSettings().ThemeChanged += LoadTheme;
            validationHelper = new ValidationHelper(_libraryPresenter);
            InitializeComponent();
            InitializeSetings();
        }

        private void InitializeSetings()
        {
            try
            {
                LoadTheme(this, null);
            }
            catch
            {

            }
        }

        private void ChangeThemeColorFromtLabel_Click(object sender, EventArgs e)
        {
            Label labelColor = sender as Label;
            _libraryPresenter.Container.settings.GetSettings().Theme = labelColor.BackColor;
            _libraryPresenter.Container.Save();


        }


        private void LoadTheme(object sender, EventArgs e)
        {
            Color Theme = _libraryPresenter.Container.settings.GetSettings().Theme;
            this.BackColor = Theme;

        }

        private void textBox_Predefined_Days_TextChanged(object sender, EventArgs e)
        {
            if (validationHelper.NumberLengthGreatherThan(textBox_Predefined_Days.Text, 2))
            {
                textBox_Predefined_Days.Text = 10.ToString();
            }
            else if(validationHelper.HasLetters(textBox_Predefined_Days.Text))
            {
                textBox_Predefined_Days.Text = 10.ToString();
            }
            else
            {
                try
                {
                _libraryPresenter.Container.settings.GetSettings().DefaultDays = Convert.ToInt32(textBox_Predefined_Days.Text);
                }
                catch
                {

                }
            }


        }
    }
}
