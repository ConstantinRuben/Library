using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Presenters;

namespace LibraryAplication
{
    public partial class AdvancedSearchForm : Form
    {
        ILibraryPresenter _libraryPresenter;
        AdvanceSearchPresenter presenter;
        public AdvancedSearchForm(ILibraryPresenter libraryPresenter)
        {
            InitializeComponent();
            _libraryPresenter = libraryPresenter;
             presenter = new AdvanceSearchPresenter(_libraryPresenter,flowLayoutPanel_SearchResult);
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            presenter.SetFieldsSearched(textBox_ISBN.Text,textBox_BookTitle.Text);
            presenter.GetSearchResult();
                
        }
    }
}
