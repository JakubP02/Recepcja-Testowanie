using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedElements.Interfaces;
using SharedElements.Models;
using SharedElements.Services;
using WinFormsApp1;

namespace Administracja.Forms
{
    public partial class FormEmployeeList : Form
    {
        private FormMain parent;
        private List<Employee> employees;

        public FormEmployeeList(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            employees = employeeService.GetAllEmployees();
            dataGridViewEmployees.Rows.Clear();
            foreach (Employee employee in employees)
            {
                int index = dataGridViewEmployees.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.IsActive ? "Active" : "Inactive", employee.AssignedRole.Name);
                dataGridViewEmployees.Rows[index].Tag = employee;
            }

            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("Active");
            comboBoxStatus.Items.Add("Inactive");

            comboBoxRole.Items.Clear();
            RoleService roleService = new();
            List<Role> roles = roleService.GetAllRoles();
            foreach (Role role in roles)
            {
                comboBoxRole.Items.Add(role);
            }
            if (dataGridViewEmployees.Rows.Count < 1)
            {
                FormPopUpAdd info = new("There's no employees in database.");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormAddEmployee(parent));
        }

        private void buttonReviewTheEmployee_Click(object sender, EventArgs e)
        {
            Employee employee;
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick employee!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                employee = (Employee)dataGridViewEmployees.SelectedRows[0].Tag;
            }
            parent.openChildForm(new FormEmployee(parent, employee));
        }

        private void buttonDeactivateEmployee_Click(object sender, EventArgs e)
        {
            Employee employee;
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick employee!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            else
            {
                employee = (Employee)dataGridViewEmployees.SelectedRows[0].Tag;
            }

            EmployeeService employeeService = new();
            UsersService usersService = new();
            try
            {
                if (employee.IsActive == true)
                {
                    FormConfimation dialog = new("You will deactivate user too. Are you sure you want to continue?");
                    dialog.StartPosition = FormStartPosition.CenterScreen;
                    if (dialog.ShowDialog() == DialogResult.Yes)
                    {
                        usersService.DeactivateUser(employee);
                        employeeService.ChangeIsActiveStatus((int)employee.Id, !employee.IsActive);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    employeeService.ChangeIsActiveStatus((int)employee.Id, !employee.IsActive);
                }


            }
            catch (Exception exception)
            {
                FormPopUpAdd info = new("Something went wrong.");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
            }
            FormEmployeeList_Load(this, EventArgs.Empty);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            bool? active = null;
            string? roleName = null;
            if (comboBoxStatus.SelectedItem is null & comboBoxRole.SelectedItem is null)
            {
                return;
            }

            if (comboBoxStatus.SelectedItem is not null)
            {
                active = (string)comboBoxStatus.SelectedItem == "Active" ? true : false;
            }

            if (comboBoxRole.SelectedItem is not null)
            {
                roleName = (comboBoxRole.SelectedItem as Role).Name;
            }

            dataGridViewEmployees.Rows.Clear();

            IEnumerable<Employee> query;
            if (active is not null && roleName is not null)
            {
                query = from i in employees
                        where i.IsActive == active && i.AssignedRole.Name == roleName
                        select i;
            }
            else if (active is null && roleName is not null)
            {
                query = from i in employees
                        where i.AssignedRole.Name == roleName
                        select i;
            }
            else
            {
                query = from i in employees
                        where i.IsActive == active
                        select i;
            }

            List<Employee> data = query.ToList();
            foreach (Employee employee in data)
            {
                int index = dataGridViewEmployees.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.IsActive ? "Active" : "Inactive", employee.AssignedRole.Name);
                dataGridViewEmployees.Rows[index].Tag = employee;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewEmployees.Rows.Clear();
            foreach (Employee employee in employees)
            {
                int index = dataGridViewEmployees.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.IsActive ? "Active" : "Inactive", employee.AssignedRole.Name);
                dataGridViewEmployees.Rows[index].Tag = employee;
            }

            comboBoxRole.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick employee!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            parent.openChildForm(new FormAddEmployee(parent, (Employee)dataGridViewEmployees.SelectedRows[0].Tag));
        }
    }
}
