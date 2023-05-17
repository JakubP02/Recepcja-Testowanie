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
    public partial class FormCalendarEntityUpdate : Form
    {
        FormMain parent;
        CalendarEntity entity;
        Calendar calendar;
        DateOnly date;
        public FormCalendarEntityUpdate(FormMain parent, CalendarEntity entity, Calendar calendar, DateOnly date)
        {
            this.parent = parent;
            this.entity = entity;
            this.calendar = calendar;
            this.date = date;
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
                if (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    int index = comboBoxDay.Items.Add(i);
                    if (i == date.Day)
                    {
                        comboBoxDay.SelectedIndex = index;
                    }
                }
            }
        }

        private void FormCalendarEntityUpdate_Load(object sender, EventArgs e)
        {

            EmployeeService employeeService = new();

            foreach (Employee emp in employeeService.GetAllEmployees())
            {
                int index = comboBoxDoctor.Items.Add(emp);
                if (entity.Employee.Id == emp.Id)
                {
                    comboBoxDoctor.SelectedIndex = index;
                }
            }
            CalendarEntityService calendarEntityService = new();
            foreach (CalendarEntity en in calendarEntityService.GetAllCalendarEntities(null, null))
            {
                if (entity?.Time == en.Time)
                {
                    DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, en.Time.Hour, en.Time.Minute, 0);
                    dateTimePickerFrom.Value = dateTime;
                    dateTimePickerTo.Value = dateTime.AddMinutes(20);
                }
            }

            listBoxOffice.Items.Clear();

            OfficeService officeService = new();

            foreach (Office office in officeService.GetOfficeList())
            {
                int index = listBoxOffice.Items.Add(office);
                if (entity?.Date != null && entity.Office.Id == office.Id)
                {
                    listBoxOffice.SelectedIndex = index;
                }
            }

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
                if (calendarEntityS.CheckIfDoctorIsAsignedUpdate(dateDoctor, timeFrom, timeTo, employee) != true)
                {
                    FormPopUpAdd info = new("Some Doctor is already assigned in this time");
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

            CalendarEntityService calendarEntityService = new();
            if (entity is not null)
            {
                calendarEntityService.DeleteAllEntity(entity);
            }

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
                    if (entity is not null)
                    {
                        calendarEntityService.UpdateCalendarEntity(entityToAdd, (int)calendar.Id);
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
            if (entity is not null)
            {
                FormPopUpAdd ok = new("Working hours edited!");
                ok.StartPosition = FormStartPosition.CenterScreen;
                ok.ShowDialog();
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
        private void refreshOffice()
        {
            listBoxOffice.Items.Clear();

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
                if (office.Id == entity.Office.Id)
                {
                    if(officeService.CheckIfOfficeIsStillAvailable(date, timeFrom, timeTo, office, entity) == true)
                    {
                        listBoxOffice.Items.Add(office);
                    }
                }
                if (officeService.GetFreeOffices(date, timeFrom, timeTo, office) == true)
                {
                    listBoxOffice.Items.Add(office);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormCalendarSessionList(parent, calendar, date));
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            refreshOffice();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
