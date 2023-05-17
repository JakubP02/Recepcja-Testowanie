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
    public partial class FormRoleManage : Form
    {
        private FormMain parent;
        private Role? role = null;
        public FormRoleManage(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        public FormRoleManage(FormMain parent, Role role)
        {
            this.parent = parent;
            this.role = role;
            InitializeComponent();
            textBoxName.Text = role.Name;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                FormPopUpAdd error = new($"Role name cannot be empty!");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }

            RoleService roleService = new();

            if (role is not null)
            {
                if (textBoxName.Text == role.Name)
                {
                    FormPopUpAdd error = new($"New role name cannot be same as old one!");
                    error.StartPosition = FormStartPosition.CenterScreen;
                    error.ShowDialog();
                    return;
                }

                Role updatedRole = new(role.Id, textBoxName.Text);
                try
                {
                    roleService.UpdateRole(updatedRole);
                }
                catch (Exception exception)
                {
                    FormPopUpAdd error = new($"Something went wrong! {exception.Message}");
                    error.StartPosition = FormStartPosition.CenterScreen;
                    error.ShowDialog();
                    return;
                }
            }
            else
            {
                try
                {
                    roleService.AddRole(textBoxName.Text);
                }
                catch (Exception exception)
                {
                    FormPopUpAdd error = new($"Something went wrong! {exception.Message}");
                    error.StartPosition = FormStartPosition.CenterScreen;
                    error.ShowDialog();
                    return;
                }
            }
            parent.openChildForm(new FormRolesList(parent));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormConfimation dialog = null;
            if (role is not null)
            {
                if (textBoxName.Text != role.Name)
                {
                    dialog = new("Are you sure you want to discard?");
                    dialog.StartPosition = FormStartPosition.CenterScreen;
                    dialog.ShowDialog();
                }
            }
            else
            {
                if (textBoxName.Text != "")
                {
                    dialog = new("Are you sure you want to discard?");
                    dialog.StartPosition = FormStartPosition.CenterScreen;
                    dialog.ShowDialog();
                }
            }
            if (dialog is null || dialog.DialogResult == DialogResult.Yes)
            {
                parent.openChildForm(new FormRolesList(parent));
            }
            else
            {
                return;
            }
        }
    }
}
