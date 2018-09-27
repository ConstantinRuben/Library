using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAplication.Containers;
using LibraryAplication.Presenters;
using LibraryAplication.User_Controls;

namespace LibraryAplication
{
    public partial class HomeForm : Form
    {
        ILibraryPresenter libraryPresenter;
        HomePresenter presenter;

      

        public HomeForm()
        {
            InitializeComponent();
            Initialize();

        }

       
        private void Initialize()
        {
            libraryPresenter = new LibraryPresenter();
            presenter = new HomePresenter(libraryPresenter);

            libraryPresenter.Container.books.BookContainerChanged += RefreshAllBooks;

            presenter.displayAllBooks(flowLayoutPanelAllBooks);
            libraryPresenter.Container.settings.GetSettings().ThemeChanged += LoadTheme;
            try
            {
            LoadTheme(this,null);
            }
            catch
            {

            }

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            presenter.loadNotification(label_Notification);

            setUserTabPage();
            InitializeMostReadBooks();
            



        }

        private void InitializeMostReadBooks()
        {
            presenter.GetMostReadBooks(flowLayoutPanelMostRead);
        }

        private void setUserTabPage()
        {

            UserForm userform = new UserForm(libraryPresenter);
            userform.FormBorderStyle = FormBorderStyle.None;
            userform.Dock = DockStyle.Fill;
            userform.Show();
            userform.TopLevel = false;
            panelUserTapPage.Controls.Add(userform);
          

        }

        private void labelAddBooks_Click(object sender, EventArgs e)
        {
            AddBookForm ob = new AddBookForm(libraryPresenter);
            ob.Show();

        }


        private void label_MouseHoverChangeCollorToRed(object sender, EventArgs e)
        {

            Label labeltemp = sender as Label;
            Color col = Color.FromArgb(209, 61, 25);
            labeltemp.ForeColor = col;

        }

        private void label_MouseLeaveChangeCollor(object sender, EventArgs e)
        {

            Label labeltemp = sender as Label;
            labeltemp.ForeColor = Color.White;

        }

        private void labelBrowse_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageBrowse;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //presenter.SearchForMainForm(flowLayoutPanelTabPage2, textBoxSearchBar.Text);
            //tabControl1.SelectedTab = tabPageSearchResul;
            //textBoxSearchBar.Select();
            presenter.OpenAdvancedSearch();

        }

        private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            presenter.SearchForMainForm(flowLayoutPanelTabPage2, textBoxSearchBar.Text);
            tabControl1.SelectedTab = tabPageSearchResul;
            textBoxSearchBar.Select();
           
        }

        private void labelUsers_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageUsers;
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageTemporaryTest;
            Label label = sender as Label;
            presenter.SearchCategory(flowLayoutPanelCategory, label.Text);
        }

        private void btnRezervation_Click(object sender, EventArgs e)
        {
            presenter.OpenRezervationForm();
        }
        public void RefreshAllBooks(object sender, EventArgs e)
        {
            presenter.displayAllBooks(flowLayoutPanelAllBooks);
        }
        private void btnRecords_Click(object sender, EventArgs e)
        {
            presenter.OpenRecordsForm();
        }

        private void label_MostReadLoadMore_Click(object sender, EventArgs e)
        {
            presenter.GetMostReadBooks(flowLayoutPanelMostRead);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            presenter.OpenSettingsForm();
        }
        private void LoadTheme(object sender, EventArgs e)
        {
            Color Theme = libraryPresenter.Container.settings.GetSettings().Theme;
            panelCategories.BackColor = Theme;
            panelRight1.BackColor = Theme;
            panelRight2.BackColor = Theme;
            panelRight3.BackColor = Theme;
            panelRight4.BackColor = Theme;

        }

        private void label_Notification_Click(object sender, EventArgs e)
        {
            presenter.OpenRecordsForm();
            label_Notification.Visible = false;
        }
    }
}
