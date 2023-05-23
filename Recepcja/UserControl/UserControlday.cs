using Recepcja.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_handling
{
    public partial class UserControlday : UserControl
    {
        public static string static_day;
        public UserControlday()
        {
            InitializeComponent();
        }

        private void UserControlday_Load(object sender, EventArgs e)
        {

        }
        public void Day(int numday)
        {
            labelday.Text = numday + "";
        }

        public void UserControlday_Click(object sender, EventArgs e)
        {
            static_day = labelday.Text;
           // addNewVisit addnewvisit = new addNewVisit();
            //addnewvisit.Show();

            addNewVisit form_VisitDetails = new addNewVisit();
            form_VisitDetails.TopLevel = false;
            form_VisitDetails.FormBorderStyle = FormBorderStyle.None;
            form_VisitDetails.Dock = DockStyle.Fill;
            form_ReceptionMenu2 receptionMenu2 = Application.OpenForms["form_ReceptionMenu2"] as form_ReceptionMenu2;
            receptionMenu2.panel1.Controls.Add(form_VisitDetails);
            receptionMenu2.panel1.Tag = form_VisitDetails;
            form_VisitDetails.BringToFront();
            form_VisitDetails.Show();

        }

        public void changeLabelColor(Color color)
        {
            labelday.ForeColor = color;
        }
    }
}
