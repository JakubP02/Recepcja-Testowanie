using Microsoft.VisualBasic;
using SharedElements.Helpers;
using SharedElements.Models;
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

namespace Administracja.FormsCalendar
{
    public partial class FormCalendar : Form
    {
        FormMain parent;
        Calendar calendar;
        private bool edit;
        public FormCalendar(FormMain parent, Calendar calendar)
        {
            this.calendar = calendar;
            this.parent = parent;
            InitializeComponent();
        }
        public FormCalendar(FormMain parent, Calendar calendar, bool edit)
        {
            this.edit = edit;
            this.calendar = calendar;
            this.parent = parent;
            InitializeComponent();
        }

        private void FormCalendar_Load(object sender, EventArgs e)
        {
            displayDays();
            string month = DateAndTime.MonthName(calendar.Month);
            labelDate.Text = month + " " + calendar.Year.ToString();

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
            for (int i = 1; i <= days; i++)
            {
                UserControlDays dayControl = new UserControlDays(parent);
                DateOnly date = new DateOnly(calendar.Year,calendar.Month,i);

                if(CalendarEntityHelper.CheckDateAndEntity(date)!= true)
                {
                    dayControl.BackColor = Color.FromArgb(23, 35, 49); 
                    dayControl.ForeColor = Color.FromArgb(23, 35, 49);
                    dayControl.changeLabelColor(Color.White);
                }

                dayControl.Day = i;
                dayControl.Calendar = calendar;
                dayControl.IsEdit = edit;

                dayControl.AddDayNumber();
                daycontainer.Controls.Add(dayControl);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormCalendarList(parent));
        }
    }
}
