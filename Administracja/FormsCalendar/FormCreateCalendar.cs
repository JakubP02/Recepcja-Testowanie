using Administracja.Forms;
using SharedElements.Services;
using SharedElements.Models;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;

namespace Administracja.FormsCalendar
{
    public partial class FormCreateCalendar : Form
    {
        private Calendar calendar;
        FormMain parent;
        public FormCreateCalendar(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();

            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;
        }

        public FormCreateCalendar(FormMain parent, Calendar calendar)
        {
            this.parent = parent;
            this.calendar = calendar;
            InitializeComponent();

            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (textBoxCalendarName.Text == string.Empty)
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
            }

            if (calendar is null)
            {
                createCalendar();
            }
            else
            {
                generateCalendar();
            }

        }

        private void FormCreateCalendar_Load(object sender, EventArgs e)
        {
            comboBoxMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                string monthName = DateAndTime.MonthName(i);
                comboBoxMonth.Items.Add(monthName);
            }
        }
        private void createCalendar()
        {
            CalendarService calendarService = new();
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
                FormPopUpAdd error = new($"{ex.Message}");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }

            FormPopUpAdd ok;
            ok = new("Calendar added!");

            ok.StartPosition = FormStartPosition.CenterScreen;
            ok.ShowDialog();
        }
        private void generateCalendar()
        {
            CalendarEntityService calendarEntityService = new CalendarEntityService();

            List<CalendarEntity> calendarEntities = calendarEntityService.GetAllCalendarEntities(calendar.Id, null);

            CalendarService calendarService = new CalendarService();

            Calendar calendarToAdd = new(
                calendar is not null ? calendar.Id : null,
                textBoxCalendarName.Text,
                null,
                "Inactive",
                dateTimePickerYear.Value.Year,
                (comboBoxMonth.SelectedIndex + 1)
                );

            DateTime startOfMonth = new DateTime(calendarToAdd.Year, calendarToAdd.Month, 1);
            int daysOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            int days = DateTime.DaysInMonth(calendarToAdd.Year, calendarToAdd.Month);

            CalendarEntity? calendarEntityToAdd = null;

            int id = calendarService.GenerateCalendarAndReturnId(calendarToAdd);

            int z = 0;
            foreach (CalendarEntity cal in calendarEntities)
            {
                if (cal.Date.Day > days)
                {
                    break;
                }
                DateTime datee = new DateTime(dateTimePickerYear.Value.Year, (comboBoxMonth.SelectedIndex + 1), cal.Date.Day);

                DateTime calDate = new DateTime(cal.Date.Year, cal.Date.Month, cal.Date.Day);

                int dayDiff;

                if (cal.Date.Day.ToString("dddd") == "Sunday")
                {
                    continue;
                }

                if (cal.Date.DayOfWeek > datee.DayOfWeek)
                {
                    if (datee.DayOfWeek == 0)
                    {
                        z = 7;
                    }
                    else
                    {
                        z = (int)datee.DayOfWeek;
                    }
                    dayDiff = (int)calDate.DayOfWeek - z;
                    for (int i = 1; i <= 7; i++)
                    {
                        if (dayDiff > 3)
                        {
                            datee = datee.AddDays(1);
                        }
                        else
                        {
                            datee = datee.AddDays(-1);
                        }
                        if (cal.Date.DayOfWeek == datee.DayOfWeek)
                        {
                            break;
                        }

                    }
                }
                if (cal.Date.DayOfWeek < datee.DayOfWeek)
                {
                    if (datee.DayOfWeek == 0)
                    {
                        z = 7;
                    }
                    else
                    {
                        z = (int)datee.DayOfWeek;
                    }
                    dayDiff = (int)datee.DayOfWeek - z;
                    for (int i = 1; i <= 7; i++)
                    {
                        if (dayDiff > 3)
                        {
                            datee = datee.AddDays(1);
                        }
                        else
                        {
                            datee = datee.AddDays(-1);
                        }
                        if (cal.Date.DayOfWeek == datee.DayOfWeek)
                        {
                            break;
                        }

                    }
                }

                DateOnly dateToAdd = DateOnly.FromDateTime(datee);
                if (dateToAdd.Month != calDate.Month)
                {
                    break;
                }

                calendarEntityToAdd = new(cal.Id, dateToAdd, cal.Time, cal.Employee, cal.Office, cal.CreationDate);
                try
                {
                    calendarEntityService.AddCalendarEntity(calendarEntityToAdd, id);
                }
                catch (Exception ex)
                {
                    FormPopUpAdd error = new($"{ex.Message}");
                    error.StartPosition = FormStartPosition.CenterScreen;
                    error.ShowDialog();

                    calendarToAdd = new(
                    id,
                    textBoxCalendarName.Text,
                    null,
                    "Inactive",
                    dateTimePickerYear.Value.Year,
                    (comboBoxMonth.SelectedIndex + 1)
                    );

                    calendarService.DeleteCalendar(calendarToAdd);
                    return;
                }

                FormPopUpAdd ok;
                ok = new("Calendar added!");

                ok.StartPosition = FormStartPosition.CenterScreen;
                ok.ShowDialog();


            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormCalendarList(parent));
        }
    }
}
