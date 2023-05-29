using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepcja
{
    public partial class EditAppointment : Form
    {
        public string doctorid;
        public EditAppointment()
        {
            InitializeComponent();



            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "VisitViewClearCalendar");
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchVisit_Click(object sender, EventArgs e)
        {
            string searchText = txtPesel.Text;
            string columnName = "PatientPesel";

            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.SearchDataInView(searchText, "VisitView", dataGridView_lista_wizyt, columnName);
        }

        private void btnEditVisit_Click(object sender, EventArgs e)
        {
            CalenderAddNewVisit form_VisitDetails = new CalenderAddNewVisit();
            form_VisitDetails.TopLevel = false;
            form_VisitDetails.FormBorderStyle = FormBorderStyle.None;
            form_VisitDetails.Dock = DockStyle.Fill;
            form_ReceptionMenu2 receptionMenu2 = Application.OpenForms["form_ReceptionMenu2"] as form_ReceptionMenu2;
            receptionMenu2.panel1.Controls.Add(form_VisitDetails);
            receptionMenu2.panel1.Tag = form_VisitDetails;
            form_VisitDetails.BringToFront();
            form_VisitDetails.Show();

            addNewVisit addNewVisit = new addNewVisit();





        }
    }
}
