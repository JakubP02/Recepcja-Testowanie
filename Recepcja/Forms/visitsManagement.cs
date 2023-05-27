using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_handling
{
    public partial class ZarzadzanieWizytami : Form
    {

        public static string office;
        public static string patientName;
        public static string doctorName;
        public static string date;
        public static string hour;



        public ZarzadzanieWizytami()
        {
            InitializeComponent();

            DatabaseConnection database = new DatabaseConnection();
            database.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "Visitview");

        }

        private void ZarządzanieWizytami_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_lista_wizyt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            form_visitDetails form_VisitDetails = new form_visitDetails();
            form_VisitDetails.TopLevel = false;
            form_VisitDetails.FormBorderStyle = FormBorderStyle.None;
            form_VisitDetails.Dock = DockStyle.Fill;
            form_ReceptionMenu2 receptionMenu2 = Application.OpenForms["form_ReceptionMenu2"] as form_ReceptionMenu2;
            receptionMenu2.panel1.Controls.Add(form_VisitDetails);
            receptionMenu2.panel1.Tag = form_VisitDetails;
            form_VisitDetails.BringToFront();
            form_VisitDetails.Show();




        }



        private void button_cancel_visit_Click(object sender, EventArgs e)
        {

            int selcetedcalendarId = Convert.ToInt32(dataGridView_lista_wizyt.SelectedRows[0].Cells["ID"].Value);
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.UpdateCalendarEntity(selcetedcalendarId);
            databaseConnection.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "visitview");





        }
        private void UpdateTextBoxValues(DataGridViewRow selectedRow)
        {




        }
        private void button_Send_confirmation_Click(object sender, EventArgs e)
        {


            string office = dataGridView_lista_wizyt.SelectedRows[0].Cells["OfficeNumber"].Value.ToString();
            string date = ((DateTime)dataGridView_lista_wizyt.SelectedRows[0].Cells["Date"].Value).ToString("yyyy-MM-dd");
            string time = ((TimeSpan)dataGridView_lista_wizyt.SelectedRows[0].Cells["Time"].Value).ToString("hh':'mm");
            string pesel = dataGridView_lista_wizyt.SelectedRows[0].Cells["PatientPesel"].Value.ToString();
            string email;
            DatabaseConnection db = new DatabaseConnection();
            email = db.GetPatientEmail(pesel);

            MedicalVisit medicalVisit = new MedicalVisit();
            medicalVisit.SendConfirmation(office, date, time, email);




        }
        private void button_Clear_the_calendar_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "VisitViewClearCalendar");
        }

        public void dataGridView_lista_wizyt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }
        private void dataGridView_lista_wizyt_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_lista_wizyt.SelectedRows.Count > 0)
            {
          


            }
        }

        private void btnSearchVisit_Click(object sender, EventArgs e)
        {
            string searchText = txtPesel.Text;
            string columnName = "PatientPesel";

            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.SearchDataInView(searchText, "VisitView", dataGridView_lista_wizyt, columnName);



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPesel_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
