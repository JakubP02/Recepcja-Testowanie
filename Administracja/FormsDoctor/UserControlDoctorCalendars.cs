using Administracja.Forms;
using Administracja.FormsCalendar;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Administracja.FormsDoctor
{
    public partial class UserControlDoctorCalendars : UserControl
    {
        int Day;
        Calendar calendar;
        public UserControlDoctorCalendars(Calendar calendar)
        {
            this.calendar = calendar;
            InitializeComponent();
        }
        //private void openWindow()
        //{
        //    if (checkIfSunday() != true)
        //    {
        //        FormPopUpAdd info = new("Sunday is a non-working day");
        //        info.StartPosition = FormStartPosition.CenterScreen;
        //        info.ShowDialog();
        //        return;
        //    }
        //    if (IsEdit == true)
        //    {
        //        DateOnly date = new DateOnly(Calendar.Year, Calendar.Month, Day);
        //        parent.openChildForm(new FormCalendarSessionList(parent, Calendar, date));
        //    }
        //    else
        //    {
        //        parent.openChildForm(new FormAddCalendarEntity(parent, Calendar, Day));
        //    }
        //}
        private bool checkIfSunday()
        {
            DateTime date = new DateTime(calendar.Year, calendar.Month, Day);

            if (date.DayOfWeek == 0)
            {
                return false;
            }
            return true;
        }
        public void AddDayNumber(int Day)
        {
            this.Day= Day;
            label1.Text = Day.ToString() + "";
        }

        private void UserControlDoctorCalendars_Click(object sender, EventArgs e)
        {

        }
        public void changeLabelColor(Color color)
        {
            label1.ForeColor = color;
        }
    }
}
