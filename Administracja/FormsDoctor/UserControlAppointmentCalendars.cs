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

namespace Administracja.FormsDoctor
{
    public partial class UserControlAppointmentCalendars : UserControl
    {
        int Day;
        Calendar calendar;
        public UserControlAppointmentCalendars(Calendar calendar)
        {
            this.calendar = calendar;
            InitializeComponent();
        }
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
            this.Day = Day;
            label1.Text = Day.ToString() + "";
        }
        public void changeLabelColor(Color color)
        {
            label1.ForeColor = color;
        }

        private void UserControlAppointmentCalendars_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tutaj na onclicku ma byc panelAppointmentCalendar.Hide(); panelAppointmentDetails.Show()\n\n" +
                "jak w danym dniu nie bedzie zaplanowanej pracy to wyswietlic jakis msg ze nie ma pracy\n\n" +
                "trzeba bedzie pobrac day ktory sie kliknelo i dla tego dnia otworzyc sie ma planowanie wizyt czyli panelAppointmentDetails.Show()");
        }
    }
}
