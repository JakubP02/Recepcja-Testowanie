using Administracja.Forms;
using Administracja.FormsCalendar;
using Microsoft.VisualBasic;
using SharedElements.Helpers;
using SharedElements.Models;
using SharedElements.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Administracja.FormsDoctor
{
    public partial class FormDoctorAppointments : Form
    {
        Calendar calendar;
        private List<Calendar> calendars;
        FormMain parent;
        public FormDoctorAppointments(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void displayDays()
        {
            DateTime startOfMonth = new DateTime(calendar.Year, calendar.Month, 1);

            int days = DateTime.DaysInMonth(calendar.Year, calendar.Month);

            int daysOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfWeek; i++)
            {
                UserControlBlank userControl = new UserControlBlank();
                daycontainer.Controls.Add(userControl);
            }
            //sprawdzic grafik tylko dla wybranego doktora - wybor pracownika albo przez logowanie
            for (int i = 1; i <= days; i++)
            {
                UserControlAppointmentCalendars dayControl = new UserControlAppointmentCalendars(calendar);
                DateOnly date = new DateOnly(calendar.Year, calendar.Month, i);

                if (CalendarEntityHelper.CheckDateAndEntity(date) != true)
                {
                    dayControl.BackColor = Color.DarkSlateBlue;
                    dayControl.ForeColor = Color.DarkSlateBlue;
                    dayControl.changeLabelColor(Color.White);
                }
                dayControl.AddDayNumber(i);
                daycontainer.Controls.Add(dayControl);
            }
        }
        private void SetColumnWidths(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[0].FillWeight = 100;
        }
        private void FormDoctorsAppointments_Load(object sender, EventArgs e)
        {

        }

        private void FormDoctorAppointments_Load(object sender, EventArgs e)
        {
            SetColumnWidths(dataGridViewDoctorCalendars);
            SetColumnWidths(dataGridViewDoctorAppointments);
            labelTime.Text = DateTime.Now.ToString("HH:mm");
            CalendarService calendarService = new CalendarService();
            calendars = calendarService.GetAllCalendars();
            foreach (Calendar calendar in calendars)
            {
                if(calendar.Status == "Inactive") { continue; }
                
                {
                    int index = dataGridViewDoctorCalendars.Rows.Add(calendar.Name);
                    dataGridViewDoctorCalendars.Rows[index].Tag = calendar;
                }

            }
            panelPatient.Hide();
        }

        private void btnViewCalendar_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (dataGridViewDoctorCalendars.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Calendar!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                calendar = (Calendar)dataGridViewDoctorCalendars.SelectedRows[0].Tag;
            }
            displayDays();
            string month = DateAndTime.MonthName(calendar.Month);
            labelDate.Text = month + " " + calendar.Year.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelPatient.Hide();
        }

        private void dataGridViewDoctorAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelPatient.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            panelAppointmentDetails.Hide();
            panelAppointmentCalendar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelAppointmentCalendar.Hide();
            panelAppointmentDetails.Show();
        }
    }
}
