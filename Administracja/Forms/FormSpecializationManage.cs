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
using SharedElements.Services;
using WinFormsApp1;

namespace Administracja.Forms
{
    public partial class FormSpecializationManage : Form
    {
        private FormMain parent;
        private Specialization? specialization = null;
        public FormSpecializationManage(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        public FormSpecializationManage(FormMain parent, Specialization specialization)
        {
            this.parent = parent;
            this.specialization = specialization;
            InitializeComponent();
            textBoxName.Text = specialization.Name;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                FormPopUpAdd error = new($"Specialization name cannot be empty!");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }

            SpecializationService specializationService = new();

            if (specialization is not null)
            {
                if (textBoxName.Text == specialization.Name)
                {
                    FormPopUpAdd error = new($"New specialization name cannot be same as old one!");
                    error.StartPosition = FormStartPosition.CenterScreen;
                    error.ShowDialog();
                    return;
                }

                Specialization updatedSpecialization = new(specialization.Id, textBoxName.Text);
                try
                {
                    specializationService.UpdateSpecialization(updatedSpecialization);
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
                    specializationService.AddSpecialization(textBoxName.Text);
                }
                catch (Exception exception)
                {
                    FormPopUpAdd error = new($"{exception.Message}");
                    error.StartPosition = FormStartPosition.CenterScreen;
                    error.ShowDialog();
                    return;
                }
            }
            parent.openChildForm(new FormSpecializationsList(parent));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormConfimation dialog = null;
            if (specialization is not null)
            {
                if (textBoxName.Text != specialization.Name)
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
                parent.openChildForm(new FormSpecializationsList(parent));
            }
            else
            {
                return;
            }
        }
    }
}
