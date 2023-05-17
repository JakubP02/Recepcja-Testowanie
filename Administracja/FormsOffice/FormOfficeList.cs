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
using System.Windows.Forms.VisualStyles;
using WinFormsApp1;

namespace Administracja.Forms
{
    public partial class FormOfficeList : Form
    {
        private FormMain parent;
        private Office? office = null;
        public FormOfficeList(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormAddOffice(parent, (Office)dataGridViewOffice.SelectedRows[0].Tag));
            parent.changeMainLabelText("Edit Office");

        }

        private void buttonAddOffice_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormAddOffice(parent));
            parent.changeMainLabelText("Add Office");
        }

        private void FormOfficeList_Load(object sender, EventArgs e)
        {
            dataGridViewOffice.Rows.Clear();

            OfficeService officeService = new();
            List<Office> officeList = officeService.GetOfficeList();

            foreach (Office office in officeList)
            {
                int index = dataGridViewOffice.Rows.Add(office.Id, office.Number, office.Specialization.Name, office.IsActive ? "Active" : "Inactive", office.IsGeneral ? "Yes" : "No");
                dataGridViewOffice.Rows[index].Tag = office;
            }

            if (dataGridViewOffice.Rows.Count == 0)
            {
                FormPopUpAdd info = new("List of offices is empty");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
            }
        }

        private void buttonDeactivateOffice_Click(object sender, EventArgs e)
        {
            Office off;
            if (dataGridViewOffice.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Office!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            OfficeService officeService = new();
            off = (Office)dataGridViewOffice.SelectedRows[0].Tag;
            string? text = null;
            try
            {
                if (off.IsActive == true)
                {
                    text = "You will deactivate office. Are you sure you want to continue?";
                }
                else
                {
                    text = "You will activate office. Are you sure you want to continue?";
                }
                FormConfimation ok = new(text);
                ok.StartPosition = FormStartPosition.CenterScreen;
                if (ok.ShowDialog() == DialogResult.Yes)
                {
                    officeService.ChangeIsActiveStatus((int)off.Id, !off.IsActive);
                }
                else
                {
                    return;
                }
            }
            catch (Exception exception)
            {
                FormPopUpAdd info = new("Something went wrong.");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
            }
            FormOfficeList_Load(this, EventArgs.Empty);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Office off;
            if (dataGridViewOffice.SelectedRows.Count == 0)
            {
                FormPopUpAdd info = new("First pick Office!");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
            OfficeService officeService = new();
            off = (Office)dataGridViewOffice.SelectedRows[0].Tag;
            FormConfimation conf = new("Are you sure you want to delete office?");
            if(conf.ShowDialog() != DialogResult.Yes)
            {
                return;
            }
            try
            {
                officeService.DeleteOffice(off);
            }
            catch (Exception ex)
            {
                FormPopUpAdd info = new("Something went wrong with deleting office.");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
            }
            FormPopUpAdd ok = new("Office deleted!");
            ok.StartPosition = FormStartPosition.CenterScreen;
            ok.ShowDialog();
            FormOfficeList_Load(this, EventArgs.Empty);
        }
    }
}
