using LibraryAplication.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication
{
    public partial class RecordsForm : Form
    {
        ILibraryPresenter _libraryPresenter;
        RecorsPresenter presenter;
        public RecordsForm(ILibraryPresenter libraryPresenter)
        {
            _libraryPresenter = libraryPresenter;
            InitializeComponent();
            presenter = new RecorsPresenter(libraryPresenter);
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            presenter.LoadReservationDaTa(dataGridViewRecords);
        }
    }
}
