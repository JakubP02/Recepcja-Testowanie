using SharedElements.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Patient_handling
{
    public partial class form_visitDetails : Form
    {
        public form_visitDetails(string office, string hour, string doctorName, string patientName,string date)
        {
            InitializeComponent();
            textBoxDoctor.Text = doctorName;
            textBoxpatient.Text = patientName;
            textBoxofficess.Text = office;
            textBoxdate.Text = date;
            textBoxhour.Text = hour;
         

        }

        private void label1_Click(object sender, EventArgs e)
        {
        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();



        }

        private void form_visitDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
