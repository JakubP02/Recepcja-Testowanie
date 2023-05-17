using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedElements.Helpers;
using SharedElements.Models;
using SharedElements.Services;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Administracja.Forms
{
    public partial class FormAddEmployee : Form
    {
        private FormMain parent;
        private Employee? employee = null;
        public FormAddEmployee(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        public FormAddEmployee(FormMain parent, Employee employee)
        {
            this.parent = parent;
            this.employee = employee;
            InitializeComponent();
            buttonNext.Text = "Edit";
            groupBox1.Text = "Edit employee";
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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormConfimation dialog = null;
            if (preventFromClosing(employee) != true)
            {
                dialog = new("You made some changes, are you sure you want to leave?");
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.ShowDialog();
            }
            if (dialog == null || dialog.DialogResult == DialogResult.Yes)
            {
                parent.openChildForm(new FormEmployeeList(parent));
            }
            else
            {
                return;
            }
        }

        private void toggleAddIfMandaotryIsFiled()
        {
            if (textBoxName.Text == "")
            {
                return;
            }

            if (textBoxLastName.Text == "")
            {
                return;
            }
            if (textBoxPESEL.Text == "")
            {
                return;
            }

            if (comboBoxRole.SelectedItem == null)
            {
                //buttonNext.Enabled = false;
                return;
            }
            if (comboBoxRole.SelectedIndex.ToString() == "Medical Doctor" && checkedListBox1.SelectedItem == null)
            {
                /*                buttonNext.Enabled = false;
                */
                return;
            }

            buttonNext.Enabled = true;
        }
        private bool preventFromClosing(Employee employee)
        {
            if (employee == null)
            {
                return true;
            }
            else
            {
                if (comboBoxRole.SelectedItem.ToString() != employee.AssignedRole.ToString())
                {
                    return false;
                }
                if (dateTimePickerBirth.Value != employee.DateOfBirth)
                {
                    return false;
                }
                if (textBoxName.Text != employee.FirstName)
                {
                    return false;
                }

                if (textBoxLastName.Text != employee.LastName)
                {
                    return false;
                }
                if (textBoxPESEL.Text != employee.PESEL)
                {
                    return false;
                }
                if (textBoxEmail.Text != employee.EmailAddress && textBoxEmail.Text != string.Empty)
                {
                    return false;
                }
                if (textBoxMailingAddress.Text != employee.CorrespondenceAddress && textBoxMailingAddress.Text != string.Empty)
                {
                    return false;
                }
                if (textBoxPhone.Text != employee.PhoneNumber && textBoxPhone.Text != string.Empty)
                {
                    return false;
                }
                if (employee.Sex != null)
                {
                    string gender;
                    if (employee.Sex.ToString() == "M")
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    if (comboBoxSex.SelectedItem.ToString() != gender)
                    {
                        return false;
                    }
                }
                else
                {
                    if (comboBoxSex.SelectedItem != null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            RoleService roleService = new();
            foreach (Role role in roleService.GetAllRoles())
            {
                int index = comboBoxRole.Items.Add(role);
                if (employee?.AssignedRole != null && employee.AssignedRole.Id == role.Id)
                {
                    comboBoxRole.SelectedIndex = index;
                }
            }
            if (employee == null || employee.ListOfSpecialization.Count < 1)
            {
                checkedListBox1.Visible = false;
                SpecializationService specializationService = new SpecializationService();
                foreach (Specialization specialization in specializationService.GetAllSpecializations())
                {
                    int index = checkedListBox1.Items.Add(specialization);
                }
            }

            if (employee != null)
            {
                foreach (Specialization spec in employee.ListOfSpecialization)
                {
                    int index = checkedListBox1.Items.Add(spec);
                    checkedListBox1.SelectedIndex = index;
                    checkedListBox1.SetItemChecked(index, true);
                }
            }

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

        private void comboBoxRole_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem == null)
            {
                return;
            }
            if (comboBoxRole.SelectedItem.ToString() != "Medical Doctor")
            {
                labelSpecialties.Visible = false;
                checkedListBox1.Visible = false;
                checkedListBox1.SelectedItem = null;
                return;
            }

            labelSpecialties.Visible = true;
            checkedListBox1.Visible = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            toggleAddIfMandaotryIsFiled();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            toggleAddIfMandaotryIsFiled();
        }

        private void textBoxPESEL_TextChanged(object sender, EventArgs e)
        {
            toggleAddIfMandaotryIsFiled();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleAddIfMandaotryIsFiled();
        }

        private void comboBoxSpecialties_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleAddIfMandaotryIsFiled();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Specialization? specialization = null;
            string? mailingAddress = null;
            string? email = null;
            string? phone = null;
            char? sex = null;
            if (checkedListBox1.SelectedItem is not null) specialization = (Specialization)checkedListBox1.SelectedItem;
            if (textBoxMailingAddress.Text != "") mailingAddress = textBoxMailingAddress.Text;
            if (textBoxEmail.Text != "") email = textBoxEmail.Text;
            if (textBoxPhone.Text != "") phone = textBoxPhone.Text;
            if (comboBoxSex.SelectedItem is not null) sex = (char)comboBoxSex.Text[0];
            try
            {
                EmployeeHelper.IsPeselCorrect(textBoxPESEL.Text, dateTimePickerBirth.Value, (string?)comboBoxSex.SelectedItem);
                EmployeeHelper.IsDateOfBirthCorrect(dateTimePickerBirth.Value);
                if (textBoxEmail.Text != "" && !EmployeeHelper.IsEmailAddressCorrect(textBoxEmail.Text, textBoxName.Text, textBoxLastName.Text))
                {
                    return;
                }
                if (textBoxPhone.Text != "" && !EmployeeHelper.IsPhoneNumberCorrect(textBoxPhone.Text))
                {
                    return;
                }
                /*if (!EmployeeHelper.IsPeselCorrect(textBoxPESEL.Text, dateTimePickerBirth.Value, (string?)comboBoxSex.SelectedItem))
                {
                    FormPopUpAdd incorrect = new("Entered user data is not correct");
                    incorrect.ShowDialog();
                    return;
                }
                */
            }
            catch (Exception ex)
            {
                FormPopUpAdd error = new($"{ex.Message}");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }
            List<Specialization?> special = new List<Specialization>();
            foreach (Specialization spec in checkedListBox1.CheckedItems)
            {
                special.Add(spec);
            }
            EmployeeService employeeService = new();
            Employee employeeToAdd = new(
                employee is not null ? employee.Id : null,
                textBoxName.Text,
                textBoxLastName.Text,
                textBoxPESEL.Text,
                dateTimePickerBirth.Value,
                employee is not null ? employee.IsActive : true,
                (Role)comboBoxRole.SelectedItem,
                special,
                mailingAddress,
                email,
                phone,
                sex
            );
            try
            {
                if (employee is null)
                {
                    EmployeeHelper.NameCheck(employeeToAdd.FirstName, employeeToAdd.LastName);
                    employeeService.AddEmployee(employeeToAdd);
                }
                else
                {
                    employeeService.UpdateEmployee(employeeToAdd);
                }

            }
            catch (Exception ex)
            {
                FormPopUpAdd error = new($"{ex.Message}");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }

            FormPopUpAdd ok;
            if (employee is null)
            {
                ok = new("Employee added!");
            }
            else
            {
                ok = new("Employee's data changed!");
            }
            ok.StartPosition = FormStartPosition.CenterScreen;
            ok.ShowDialog();
            if (employee is null)
            {
                FormConfimation dialog = new("Do you want to create user now?");
                dialog.StartPosition = FormStartPosition.CenterScreen;
                if (dialog.ShowDialog() == DialogResult.Yes)
                {
                    parent.changeMainLabelText("Add User");
                    parent.openChildForm(new FormAddUsers(parent));
                }
                else
                {
                    parent.openChildForm(new FormEmployeeList(parent));
                }
            }
            else
            {
                parent.openChildForm(new FormEmployeeList(parent));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
