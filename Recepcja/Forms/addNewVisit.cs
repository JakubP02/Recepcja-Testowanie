using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Patient_handling
{
    public partial class addNewVisit : Form
    {
        private Dictionary<int, string> _patientIdsAndNames;
        private Dictionary<int, string> _doctorIdsAndNames;

        public addNewVisit()
        {
            InitializeComponent();


            //comboBox_hour_add.Items.AddRange(listaStringow.ToArray());

            DatabaseConnection databaseConnection = new DatabaseConnection();

            (_patientIdsAndNames, _doctorIdsAndNames) = databaseConnection.LoadPatientsAndDoctorsToComboBoxes(comboBox_patinet_add);

            string day = UserControlday.static_day;
            string month = CalenderAddNewVisit.static_month;
            string year = CalenderAddNewVisit.static_year;

            string dayFormatted = day.PadLeft(2, '0');
            string monthFormatted = month.PadLeft(2, '0');

            string dateString = year + "-" + monthFormatted + "-" + dayFormatted;


            DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);



            databaseConnection.LoadDataIntoDataGridViewCalendar(dataGridView_patients, "view_CalendarEntity", date);
        }

        private void button_add_visit_Click(object sender, EventArgs e)
        {
            /*DatabaseConnection conn = new DatabaseConnection();

            int patientId = _patientIdsAndNames.FirstOrDefault(x => x.Value == comboBox_patinet_add.SelectedItem.ToString()).Key;
            int doctorId = _doctorIdsAndNames.FirstOrDefault(x => x.Value == comboBox_doctor_add.SelectedItem.ToString()).Key;


            string[] columnNames = { "Patient", "Doctor", "Date", "Hour" };
            string visitDate = dateTimePicker_add_visit.Value.ToString("yyyy-MM-dd");
            string visitTime = comboBox_hour_add.SelectedItem.ToString();
            string[] columnValues = { patientId.ToString(), doctorId.ToString(), visitDate, visitTime };


            conn.InsertDataToDatabase("MedicalVisit", columnNames, columnValues);


            conn.LoadDataIntoDataGridView(dataGridView_patients, "MedicalVisit");
            */



            string statusvisit = dataGridView_patients.SelectedRows[0].Cells["Status"].Value.ToString();
            DateTime dateTime = DateTime.Now;
            DateTime datetimevisit = (DateTime)dataGridView_patients.SelectedRows[0].Cells["Date"].Value;


            if (comboBox_patinet_add.SelectedIndex < 0)
            {
                MessageBox.Show("please select a patient");
            }

            if (datetimevisit < dateTime)
            {
                MessageBox.Show("you can't add a visit with a date from the past");
                return;
            }
           
            if (statusvisit == "busy term")
            {
                MessageBox.Show("this date is already taken");
                return;
            }
            if (comboBox_patinet_add.SelectedIndex < 0)
            {
                MessageBox.Show("please select a patient");
                return;
            }


            string namedoctor = dataGridView_patients.SelectedRows[0].Cells["DoctorName"].Value.ToString();
            string namepatient = comboBox_patinet_add.SelectedItem.ToString();

            DatabaseConnection database = new DatabaseConnection();
            MedicalVisit medical = new MedicalVisit
            {
                Doctorid1 = database.GetDoctorId(namedoctor),
                Patientid = database.GetPatientId(namepatient),
                Date1 = (DateTime)dataGridView_patients.SelectedRows[0].Cells["Date"].Value,
                Time = TimeSpan.Parse(dataGridView_patients.SelectedRows[0].Cells["Time"].Value.ToString())

            };
            string[] columnnames = { "Patientid", "DoctorId", "Date", "Hour" };
            string[] columnvalues = { medical.Patientid.ToString(), medical.Doctorid1.ToString(), medical.Date1.ToString("yyyy-MM-dd"), medical.Time.ToString(@"hh\:mm\:ss") };
            database.InsertDataToDatabase("MedicalVisit", columnnames, columnvalues);



            int selcetedcalendarId = Convert.ToInt32(dataGridView_patients.SelectedRows[0].Cells["ID"].Value);
            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "busy term" };
            string condition = $"ID = {selcetedcalendarId}";
            databaseConnection.UpdateDataInDatabase("CalendarEntity", columnNames, columnValues, condition);

            //databaseConnection.LoadDataIntoDataGridView(dataGridView_patients, "view_CalendarEntity");
            this.Hide();


        }

        private void addNewVisit_Load(object sender, EventArgs e)
        {

        }
    }
}