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
using SharedElements.Interfaces;
using SharedElements.Models;
using SharedElements.Services;
using Administracja.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;

namespace Administracja.Forms
{
    public partial class FormUsersList : Form
    {
        private FormMain parent;
        private List<Users> users;

        public FormUsersList(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
            
        }

        private void FormUsersList_Load(object sender, EventArgs e)
        {
            UsersService usersService = new UsersService();
            users = usersService.GetAllUsers();
            dataGridViewUsers.Rows.Clear();
            foreach (Users user in users)
            {
                int index = dataGridViewUsers.Rows.Add(user.Id, user.Username, user.AssignedEmployee.FirstName, user.AssignedEmployee.LastName, user.AssignedEmployee.AssignedRole.Name, user.IsActive ? "Active" : "Inactive", user.ExpirationDateOfUser);
                dataGridViewUsers.Rows[index].Tag = user;
            }
            if (dataGridViewUsers.Rows.Count == 0)
            {
                FormPopUpAdd info = new("List of users is empty");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }


            RoleService roleService = new();
            List<Role> roles = roleService.GetAllRoles();
            foreach (Role r in roles)
            {
                comboBoxRole.Items.Add(r);
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormAddUsers(parent));
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick employee!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            parent.openChildForm(new FormUser(parent, (Users)dataGridViewUsers.SelectedRows[0].Tag));
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick employee!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            parent.openChildForm(new FormAddUsers(parent, (Users)dataGridViewUsers.SelectedRows[0].Tag));
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            Users user;
            string? statusText = null;
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick User!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            user = (Users)dataGridViewUsers.SelectedRows[0].Tag;
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
            }
            catch (Exception ex)
            {
                FormPopUpAdd info = new("Something went wrong.");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
            }
            FormUsersList_Load(this, EventArgs.Empty);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string? username = null;
            string? name = null;
            string? lastname = null;
            Role roleName = null;

            IEnumerable<Users> query;
            dataGridViewUsers.Rows.Clear();

            if (textBoxUsername.Text != string.Empty)
            {
                username = textBoxUsername.Text;
            }
            

            if (textBoxName.Text != string.Empty)
            {
                name = textBoxName.Text;
            }
            

            if (textBoxLastName.Text != string.Empty)
            {
                lastname = textBoxLastName.Text;
            }
            

            if (comboBoxRole.SelectedItem != null)
            {
                roleName = (Role)comboBoxRole.SelectedItem;
                query = from i in users
                        where (i.AssignedEmployee.LastName == lastname) || (i.AssignedEmployee.FirstName == name) || (i.Username == username) || (i.AssignedEmployee.AssignedRole.Id == roleName.Id)
                        select i;
            }
            else
            {
                query = from i in users
                        where (i.AssignedEmployee.LastName == lastname) || (i.AssignedEmployee.FirstName == name) || (i.Username == username)
                        select i;
            }
            

            List<Users> data = query.ToList();
            foreach (Users u in data)
            {
                int index = dataGridViewUsers.Rows.Add(u.Id, u.Username, u.AssignedEmployee.FirstName, u.AssignedEmployee.LastName, u.AssignedEmployee.AssignedRole.Name, u.IsActive ? "Active" : "Inactive", u.ExpirationDateOfUser);
                dataGridViewUsers.Rows[index].Tag = u;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLastName.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxUsername.Text = string.Empty;
            comboBoxRole.SelectedItem = null;
            dataGridViewUsers.Rows.Clear();
            foreach (Users user in users)
            {
                int index = dataGridViewUsers.Rows.Add(user.Id, user.Username, user.AssignedEmployee.FirstName, user.AssignedEmployee.LastName, user.AssignedEmployee.AssignedRole.Name, user.IsActive ? "Active" : "Inactive", user.ExpirationDateOfUser);
                dataGridViewUsers.Rows[index].Tag = user;
            }
        }
    }
}

