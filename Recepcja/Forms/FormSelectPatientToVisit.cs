using Patient_handling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepcja.Forms
{
    public partial class FormSelectPatientToVisit : Form
    {
        private static string pesel;
        public FormSelectPatientToVisit()
        {
            InitializeComponent();

        }

        public string Pesel { get => pesel; set => pesel = value; }

        private void button_filter_patient_form_data_Click(object sender, EventArgs e)
        {
            if (txtPesel.Text == "")
            {
                MessageBox.Show("enter patient's pesel");
                return;
            }

            string searchText = txtPesel.Text;
            string columnName = "Pesel";

            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.SearchDataInView(searchText, "Patients", dataGridView_patients, columnName);

        }

        private void dataGridView_patients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CalenderAddNewVisit form_VisitDetails = new CalenderAddNewVisit();
            form_VisitDetails.TopLevel = false;
            form_VisitDetails.FormBorderStyle = FormBorderStyle.None;
            form_VisitDetails.Dock = DockStyle.Fill;
            form_ReceptionMenu2 receptionMenu2 = Application.OpenForms["form_ReceptionMenu2"] as form_ReceptionMenu2;
            receptionMenu2.panel1.Controls.Add(form_VisitDetails);
            receptionMenu2.panel1.Tag = form_VisitDetails;
            form_VisitDetails.BringToFront();
            form_VisitDetails.Show();

        }

        private void dataGridView_patients_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView_patients.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_patients.SelectedRows[0];
                Pesel = selectedRow.Cells["Pesel"].Value.ToString();

            }


        }

        private void FormSelectPatientToVisit_Load(object sender, EventArgs e)
        {

        }
    }
}
