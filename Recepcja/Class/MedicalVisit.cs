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
using System.Net;
using System.Net.Mail;



namespace Recepcja
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

    

        public void SendConfirmation(string office, string date, string time, string email)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("testowanieprzychodnia@interia.pl");
                mail.To.Add(new MailAddress(email)); 
                mail.Subject = "Confirmation of Visit";
                mail.Body = "We would like to remind you of the scheduled appointment, which will be held on the day " +date + " at an hour " + time + " in the Office number: " + office;

                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("testowanieprzychodnia@interia.pl", "Testowanie1@");
                smtp.Host = "poczta.interia.pl";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("The message was sent.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the message: " + ex.Message);
            }
        }






    }
}
