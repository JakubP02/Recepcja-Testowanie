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
    public partial class addDoctorprompt : Form
    {

        public static int doctorId;

        public int DoctorId { get => doctorId; set => doctorId = value; }

        public addDoctorprompt()
        {


            InitializeComponent();

            string pesel;
            int patientid;
            FormSelectPatientToVisit form = new FormSelectPatientToVisit();
            pesel = form.Pesel;

            DatabaseConnection databaseConnection = new DatabaseConnection();
            patientid = databaseConnection.GetPatientIdByPesel(pesel);

            databaseConnection.GetDoctorsByPatientId(patientid, dataGridViewLastDoctor);






        }

        private void addDoctorprompt_Load(object sender, EventArgs e)
        {


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridViewLastDoctor_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLastDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridViewLastDoctor_SelectionChanged(object sender, EventArgs e)
        {
            doctorId = 0;
            if (dataGridViewLastDoctor.SelectedRows.Count > 0)
            {
                DoctorId = (int)dataGridViewLastDoctor.SelectedRows[0].Cells["Id"].Value;

            }

        }

        private void btnOtherDoctors_Click(object sender, EventArgs e)
        {
            doctorId = 0;
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
    }
}
