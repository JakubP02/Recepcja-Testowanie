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
using SharedElements.Models;
using SharedElements.Services;
using Administracja.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;


namespace Administracja.FormsCalendar
{
    public partial class FormCalendarList : Form
    {
        private FormMain parent;
        private Calendar? calendar = null;
        private List<Calendar> calendars;
        public FormCalendarList(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();


        }

        private void FormCalendarList_Load(object sender, EventArgs e)
        {

            dataGridViewCalendars.Rows.Clear();
            comboBoxStatus.Items.Clear();

            comboBoxStatus.Items.Add("Active");
            comboBoxStatus.Items.Add("Inactive");

            CalendarService calendarService = new CalendarService();
            calendars = calendarService.GetAllCalendars();
            foreach (Calendar calendar in calendars)
            {
                int index = dataGridViewCalendars.Rows.Add(calendar.Id, calendar.Name, calendar.Status);
                dataGridViewCalendars.Rows[index].Tag = calendar;
            }
        }

        private void buttonAddEntity_Click(object sender, EventArgs e)
        {
            Calendar calendar;
            if (dataGridViewCalendars.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Calendar!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                calendar = (Calendar)dataGridViewCalendars.SelectedRows[0].Tag;
            }

            /*parent.openChildForm(new FormAddCalendarEntity(parent, calendar));*/
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            /*            if (textBoxCalendarName.Text == string.Empty)
                        {
                            FormPopUpAdd info = new("Calendar name is empty");
                            info.StartPosition = FormStartPosition.CenterScreen;
                            info.ShowDialog();
                            return;
                        }
                        if (comboBoxMonth.SelectedItem == null)
                        {
                            FormPopUpAdd info = new("You need to pick a month");
                            info.StartPosition = FormStartPosition.CenterScreen;
                            info.ShowDialog();
                            return;
                        }*/
            /*CalendarService calendarService = new();
            Calendar calendarToAdd = new(
                calendar is not null ? calendar.Id : null,
                textBoxCalendarName.Text,
                null,
                "Inactive",
                dateTimePickerYear.Value.Year,
                (comboBoxMonth.SelectedIndex + 1)
                );

            try
            {
                calendarService.GenerateCalendar(calendarToAdd);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
            FormPopUpAdd ok;
            ok = new("Calendar added!");

            ok.StartPosition = FormStartPosition.CenterScreen;
            ok.ShowDialog();

            FormCalendarList_Load(this, EventArgs.Empty);*/
            parent.openChildForm(new FormCreateCalendar(parent));

        }

        private void buttonShowContent_Click(object sender, EventArgs e)
        {

            if (dataGridViewCalendars.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Calendar!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                calendar = (Calendar)dataGridViewCalendars.SelectedRows[0].Tag;
            }

            /*parent.openChildForm(new FormCalendarDates(parent, calendar));*/
            parent.openChildForm(new FormCalendar(parent, calendar, true));
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewCalendars.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Calendar!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                calendar = (Calendar)dataGridViewCalendars.SelectedRows[0].Tag;
            }
            FormConfimation ok = new("Are you sure you want to delete calendar?");
            ok.StartPosition = FormStartPosition.CenterScreen;
            if (ok.ShowDialog() == DialogResult.Yes)
            {
                CalendarService calendarService = new();
                calendarService.DeleteCalendar(calendar);
            }
            else
            {
                return;
            }
            FormCalendarList_Load(this, EventArgs.Empty);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string? status = null;
            string? name = null;

            if (comboBoxStatus.SelectedItem is not null)
            {
                status = comboBoxStatus.SelectedItem.ToString();
            }

            if (textBoxFilterName.Text != string.Empty)
            {
                name = textBoxFilterName.Text;
            }

            dataGridViewCalendars.Rows.Clear();

            IEnumerable<Calendar> query;
            if (status is not null && name is not null)
            {
                query = from i in calendars
                        where i.Status == status && i.Name == name
                        select i;
            }
            else if (status is null && name is not null)
            {
                query = from i in calendars
                        where i.Name == name
                        select i;
            }
            else
            {
                query = from i in calendars
                        where i.Status == status
                        select i;
            }

            List<Calendar> data = query.ToList();
            foreach (Calendar c in data)
            {
                int index = dataGridViewCalendars.Rows.Add(c.Id, c.Name, c.Status);
                dataGridViewCalendars.Rows[index].Tag = c;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewCalendars.Rows.Clear();
            foreach (Calendar calendar in calendars)
            {
                int index = dataGridViewCalendars.Rows.Add(calendar.Id, calendar.Name, calendar.Status);
                dataGridViewCalendars.Rows[index].Tag = calendar;
            }

            textBoxFilterName.Text = string.Empty;
            comboBoxStatus.SelectedItem = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewCalendars.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Calendar!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                calendar = (Calendar)dataGridViewCalendars.SelectedRows[0].Tag;
            }

            /*parent.openChildForm(new FormCalendarDates(parent, calendar));*/
            parent.openChildForm(new FormCalendar(parent, calendar, false));
        }

        private void buttonGenCalendar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCalendars.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Calendar!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                calendar = (Calendar)dataGridViewCalendars.SelectedRows[0].Tag;
            }
            parent.openChildForm(new FormCreateCalendar(parent, calendar));

        }

        private void buttonShowContent_Click_1(object sender, EventArgs e)
        {

        }
    }
}
