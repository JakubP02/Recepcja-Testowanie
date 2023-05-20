using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Windows.Forms;


namespace Patient_handling
{
    public class MedicalVisit
    {
        private int Doctorid ;
        private int patientid ;
        private DateTime date1 ;
        private TimeSpan time ;

        public int Doctorid1 { get => Doctorid; set => Doctorid = value; }
        public int Patientid { get => patientid; set => patientid = value; }

        public DateTime Date1 { get => date1; set => date1 = value; }
        public TimeSpan Time { get => time; set => time = value; }

        public void ExportToPDF(DataGridViewRow row)
        {
  
            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12);

    
            string doctorId = row.Cells["DoctorName"].Value.ToString();
            string patientId = row.Cells["PatientName"].Value.ToString();
            string date = row.Cells["Date"].Value.ToString();
            string time = row.Cells["HOUR"].Value.ToString();

            string text = "Doctor Name: " + doctorId + "\nPatient Name: " + patientId + "\nDate: " + date + "\nTime: " + time;

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "potwierdzenia");
            string fileName = "potwierdzenie_" + doctorId + "_" + patientId + ".pdf";
            string filePath = Path.Combine(path, fileName);

       
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

   
            XRect rect = new XRect(40, 40, page.Width - 80, page.Height - 80);
            gfx.DrawString(text, font, XBrushes.Black, rect, XStringFormats.TopLeft);


            document.Save(filePath);


            MessageBox.Show("PDF created successfully!");
        }



    }
}
