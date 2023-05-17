using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administracja.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using SharedElements.Helpers;
using SharedElements.Interfaces;
using SharedElements.Models;
using SharedElements.Services;
using WinFormsApp1;

namespace Administracja.Forms
{
    public partial class FormAddUsers : Form
    {
        private FormMain parent;
        private Users? user = null;
        private Employee? employee = null;
        public FormAddUsers(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
            buttonAdd.Text = "Add";
            groupBox1.Text = "Add User";
        }
        public FormAddUsers(FormMain parent, Users user)
        {
            this.parent = parent;
            this.user = user;
            InitializeComponent();

            dateTimePickerExpirationDate.Value = user.ExpirationDateOfUser;
            buttonAdd.Text = "Save";
            groupBox1.Text = "Edit User";
        }

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new();
            foreach (Employee emp in employeeService.GetAllEmployees())
            {
                int index = comboBoxEmployee.Items.Add(emp);
                if ((user?.AssignedEmployee != null && user.AssignedEmployee.Id == emp.Id))
                {
                    comboBoxEmployee.SelectedIndex = index;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkIfFilled() != true)
            {
                return;
            }
            if (user is null)
            {
                if (UserHelpers.CheckIfEmployeeIsAssigned((Employee)comboBoxEmployee.SelectedItem) != true)
                {
                    FormPopUpAdd incorrect = new("Employee already has user");
                    incorrect.StartPosition = FormStartPosition.CenterScreen;
                    incorrect.ShowDialog();
                    return;
                }
            }

            if (UserHelpers.CheckIfDateIsValid(dateTimePickerExpirationDate.Value) != true)
            {
                FormPopUpAdd incorrect = new("You can't choose past date");
                incorrect.StartPosition = FormStartPosition.CenterScreen;
                incorrect.ShowDialog();
                return;
            }

            UsersService usersService = new();
            Users userToAdd = new(
                user is not null ? user.Id : null,
                "username",
                "password",
                dateTimePickerExpirationDate.Value,
                (Employee)comboBoxEmployee.SelectedItem,
                user is not null ? user.IsActive : false
                );
            try
            {
                if (user is null)
                {
                    usersService.AddUser(userToAdd);
                }
                else
                {
                    if (user.AssignedEmployee.Id != userToAdd.AssignedEmployee.Id)
                    {
                        if (UserHelpers.CheckIfEmployeeIsAssigned((Employee)comboBoxEmployee.SelectedItem) != true)
                        {
                            FormPopUpAdd incorrect = new("Employee already have user");
                            incorrect.StartPosition = FormStartPosition.CenterScreen;
                            incorrect.ShowDialog();
                            return;
                        }
                        else
                        {
                            usersService.UpdateUser(userToAdd);
                        }
                    }
                    else
                    {
                        usersService.UpdateUser(userToAdd);
                    }
                }

            }
            catch (Exception ex)
            {
                FormPopUpAdd error = new($"Something went wrong when adding to database.\nPlease try again.\n{ex.Message}");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }

            FormPopUpAdd ok;
            if (user is null)
            {
                ok = new("User added!");
            }
            else
            {
                ok = new("User's data changed!");
            }
            ok.StartPosition = FormStartPosition.CenterScreen;
            ok.ShowDialog();
            parent.changeMainLabelText("User List");
            parent.openChildForm(new FormUsersList(parent));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormConfimation dialog = null;
            if (preventFromClosing(user) != true)
            {
                dialog = new("You made some changes, are you sure you want to leave?");
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.ShowDialog();
            }
            if (dialog == null || dialog.DialogResult == DialogResult.Yes)
            {
                parent.changeMainLabelText("User List");
                parent.openChildForm(new FormUsersList(parent));
            }
            else
            {
                return;
            }
        }

        private bool checkIfFilled()
        {
            if (comboBoxEmployee.SelectedItem == null)
            {
                FormPopUpAdd error = new("Please select employee");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return false;
            }
            return true;
        }
        private bool preventFromClosing(Users user)
        {
            if (user == null)
            {
                if (comboBoxEmployee.SelectedItem != null)
                {
                    return false;
                }
                return true;
            }
            else
            {
                if (comboBoxEmployee.SelectedItem.ToString() != user.AssignedEmployee.ToString())
                {
                    return false;
                }
                if (dateTimePickerExpirationDate.Value != user.ExpirationDateOfUser)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
