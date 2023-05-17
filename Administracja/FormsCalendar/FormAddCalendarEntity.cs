using Administracja.Forms;
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

namespace Administracja.FormsCalendar
{
    public partial class FormAddCalendarEntity : Form
    {
        private FormMain parent;
        private CalendarEntity entity = null;
        private Calendar? calendar = null;
        private int? day;
        public FormAddCalendarEntity(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "HH:mm";
            dateTimePickerFrom.ShowUpDown = true;

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "HH:mm";
            dateTimePickerTo.ShowUpDown = true;

            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;
        }
        public FormAddCalendarEntity(FormMain parent, Calendar calendar, int day)
        {
            this.calendar = calendar;
            this.parent = parent;
            this.day = day;
            InitializeComponent();

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "HH:mm";
            dateTimePickerFrom.ShowUpDown = true;

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "HH:mm";
            dateTimePickerTo.ShowUpDown = true;

            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;

            DateTime year = new DateTime(calendar.Year, DateTime.Now.Month, DateTime.Now.Day);

            dateTimePickerYear.Value = year;

            for (int i = 1; i <= 12; i++)
            {
                string month = DateAndTime.MonthName(i);
                int index = comboBoxMonth.Items.Add(month);
                if (i == calendar.Month)
                {
                    comboBoxMonth.SelectedIndex = index;
                }
            }
            for (int i = 1; i <= DateTime.DaysInMonth(calendar.Year, calendar.Month); i++)
            {
                DateTime date = new DateTime(calendar.Year, calendar.Month, i);
                if (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    int index = comboBoxDay.Items.Add(i);
                    if (i == day)
                    {
                        comboBoxDay.SelectedIndex = index;
                    }
                }
            }

        }
        private bool CheckIfEmpty()
        {
            if (comboBoxMonth.SelectedItem == null)
            {
                return false;
            }
            if (comboBoxDay.SelectedItem == null)
            {
                return false;
            }
            if (comboBoxDoctor.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty() == false)
            {
                FormPopUpAdd info = new("All field must be filled");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            if (listBoxOffice.SelectedItem == null)
            {
                FormPopUpAdd info = new("You didn't choose office");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }

            //check If doctor is Assigned

            int year = dateTimePickerYear.Value.Year;
            int month = (comboBoxMonth.SelectedIndex) + 1;
            int day = (int)comboBoxDay.SelectedItem;

            int hourFrom = dateTimePickerFrom.Value.Hour;
            int minuteFrom = dateTimePickerFrom.Value.Minute;
            int hourTo = dateTimePickerTo.Value.Hour;
            int minuteTo = dateTimePickerTo.Value.Minute;

            DateOnly dateDoctor = new DateOnly(year, month, day);
            TimeOnly timeFrom = new TimeOnly(hourFrom, minuteFrom);
            TimeOnly timeTo = new TimeOnly(hourTo, minuteTo);

            CalendarEntityService calendarEntityS = new CalendarEntityService();
            EmployeeService employeeService = new();
            List<Employee> employees = employeeService.GetAllEmployees();
            foreach (Employee employee in employees)
            {
                if (calendarEntityS.CheckIfDoctorIsAsigned(dateDoctor, timeFrom, timeTo, employee) != true)
                {
                    FormPopUpAdd info = new("This Doctor is already assigned in this time");
                    info.StartPosition = FormStartPosition.CenterScreen;
                    info.ShowDialog();
                    return;
                }
            }


            int? value = null;
            int i = 0;
            int actualHour = 0;
            try
            {
                value = CalendarEntityHelper.CalculateNumberOfAppointments(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            }
            catch (Exception ex)
            {
                FormPopUpAdd error = new($"{ex.Message}");
                error.ShowDialog();
                return;
            }

            int hour = dateTimePickerFrom.Value.Hour;
            int minute = dateTimePickerFrom.Value.Minute;

            int startMinute = dateTimePickerFrom.Value.Minute;

            DateTime creationDate = DateTime.Now;

            while (i <= value)
            {
                DateOnly date = new DateOnly(year, month, day);
                TimeOnly time = new TimeOnly(hour, minute);
                if (i != 0)
                {

                    minute += 20;
                    if (minute > 59)
                    {
                        minute = minute - 60;
                        hour += 1;

                    }
                    if (hour == 20 && minute == 0)
                    {
                        break;
                    }
                    if (startMinute == minute)
                    {
                        actualHour++;
                        if (CalendarEntityHelper.CheckIfBreak(dateTimePickerFrom.Value, dateTimePickerTo.Value, actualHour) != false)
                        {
                            i++;
                            continue;
                        }
                    }

                    time = new TimeOnly(hour, minute);

                    if (time == timeTo)
                    {
                        break;
                    }

                }
                CalendarEntityService calendarEntityService = new();
                CalendarEntity entityToAdd = new(
                    entity is not null ? entity.Id : null,
                    date,
                    time,
                    (Employee)comboBoxDoctor.SelectedItem,
                    (Office)listBoxOffice.SelectedItem,
                    creationDate
                    );

                try
                {
                    if (entity is null)
                    {
                        calendarEntityService.AddCalendarEntity(entityToAdd, (int)calendar.Id);
                    }
                }
                catch (Exception ex)
                {
                    FormPopUpAdd error = new($"{ex.Message}");
                    error.StartPosition = FormStartPosition.CenterScreen;
                    error.ShowDialog();
                    return;
                }
                i++;
            }
            if (entity is null)
            {
                FormPopUpAdd ok = new("Working hours added!");
                ok.StartPosition = FormStartPosition.CenterScreen;
                ok.ShowDialog();

            }

        }

        private void FormAddCalendarEntity_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employees = employeeService.GetAllEmployees();
            foreach (Employee emp in employees)
            {
                if (emp.AssignedRole.Name == "Medical Doctor")
                {
                    comboBoxDoctor.Items.Add(emp);
                }
            }

            listBoxOffice.Items.Clear();


        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormCalendar(parent, calendar));
        }



        private void refreshOffice()
        {
            listBoxOffice.Items.Clear();
            listBoxOffice.Enabled = true;

            int year = dateTimePickerYear.Value.Year;
            int month = (comboBoxMonth.SelectedIndex) + 1;
            int day = (int)comboBoxDay.SelectedItem;

            int hourFrom = dateTimePickerFrom.Value.Hour;
            int minuteFrom = dateTimePickerFrom.Value.Minute;
            int hourTo = dateTimePickerTo.Value.Hour;
            int minuteTo = dateTimePickerTo.Value.Minute;

            DateOnly date = new DateOnly(year, month, day);
            TimeOnly timeFrom = new TimeOnly(hourFrom, minuteFrom);
            TimeOnly timeTo = new TimeOnly(hourTo, minuteTo);

            OfficeService officeService = new();
            List<Office> offices = officeService.GetOfficeList();

            foreach (Office office in offices)
            {
                if (officeService.GetFreeOffices(date, timeFrom, timeTo, office) == true)
                {
                    listBoxOffice.Items.Add(office);
                }
            }
        }
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            refreshOffice();
        }
        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshOffice();
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            refreshOffice();
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshOffice();
        }
    }
}
