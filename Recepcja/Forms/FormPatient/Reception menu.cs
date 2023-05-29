using Patient_Handling;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices;

namespace Recepcja
{
    public partial class Form_reception_menu : Form
    {


        public Form_reception_menu()
        {
            InitializeComponent();
 
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.LoadDataIntoDataGridView(dataGridView1, "Patients");

        }

        private void button_menu_remove_patient_Click(object sender, EventArgs e)
        {
            int selcetedPatientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            int selcetedPatientStatus = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Status"].Value);

            if (selcetedPatientStatus == 0)
            {
                MessageBox.Show("this patient is already inactive");
                return;

            }

            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "0" };
            string condition = $"ID = {selcetedPatientId}";
            databaseConnection.UpdateDataInDatabase("Patients", columnNames, columnValues, condition);


            DatabaseConnection databaseConnection1 = new DatabaseConnection();

            databaseConnection1.LoadDataIntoDataGridView(dataGridView1, "Patients");

        }

        private void Form_reception_menu_Load(object sender, EventArgs e)
        {

        }


        private void button_menu_activate_patient_Click(object sender, EventArgs e)
        {
           

            int selcetedPatientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            int selcetedPatientStatus = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Status"].Value);

            if (selcetedPatientStatus == 1)
            {
                MessageBox.Show("this patient is already active");
                return;

            }



            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "1" };
            string condition = $"ID = {selcetedPatientId}";
            databaseConnection.UpdateDataInDatabase("Patients", columnNames, columnValues, condition);

            DatabaseConnection databaseConnection1 = new DatabaseConnection();

            databaseConnection1.LoadDataIntoDataGridView(dataGridView1, "Patients");


        }

   
    }
}