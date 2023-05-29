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

namespace Recepcja
{
    public partial class EditVisit : Form
    {
        public EditVisit()
        {
            InitializeComponent();
        }




        private void RefreshDataGridView()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string day = UserControlEditVisit.static_day;
            string month = CalendarEditVisit.static_month;
            string year = CalendarEditVisit.static_year;

            string dayFormatted = day.PadLeft(2, '0');
            string monthFormatted = month.PadLeft(2, '0');

            string dateString = year + "-" + monthFormatted + "-" + dayFormatted;
            int doctorId;

            doctorId = EditAppointment.Doctorid;
            

            DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);





            databaseConnection.LoadDataIntoDataGridViewCalendar(dataGridViewEditVisit, "CalendarView", date, doctorId);

   
        }

        private void EditVisit_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            

            int selcetedcalendarId = EditAppointment.AppoitmentId;
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.UpdateCalendarEntity(selcetedcalendarId);

            if (dataGridViewEditVisit.SelectedRows.Count < 1)
            {
                MessageBox.Show("please select an appointment");
                return;
            }
            DateTime currentDate = DateTime.Today;
            DateTime cellDate = (DateTime)dataGridViewEditVisit.SelectedRows[0].Cells["Date"].Value;

            string wheterFree = dataGridViewEditVisit.SelectedRows[0].Cells["PatientName"].Value.ToString();


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
            string idVisit = dataGridViewEditVisit.SelectedRows[0].Cells["id"].Value.ToString();




            pesel = EditAppointment.Pesel;


            id = databaseConnection.GetPatientIdByPesel(pesel);

            string[] columnName = { "PatientId" };
            string[] columnValue = { id.ToString() };
            string condition = $"ID = {idVisit}";

            databaseConnection.UpdateDataInDatabase("CalendarEntity", columnName, columnValue, condition);

            RefreshDataGridView();







        }
    }
}
