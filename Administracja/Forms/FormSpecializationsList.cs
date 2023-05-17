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
using SharedElements.Models;
using WinFormsApp1;

namespace Administracja.Forms
{
    public partial class FormSpecializationsList : Form
    {
        private FormMain parent;
        public FormSpecializationsList(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void FormSpecializationsList_Load(object sender, EventArgs e)
        {
            SpecializationService specializationService = new();
            List<Specialization> specializations = specializationService.GetAllSpecializations();
            dataGridViewSpecializations.Rows.Clear();
            foreach (Specialization specialization in specializations)
            {
                int index = dataGridViewSpecializations.Rows.Add(specialization.Id, specialization.Name);
                dataGridViewSpecializations.Rows[index].Tag = specialization;
            }
            if (dataGridViewSpecializations.Rows.Count == 0)
            {
                FormPopUpAdd info = new("There's no specializations in database.");
                info.StartPosition = FormStartPosition.CenterScreen;
                info.ShowDialog();
                return;
            }
        }

        private void buttonAddSpecialization_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormSpecializationManage(parent));
        }

        private void buttonEditSpecialization_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpecializations.SelectedRows.Count == 0)
            {
                FormPopUpAdd error = new($"Choose specialization first.");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }
            parent.openChildForm(new FormSpecializationManage(parent, (Specialization)dataGridViewSpecializations.SelectedRows[0].Tag));
        }

        private void buttonDeleteSpecialization_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpecializations.SelectedRows.Count == 0)
            {
                FormPopUpAdd error = new($"Choose specialization first.");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }
            FormConfimation dialog = new("Are you sure you want to delete this specialization?");
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
            if(dialog.DialogResult != DialogResult.Yes || dialog.DialogResult == null)
            {
                return;
            }
            SpecializationService specializationService = new();
            try
            {
                Specialization spec = (Specialization)dataGridViewSpecializations.SelectedRows[0].Tag;
                specializationService.DeleteSpecialization(spec.Id);
            }
            catch (Exception exception)
            {
                FormPopUpAdd error = new($"{exception.Message}");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }
            parent.openChildForm(new FormSpecializationsList(parent));
        }

        private void dataGridViewSpecializations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
