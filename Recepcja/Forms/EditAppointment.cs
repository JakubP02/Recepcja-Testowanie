using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_handling
{
    public partial class EditAppointment : Form
    {
        public EditAppointment()
        {
            InitializeComponent();

            List<string> listaStringow = new List<string>();
            listaStringow.Add("08:30");
            listaStringow.Add("09:00");
            listaStringow.Add("09:30");
            listaStringow.Add("10:00");
            listaStringow.Add("10:30");
            listaStringow.Add("11:00");
            listaStringow.Add("11:30");
            listaStringow.Add("12:00");
            listaStringow.Add("12:30");
            listaStringow.Add("13:00");
            listaStringow.Add("13:30");
            listaStringow.Add("14:00");
            listaStringow.Add("14:30");
            listaStringow.Add("15:00");
            listaStringow.Add("15:30");
            listaStringow.Add("16:00");
            listaStringow.Add("16:30");
            listaStringow.Add("17:00");
            listaStringow.Add("17:30");
            listaStringow.Add("18:00");
            listaStringow.Add("18:30");
            listaStringow.Add("19:00");
            listaStringow.Add("19:30");

            comboBox_edit_apointment.Items.AddRange(listaStringow.ToArray());

            DatabaseConnection database = new DatabaseConnection();
            database.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "MedicalVisit");
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
