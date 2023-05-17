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
    public partial class FormDoctorCalendars : Form
    {
        Calendar calendar;
        private List<Calendar> calendars;
        FormMain parent;
        public FormDoctorCalendars(FormMain parent)
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
                UserControlDoctorCalendars dayControl = new UserControlDoctorCalendars(calendar);
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
            dataGridView.Columns[0].FillWeight = 50;

            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].FillWeight = 50;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDoctorCalendars_Load(object sender, EventArgs e)
        {

        }

        private void FormDoctorCalendars_Load_1(object sender, EventArgs e)
        {
            SetColumnWidths(dataGridViewDoctorCalendars);
            CalendarService calendarService = new CalendarService();
            calendars = calendarService.GetAllCalendars();

            dataGridViewDoctorCalendars.Rows.Clear();

            foreach (Calendar calendar in calendars)
            {
                int index = dataGridViewDoctorCalendars.Rows.Add(calendar.Name, calendar.Status);
                dataGridViewDoctorCalendars.Rows[index].Tag = calendar;
            }
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

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
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
                CalendarService calendarService = new();
                calendarService.UpdateStatus((int)calendar.Id, "Active");
            }

            FormDoctorCalendars_Load_1(sender, e);
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
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
                CalendarService calendarService = new();
                calendarService.UpdateStatus((int)calendar.Id, "Inactive");
            }

            FormDoctorCalendars_Load_1(sender, e);
        }
    }
}
