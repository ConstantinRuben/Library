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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void labelAboutUs_Click(object sender, EventArgs e)
        {
            AddBookForm ob1 = new AddBookForm();
            ob1.TopLevel = false;
            tabPage4.Controls.Add(ob1);
            ob1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob1.Dock = DockStyle.Fill;
            tabControl1.SelectedTab = tabPage4;
            ob1.Show();

        }

        private void labelBrowse_MouseHover(object sender, EventArgs e)
        {
            panelBrowse.Visible = true;
        }

        private void labelBrowse_MouseLeave(object sender, EventArgs e)
        {
            panelBrowse.Visible = false;
        }

        private void labelAddBooks_MouseHover(object sender, EventArgs e)
        {
            panelAddBooks.Visible = true;
        }

        private void labelAddBooks_MouseLeave(object sender, EventArgs e)
        {
            panelAddBooks.Visible = false;
        }

        private void labelAddBooks_Click(object sender, EventArgs e)
        {
            AddBookForm ob = new AddBookForm();
             ob.Show();

        }


        private void label_MouseHoverChangeCollorToRed(object sender, EventArgs e)
        {

            Label labeltemp = sender as Label;
            Color col = Color.FromArgb(209, 61, 25);
            labeltemp.ForeColor = col;

        }

        private void label_MouseLeaveChangeCollor(object sender , EventArgs e)
        {

            Label labeltemp = sender as Label;
            labeltemp.ForeColor = Color.White;

        }
    }
}
