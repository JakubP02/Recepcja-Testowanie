using Administracja.Forms;
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
    public partial class UserControlDays : UserControl
    {
        FormMain parent;
        public Calendar? Calendar { get; set; }
        public int Day { get; set; }
        public bool IsEdit { get; set; }
        public UserControlDays(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
        }
        public void AddDayNumber()
        {
/*          this.edit = edit;
            this.calendar = calendar;
            this.day = numdays;*/
            labelDay.Text = Day.ToString() + "";
        }

        private void labelDay_Click(object sender, EventArgs e)
        {
            openWindow();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            openWindow();
        }
        private void openWindow()
        {
            if (checkIfSunday() != true)
            {
                FormPopUpAdd info = new("Sunday is a non-working day");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            if (IsEdit == true)
            {
                DateOnly date = new DateOnly(Calendar.Year, Calendar.Month, Day);
                parent.openChildForm(new FormCalendarSessionList(parent, Calendar, date));
            }
            else
            {
                parent.openChildForm(new FormAddCalendarEntity(parent, Calendar, Day));
            }
        }
        private bool checkIfSunday()
        {
            DateTime date = new DateTime(Calendar.Year, Calendar.Month, Day);

            if (date.DayOfWeek == 0)
            {
                return false;
            }
            return true;
        }
        public void changeLabelColor(Color color)
        {
            labelDay.ForeColor = color;
        }
    }
}
