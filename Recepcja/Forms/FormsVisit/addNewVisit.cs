using Microsoft.VisualBasic;
using Recepcja.Forms;
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

namespace Recepcja
{
    public partial class addNewVisit : Form
    {


        private void RefreshDataGridView()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string day = UserControlday.static_day;
            string month = CalenderAddNewVisit.static_month;
            string year = CalenderAddNewVisit.static_year;

            string dayFormatted = day.PadLeft(2, '0');
            string monthFormatted = month.PadLeft(2, '0');

            string dateString = year + "-" + monthFormatted + "-" + dayFormatted;
            int doctorId;


            DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);


            addDoctorprompt form = new addDoctorprompt();
            doctorId = form.DoctorId;
    

            databaseConnection.LoadDataIntoDataGridViewCalendar(dataGridView_patients, "CalendarView", date,doctorId);
        }

        public addNewVisit()
        {
            InitializeComponent();


  
  

        }

        private void button_add_visit_Click(object sender, EventArgs e)
        {
            if (dataGridView_patients.SelectedRows.Count < 1)
            {
                MessageBox.Show("please select an appointment");
                return;
            }
            DateTime currentDate = DateTime.Today;
            DateTime cellDate = (DateTime)dataGridView_patients.SelectedRows[0].Cells["Date"].Value ;

            string wheterFree = dataGridView_patients.SelectedRows[0].Cells["PatientName"].Value.ToString();
           

            if (wheterFree != " ")
            {
                MessageBox.Show("this date is busy");
                return;
            }
            if (cellDate < currentDate)
                       {
                           MessageBox.Show("you can't add a visit in the past");
                           return;

                       }

                       
            string pesel;
            int id;
            string idVisit = dataGridView_patients.SelectedRows[0].Cells["id"].Value.ToString();



            FormSelectPatientToVisit form = new FormSelectPatientToVisit();
            pesel = form.Pesel;

            DatabaseConnection databaseConnection = new DatabaseConnection();
            id = databaseConnection.GetPatientIdByPesel(pesel);

            string[] columnName = { "PatientId" };
            string[] columnValue = { id.ToString() };
            string condition = $"ID = {idVisit}";

            databaseConnection.UpdateDataInDatabase("CalendarEntity", columnName, columnValue, condition);

            RefreshDataGridView();
        
       
        }

        private void addNewVisit_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}