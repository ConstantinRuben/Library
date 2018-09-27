using LibraryAplication.Data;
using LibraryAplication.Helper;
using LibraryAplication.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAplication.Presenters
{
    class HomePresenter
    {
        int NumberOfBooksForMostRead = 0;
        ILibraryPresenter _libraryPresenter;
        BookSearchPresenter searchPresenter;
        ISearchHelper searchHelper;
        FlowLayoutPanel _flowLayoutPanelMostRead;

        public HomePresenter(ILibraryPresenter libraryPresenter)
        {
            _libraryPresenter = libraryPresenter;
            searchPresenter = new BookSearchPresenter(_libraryPresenter);
            searchHelper = new GeneralSearchHelper(_libraryPresenter);

        }

        public void GetMostReadBooks(FlowLayoutPanel flowLayoutPanelMostRead)
        {
            _flowLayoutPanelMostRead = flowLayoutPanelMostRead;
           _libraryPresenter.Container.borrowed.BorrowedContainerChanged += RefreshMostReadBooksAfterNewRezervation;
            NumberOfBooksForMostRead += 5;
            ClearLastResult(flowLayoutPanelMostRead);
            searchPresenter.GetMostReadBooks(flowLayoutPanelMostRead, NumberOfBooksForMostRead);
        }

        public void loadNotification(Label label_Notification)
        {
            
            int temporarNumber = CheckReservationForNotification();
            if (temporarNumber > 0)
            {
                label_Notification.Text = temporarNumber.ToString() + " Users Are Late";
                label_Notification.Visible = true;
            }

        }

        private int CheckReservationForNotification()
        {
            int notificationCounter = 0;
            foreach (var item in _libraryPresenter.Container.borrowed.GetAllRecords())
            {
                if(item.NumberOfDaysLeft()<0)
                {
                    notificationCounter++;
                }
            }
            return notificationCounter;

        }

        public void RefreshMostReadBooksAfterNewRezervation(object sender, EventArgs e)
        {
           searchPresenter.GetMostReadBooks(_flowLayoutPanelMostRead, NumberOfBooksForMostRead);
        }

        public void displayAllBooks(FlowLayoutPanel flowLayoutPanelAllBooks)
        {
            try
            {
            ClearLastResult(flowLayoutPanelAllBooks);
            }
            catch
            {

            }
            foreach (var item in _libraryPresenter.GetBooks())
            {

                BookUserControler bookcontroler = new BookUserControler(item, _libraryPresenter);
                flowLayoutPanelAllBooks.Controls.Add(bookcontroler);
            }
        }
        private void ClearLastResult(FlowLayoutPanel panel)
        {
            foreach (BookUserControler item in panel.Controls)
            {

                item.Visible = false;

            }
        }

        public void OpenRezervationForm()
        {
            RezervationForm rezevationForm = new RezervationForm(_libraryPresenter);
            rezevationForm.Show();
        }

        public void OpenRecordsForm()
        {
            RecordsForm records = new RecordsForm(_libraryPresenter);
            records.Show();
        }

        public void SearchForMainForm(FlowLayoutPanel flowLayoutPanelTabPage2, string text)
        {
            searchPresenter.Search(flowLayoutPanelTabPage2, text);
        }

        public void OpenSettingsForm()
        {

            SettingsForm settings = new SettingsForm(_libraryPresenter); ;
            settings.Show();
        }

        public void OpenAdvancedSearch()
        {
            AdvancedSearchForm advancedSearch = new AdvancedSearchForm(_libraryPresenter);
            advancedSearch.Show();
        }

        public void SearchCategory(FlowLayoutPanel flowLayoutPanelCategory, string text)
        {
            try
            {
                ClearLastResult(flowLayoutPanelCategory);
            }
            catch
            {

            }
            foreach (var item in searchHelper.SearchBookByCategory(text))
            {

                BookUserControler bookcontroler = new BookUserControler(item, _libraryPresenter);
                flowLayoutPanelCategory.Controls.Add(bookcontroler);
            }
        }
    }
}
