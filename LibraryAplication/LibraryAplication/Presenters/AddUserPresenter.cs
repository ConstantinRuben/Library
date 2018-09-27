using LibraryAplication.Data;
using LibraryAplication.Factories;
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
    class AddUserPresenter
    {
        AddUserControler userpresenter;
        ILibraryPresenter libraryPresenter;
        ValidationHelper validate;
        ToolTip toolTip;
        IUserFactory factory = new UserFactory();


        public AddUserPresenter( ILibraryPresenter presenter)
        {
            
            libraryPresenter = presenter;
            validate = new ValidationHelper(libraryPresenter);
            Initialize();

        }

        private void Initialize()
        {
            toolTip = new ToolTip();
            toolTip.InitialDelay = 100;
            toolTip.IsBalloon = true;
        }

        public void AddNewUser(string firstName, string lastName, string userId, string phone)
        {
            int userIdNumber = Convert.ToInt32(userId);
            IUser user = factory.create(firstName, lastName, userIdNumber, DateTime.Now, phone);
            libraryPresenter.Container.users.Add(user);

        }

        public void CheckPhoneNumber(TextBox textBox_phone, PictureBox pictureBoxPhone)
        {
            if (validate.HasLetters(textBox_phone.Text) || validate.IsEmpty(textBox_phone.Text))
            {
                pictureBoxPhone.Visible = true;
                toolTip.SetToolTip(pictureBoxPhone, "Enter only digits");
            }
            else if (validate.NumberLengthGreatherThan(textBox_phone.Text, 10))
            {
                pictureBoxPhone.Visible = true;
                toolTip.SetToolTip(pictureBoxPhone, "Enter a valid number");
            }
            else if (validate.PhoneExist(textBox_phone.Text))
            {
                pictureBoxPhone.Visible = true;
                toolTip.SetToolTip(pictureBoxPhone, "Other user has this Phone Number");
            }
            else
            {
                pictureBoxPhone.Visible = false;
            }
        }
    }
}
