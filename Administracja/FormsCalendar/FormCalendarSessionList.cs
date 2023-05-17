using Administracja.Forms;
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

namespace Administracja.FormsCalendar
{
    public partial class FormCalendarSessionList : Form
    {
        private FormMain parent;
        private Calendar? calendar = null;
        private DateOnly date;
        public FormCalendarSessionList(FormMain parent, Calendar calendar, DateOnly date)
        {
            this.parent = parent;
            this.calendar = calendar;
            this.date = date;
            InitializeComponent();
        }

        private void FormCalendarSessionList_Load(object sender, EventArgs e)
        {
            CalendarEntityService calendarEntityService = new();
            List<CalendarEntity> calendarEntities = calendarEntityService.GetAllCalendarEntities(calendar.Id, date);

            foreach (CalendarEntity calendarEntity in calendarEntities)
            {
                int index = dataGridViewSessions.Rows.Add(calendarEntity.Id, calendarEntity.Employee, calendarEntity.Office.Number, calendarEntity.Time.ToString("HH:mm"), (calendarEntity.Time.AddMinutes(20)));
                dataGridViewSessions.Rows[index].Tag = calendarEntity;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormCalendar(parent, calendar, true));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CalendarEntity entity;
            if (dataGridViewSessions.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Entity!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                entity = (CalendarEntity)dataGridViewSessions.SelectedRows[0].Tag;
            }

            parent.openChildForm(new FormCalendarEntityUpdate(parent, entity, calendar, date));
        }
    }
}
