using Patient_handling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Handling
{
    public partial class Form_edit_patient : Form
    {


        public Form_edit_patient()
        {
            InitializeComponent();


            DatabaseConnection databaseConnection = new DatabaseConnection();

            databaseConnection.LoadDataIntoDataGridView(dataGridView_patients, "Patients");

            if (dataGridView_patients.Rows.Count > 0)
            {
                //Wywołujemy metodę CellClick dla pierwszego wiersza
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                DataGridView_patients_CellClick(this, args);
            }
            this.dataGridView_patients.SelectionChanged += new System.EventHandler(this.DataGridView_patients_SelectionChanged);
        }

        private void button_cancel_add_patient_form_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void button_edit_patient_form_Click(object sender, EventArgs e)
        {
            /* if (string.IsNullOrEmpty(textBox_form_edit_patient_last_name.Text) ||
                 string.IsNullOrEmpty(textBox_form_edit_patient_phone_number.Text) ||
                 string.IsNullOrEmpty(textBox_form_edit_patient_adress.Text) ||
                 string.IsNullOrEmpty(textBox_form_edit_patient_residential_adress.Text))
             {
                 MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                 return;
             }

             if (!System.Text.RegularExpressions.Regex.IsMatch(textBox_form_edit_patient_phone_number.Text, @"^\+?[0-9]{3}-?[0-9]{3}-?[0-9]{3}$"))
             {
                 MessageBox.Show("Numer telefonu musi składać się z dziewięciu cyfr.");
                 return;
             }

             if (!System.Text.RegularExpressions.Regex.IsMatch(textBox_form_edit_patient_adress.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
             {
                 MessageBox.Show("Adres email jest nieprawidłowy.");
                 return;
             }

             /*_selectedPatient.LastName = textBox_form_edit_patient_last_name.Text;
             _selectedPatient.PhoneNumber = textBox_form_edit_patient_phone_number.Text;
             _selectedPatient.EmailAddress = textBox_form_edit_patient_adress.Text;
             _selectedPatient.ResidentialAddress = textBox_form_edit_patient_residential_adress.Text;

             this.DialogResult = DialogResult.OK;
             this.Hide();

             */

            Patient patient = new Patient()
            {

                LastName = textBox_form_edit_patient_last_name.Text,
                PhoneNumber = textBox_form_edit_patient_phone_number.Text,
                EmailAddress = textBox_form_edit_patient_adress.Text,
                ResidentialAddress = textBox_form_edit_patient_residential_adress.Text

            };



            string lastnameBase = dataGridView_patients.SelectedRows[0].Cells["LastName"].Value.ToString();
            string phonenumberBase = dataGridView_patients.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
            string emailBase = dataGridView_patients.SelectedRows[0].Cells["EmailAdress"].Value.ToString();
            string residentialadressBase = dataGridView_patients.SelectedRows[0].Cells["ResidentialAdress"].Value.ToString();


            if (patient.LastName == lastnameBase && patient.PhoneNumber == phonenumberBase && patient.EmailAddress == emailBase && patient.ResidentialAddress == residentialadressBase)
            {
                MessageBox.Show("The data of this patient to which you want to change is the same");
                return;
            }
            if (!Regex.IsMatch(patient.PhoneNumber, @"^\+?[0-9]{3}-?[0-9]{3}-?[0-9]{3}$"))
            {
                MessageBox.Show("The phone number must consist of nine number");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(patient.EmailAddress, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Adres email jest nieprawidłowy.");
                return;
            }



            int selcetedPatientId = Convert.ToInt32(dataGridView_patients.SelectedRows[0].Cells["ID"].Value);

            DatabaseConnection databaseConnection = new DatabaseConnection();
            string[] columnNames = { "LastName", "PhoneNumber", "EmailAdress", "ResidentialAdress" };
            string[] columnValues = { patient.LastName, patient.PhoneNumber, patient.EmailAddress, patient.ResidentialAddress };
            string condition = $"ID = {selcetedPatientId}";
            databaseConnection.UpdateDataInDatabase("Patients", columnNames, columnValues, condition);

            DatabaseConnection databaseConnection1 = new DatabaseConnection();
            databaseConnection1.LoadDataIntoDataGridView(dataGridView_patients, "Patients");








        }

        private void Form_edit_patient_Load(object sender, EventArgs e)
        {
            /*textBox_form_edit_patient_last_name.Text = _selectedPatient.LastName;
            textBox_form_edit_patient_phone_number.Text = _selectedPatient.PhoneNumber;
            textBox_form_edit_patient_adress.Text = _selectedPatient.EmailAddress;
            textBox_form_edit_patient_residential_adress.Text = _selectedPatient.ResidentialAddress;*/
        }

        private void dataGridView_patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void textBox_form_edit_patient_last_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateTextBoxValues(DataGridViewRow selectedRow)
        {
            string lastname = selectedRow.Cells["LastName"].Value.ToString();
            string phonenumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
            string email = selectedRow.Cells["EmailAdress"].Value.ToString();
            string residentialadress = selectedRow.Cells["ResidentialAdress"].Value.ToString();

            textBox_form_edit_patient_last_name.Text = lastname;
            textBox_form_edit_patient_phone_number.Text = phonenumber;
            textBox_form_edit_patient_adress.Text = email;
            textBox_form_edit_patient_residential_adress.Text = residentialadress;
        }

        private void DataGridView_patients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_patients.Rows[e.RowIndex];
                UpdateTextBoxValues(selectedRow);
            }

        }
        private void DataGridView_patients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_patients.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_patients.SelectedRows[0];
                UpdateTextBoxValues(selectedRow);
            }
        }

    }
}
