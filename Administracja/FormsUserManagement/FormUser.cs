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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using SharedElements.Interfaces;
using SharedElements.Models;
using SharedElements.Services;
using Microsoft.VisualBasic.ApplicationServices;

namespace Administracja.Forms
{
    public partial class FormUser : Form
    {
        private Users user;
        private FormMain parent;
        private List<Users> users;
        public FormUser(FormMain parent, Users user)
        {
            this.parent = parent;
            this.user = user;
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormUsersList(parent));
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            textBoxId.Text = user.Id.ToString();
            textBoxUsername.Text = user.Username;
            textBoxStatus.Text = user.IsActive ? "Active" : "Inactive";
            dateTimePickerExpirationDate.Value = user.ExpirationDateOfUser;

            textBoxEmpFirstName.Text = user.AssignedEmployee.FirstName;
            textBoxEmpLastName.Text = user.AssignedEmployee.LastName;
            textBoxEmpRole.Text = user.AssignedEmployee.AssignedRole.Name;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormAddUsers(parent, user));
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            string? statusText = null;
            UsersService usersService = new UsersService();
            if (user.AssignedEmployee.IsActive == false)
            {
                FormPopUpAdd formPopUpAdd = new("Employee has inactive status");
                formPopUpAdd.StartPosition = FormStartPosition.CenterScreen;
                formPopUpAdd.ShowDialog();
                return;
            }
            if (user.IsActive == false)
            {
                statusText = "Are you sure you want to activate user account?";
            }
            else
            {
                statusText = "Are you sure you want to deactivate user account?";
            }
            FormConfimation dialog = new(statusText);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.No || dialog.DialogResult == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                usersService.ChangeUserStatus((int)user.Id, !user.IsActive);
                users = usersService.GetAllUsers();
                foreach (Users u in users)
                {
                    if (u.Id == user.Id)
                    {
                        this.user = u;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                FormPopUpAdd info = new("Something went wrong.");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
            }

            FormUser_Load(this, EventArgs.Empty);
        }

        private void dateTimePickerExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerExpirationDate.Value = user.ExpirationDateOfUser;
        }
    }
}
