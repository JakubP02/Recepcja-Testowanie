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
    public partial class FormRolesList : Form
    {
        private FormMain parent;
        public FormRolesList(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void FormRolesList_Load(object sender, EventArgs e)
        {
            RoleService roleService = new();
            List<Role> roles = roleService.GetAllRoles();
            dataGridViewRoles.Rows.Clear();
            foreach (Role role in roles)
            {
                int index = dataGridViewRoles.Rows.Add(role.Id, role.Name);
                dataGridViewRoles.Rows[index].Tag = role;
            }
            if (dataGridViewRoles.Rows.Count == 0)
            {
                FormPopUpAdd info = new("There's no role's in database.");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormRoleManage(parent));
        }

        private void buttonEditRole_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoles.SelectedRows.Count == 0)
            {
                FormPopUpAdd error = new($"Choose role first.");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }
            parent.openChildForm(new FormRoleManage(parent, (Role)dataGridViewRoles.SelectedRows[0].Tag));
        }

        private void buttonDeleteRole_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoles.SelectedRows.Count == 0)
            {
                FormPopUpAdd error = new($"Choose role first.");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }
            RoleService roleService = new();
            try
            {
                Role role = (Role)dataGridViewRoles.SelectedRows[0].Tag;
                roleService.DeleteRole(role.Id);
            }
            catch (Exception exception)
            {
                FormPopUpAdd error = new($"Error: {exception.Message}");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }
            parent.openChildForm(new FormRolesList(parent));
        }
    }
}
