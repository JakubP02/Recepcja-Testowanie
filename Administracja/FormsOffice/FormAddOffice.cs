using SharedElements.Models;
using SharedElements.Services;
using SharedElements.Helpers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Administracja.Forms
{
    public partial class FormAddOffice : Form
    {
        private FormMain parent;
        private Office? office;
        public FormAddOffice(FormMain parent)
        {
            this.parent = parent;
            InitializeComponent();
            textBoxStatus.Visible = false;
            labelStatus.Visible = false;
            buttonChangeStatus.Visible = false;
        }
        public FormAddOffice(FormMain parent, Office office)
        {
            this.parent = parent;
            this.office = office;
            InitializeComponent();
            groupBox1.Text = "Edit Office";
            textBoxNumber.Text = office.Number;
            checkBoxIsGeneral.Checked = office.IsGeneral;
            textBoxStatus.Text = office.IsActive ? "Active" : "Inactive";
            labelStatus.Visible = true;
            textBoxStatus.Visible = true;
            buttonChangeStatus.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (checkChanges() != true)
            {
                FormConfimation info = new("You've made some changes. Are you sure you want to exit?");
                info.StartPosition = FormStartPosition.CenterParent;
                if(info.ShowDialog() != DialogResult.Yes)
                {
                    return;
                }
            }
            parent.openChildForm(new FormOfficeList(parent));
            parent.changeMainLabelText("Office List");
        }
        private bool checkChanges()
        {
            if (office is null)
            {
                if (checkBoxIsGeneral.Checked == true)
                {
                    return false;
                }
                if (textBoxNumber.Text != string.Empty)
                {
                    return false;
                }
                if (comboBoxSpecialization.SelectedItem != null)
                {
                    return false;
                }
                return true;
            }
            if(checkBoxIsGeneral.Checked != office.IsGeneral) 
            {
                return false;
            }
            if(textBoxNumber.Text != office.Number)
            {
                return false;
            }
            if(comboBoxSpecialization.SelectedItem.ToString() != office.Specialization.Name)
            {
                return false;
            }
            return true;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                OfficeHelpers.validateOfficeData(textBoxNumber.Text, (Specialization)comboBoxSpecialization.SelectedItem);
            }
            catch (Exception ex)
            {
                FormPopUpAdd error = new($"{ex.Message}");
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                return;
            }
            bool isGeneral = false;
            if (checkBoxIsGeneral.Checked == true)
            {
                isGeneral = true;
            }
            OfficeService officeService = new();
            Office officeToAdd = new(
                office is not null ? office.Id : null,
                textBoxNumber.Text,
                (Specialization)comboBoxSpecialization.SelectedItem,
                office is not null ? office.IsActive : false,
                office is not null ? office.IsGeneral : isGeneral
            );
            try
            {
                if (office == null)
                {
                    officeService.AddOffice(officeToAdd);
                }
                else
                {
                    officeService.UpdateOffice(officeToAdd);
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
            if (office is null)
            {
                ok = new("Office added!");
            }
            else
            {
                ok = new("Office data changed!");
            }
            ok.StartPosition = FormStartPosition.CenterScreen;
            ok.ShowDialog();
        }

        private void FormAddOffice_Load(object sender, EventArgs e)
        {
            SpecializationService specializationService = new();
            List<Specialization> specs = specializationService.GetAllSpecializations();

            foreach (Specialization spec in specs)
            {
                int index = comboBoxSpecialization.Items.Add(spec);
                if (office?.Specialization != null && office.Specialization.Id == spec.Id)
                {
                    comboBoxSpecialization.SelectedIndex = index;
                }
            }

        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            OfficeService officeService = new();
            string? text = null;
            try
            {
                if (office.IsActive == true)
                {
                    text = "You will deactivate office. Are you sure you want to continue?";
                }
                else
                {
                    text = "You will activate office. Are you sure you want to continue?";
                }
                FormConfimation ok = new(text);
                ok.StartPosition = FormStartPosition.CenterScreen;
                if(ok.ShowDialog() == DialogResult.Yes)
                {
                    officeService.ChangeIsActiveStatus((int)office.Id, !office.IsActive);
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
            textBoxStatus.Text = !office.IsActive ? "Active" : "Inactive";
        }
    }
}
