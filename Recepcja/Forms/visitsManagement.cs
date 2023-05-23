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

        public static string patientName, doctorName, date, hour;

        public string visitId { get; set; }
        public ZarzadzanieWizytami()
        {
            InitializeComponent();

            DatabaseConnection database = new DatabaseConnection();
            database.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "Visitview");

            if (dataGridView_lista_wizyt.Rows.Count > 0)
            {
                //Wywołujemy metodę CellClick dla pierwszego wiersza
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                dataGridView_lista_wizyt_CellClick(this, args);
            }
            this.dataGridView_lista_wizyt.SelectionChanged += new System.EventHandler(this.dataGridView_lista_wizyt_SelectionChanged);
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
            int selcetedVisitStatus = Convert.ToInt32(dataGridView_lista_wizyt.SelectedRows[0].Cells["Status"].Value);


            DateTime selectedDate = (DateTime)dataGridView_lista_wizyt.SelectedRows[0].Cells["Date"].Value;
            TimeSpan selectedTime = (TimeSpan)dataGridView_lista_wizyt.SelectedRows[0].Cells["Hour"].Value;

            string fullName = dataGridView_lista_wizyt.SelectedRows[0].Cells["DoctorName"].Value.ToString();
            string[] nameParts = fullName.Split(' ');

            string firstName = nameParts[0];
            string lastName = nameParts[1];


            if (selcetedVisitStatus == 0)
            {
                MessageBox.Show("this visit is already cancel");
                return;

            }

            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "0" };
            string condition = $"ID = {selcetedcalendarId}";
            databaseConnection.UpdateDataInDatabase("MedicalVisit", columnNames, columnValues, condition);


            DatabaseConnection databaseConnection1 = new DatabaseConnection();

            databaseConnection1.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "view_listMedicalVisit");









            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=testowanie;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT Id FROM Employees WHERE FirstName = @FirstName AND LastName = @LastName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    int doctorId = -1;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            doctorId = reader.GetInt32(0);
                        }
                    }

                    DatabaseConnection databaseConnection3 = new DatabaseConnection();

                    string[] columnNames1 = { "Status" };
                    string[] columnValues1 = { "" };
                    string condition1 = $"Date = '{selectedDate.ToString("yyyy-MM-dd")}' AND Time = '{selectedTime.ToString(@"hh\:mm\:ss")}' AND doctorid ='{doctorId}'";

                    databaseConnection3.UpdateDataInDatabase("CalendarEntity", columnNames1, columnValues1, condition1);

                }
            }




        }
        private void UpdateTextBoxValues(DataGridViewRow selectedRow)
        {




        }
        private void button_Send_confirmation_Click(object sender, EventArgs e)
        {
            /*
            if (dataGridView_lista_wizyt.SelectedRows.Count > 0)
            {

            }
                MedicalVisit medicalVisit = new MedicalVisit();
                 medicalVisit.SendConfirmation();
            
            else
            {
                MessageBox.Show("Proszę wybrać wizytę do eksportu.");
            }
            */

            string office = dataGridView_lista_wizyt.SelectedRows[0].Cells["OfficeNumber"].Value.ToString();
            string date = dataGridView_lista_wizyt.SelectedRows[0].Cells["Date"].Value.ToString();
            string time = dataGridView_lista_wizyt.SelectedRows[0].Cells["Time"].Value.ToString();
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
            if (e.RowIndex >= 0)
            {
                //string visitId = dataGridView_lista_wizyt.Rows[e.RowIndex].Cells["ID"].Value.ToString();




            }

        }
        private void dataGridView_lista_wizyt_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_lista_wizyt.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_lista_wizyt.SelectedRows[0];
                UpdateTextBoxValues(selectedRow);
            }
        }

        private void btnSearchVisit_Click(object sender, EventArgs e)
        {
            string searchText = txtPesel.Text;
            string columnName = "PatientPesel";

            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.SearchDataInView(searchText, "VisitView", dataGridView_lista_wizyt, columnName);



        }
    }
}
