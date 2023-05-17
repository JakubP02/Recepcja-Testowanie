using Microsoft.VisualBasic.ApplicationServices;
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

namespace Administracja.Forms
{
    public partial class FormEmployee : Form
    {
        private Employee? employee = null;
        private FormMain parent;
        public FormEmployee(FormMain parent, Employee employee)
        {
            this.parent = parent;
            this.employee = employee;
            InitializeComponent();
            textBoxName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxPESEL.Text = employee.PESEL;
            dateTimePickerBirth.Value = employee.DateOfBirth;
            if (employee.CorrespondenceAddress != null)
            {
                textBoxMailingAddress.Text = employee.CorrespondenceAddress;
            }
            if (employee.EmailAddress != null)
            {
                textBoxEmail.Text = employee.EmailAddress;
            }
            if (employee.CorrespondenceAddress != null)
            {
                textBoxMailingAddress.Text = employee.CorrespondenceAddress;
            }
            if (employee.PhoneNumber != null)
            {
                textBoxPhone.Text = employee.PhoneNumber;
            }
            if (employee.ListOfSpecialization != null)
            {
                foreach (Specialization spec in employee.ListOfSpecialization)
                {
                    listBoxSpecialites.Items.Add(spec);
                }
            }
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            List<Employee> employees;
            RoleService roleService = new();
            foreach (Role role in roleService.GetAllRoles())
            {
                int index = comboBoxRole.Items.Add(role);
                if (employee?.AssignedRole != null && employee.AssignedRole.Id == role.Id)
                {
                    comboBoxRole.SelectedIndex = index;
                }
            }
            /*
                        listBoxSpecialites.Items.Clear();*/
            /*            if (employee != null)
                        {
                            EmployeeService employeeService = new EmployeeService();
                            employees = employeeService.GetAllEmployees();
                            foreach (Employee emp in employees)
                            {
                                if (emp.Id == employee.Id)
                                {
                                    foreach (Specialization specialization in emp.ListOfSpecialization)
                                    {

                                        listBoxSpecialites.Items.Add(specialization);

                                    }
                                }
                            }
                        }
                        else
                        {
                            SpecializationService specializationService = new SpecializationService();
                            foreach (Specialization specialization in specializationService.GetAllSpecializations())
                            {

                                int index = listBoxSpecialites.Items.Add(specialization);
                                if (employee?.ListOfSpecialization != null && employee.ListOfSpecialization. == specialization)
                                {
                                    comboBoxRole.SelectedIndex = index;
                                }
                            }
                        }*/

            comboBoxSex.Items.Add("Male");
            comboBoxSex.Items.Add("Female");
            if (employee?.Sex == null)
            {
                return;
            }

            switch (employee.Sex)
            {
                case 'M':
                    comboBoxSex.SelectedIndex = 0; break;
                case 'F':
                    comboBoxSex.SelectedIndex = 1; break;
            }

        }

        private void buttonBackInfo_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormEmployeeList(parent));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormAddEmployee(parent, employee));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBirth.Value = employee.DateOfBirth;
        }
    }
}
