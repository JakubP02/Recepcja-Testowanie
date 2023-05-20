using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_handling
{
    public partial class Form_filter_data : Form
    {
        private DatabaseConnection _databaseConnection;
        public Form_filter_data()
        {
            InitializeComponent();
            _databaseConnection = new DatabaseConnection();
            LoadData();

        }

        private void button_cancel_add_patient_form_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_filter_data_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _databaseConnection.LoadDataIntoDataGridView(dataGridView_patients, "Patients");
        }

        private void button_filter_patient_form_data_Click(object sender, EventArgs e)
        {
        }

        private void button_filter_patient_form_data_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();

            StringBuilder query = new StringBuilder("SELECT * FROM Patients WHERE 1=1");

            if (!string.IsNullOrWhiteSpace(textBox_form_filter_data_First_name.Text))
            {
                query.Append(" AND FirstName LIKE '%" + textBox_form_filter_data_First_name.Text + "%'");
            }

            if (!string.IsNullOrWhiteSpace(textBox_form_filter_data_last_name.Text))
            {
                query.Append(" AND LastName LIKE '%" + textBox_form_filter_data_last_name.Text + "%'");
            }

            if (numericUpDown_form_filter_data_age_from.Value > 0 || numericUpDown_form_filter_data_age_to.Value > 0)
            {
                int currentYear = DateTime.Now.Year;
                int fromYear = currentYear - (int)numericUpDown_form_filter_data_age_to.Value;
                int toYear = currentYear - (int)numericUpDown_form_filter_data_age_from.Value;

                query.Append($" AND YEAR(Birthdate) BETWEEN {fromYear} AND {toYear}");
            }

            if (!string.IsNullOrWhiteSpace(textBox_form_filter_data_phone_number.Text))
            {
                query.Append(" AND PhoneNumber LIKE '%" + textBox_form_filter_data_phone_number.Text + "%'");
            }

            if (!string.IsNullOrWhiteSpace(textBox_form_filter_data_adress_email.Text))
            {
                query.Append(" AND Emailadress LIKE '%" + textBox_form_filter_data_adress_email.Text + "%'");
            }

            if (!string.IsNullOrWhiteSpace(textBox_form_filter_data_residential_adress.Text))
            {
                query.Append(" AND ResidentialAdress LIKE '%" + textBox_form_filter_data_residential_adress.Text + "%'");
            }

            if (!string.IsNullOrWhiteSpace(textBox_form_filter_data_social_security_number.Text))
            {
                query.Append(" AND PESEL LIKE '%" + textBox_form_filter_data_social_security_number.Text + "%'");
            }

            DataTable filteredData = _databaseConnection.ExecuteQuery(query.ToString());
            dataGridView_patients.DataSource = filteredData;
        }
    }
}
