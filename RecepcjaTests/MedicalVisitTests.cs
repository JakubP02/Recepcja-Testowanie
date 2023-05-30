using System;
using Recepcja;

namespace RecepcjaTests
{
    public class MedicalVisitTests
    {
        [Fact]
        public void TestDoctorIdProperty()
        {
            MedicalVisit medicalVisit = new MedicalVisit();
            int doctorId = 1234;
            medicalVisit.Doctorid1 = doctorId;
            Assert.Equal(doctorId, medicalVisit.Doctorid1);
        }

        [Fact]
        public void TestPatientIdProperty()
        {
            MedicalVisit medicalVisit = new MedicalVisit();
            int patientId = 5678;
            medicalVisit.Patientid = patientId;
            Assert.Equal(patientId, medicalVisit.Patientid);
        }

        [Fact]
        public void TestDateProperty()
        {
            MedicalVisit medicalVisit = new MedicalVisit();
            DateTime date = new DateTime(2023, 5, 30);
            medicalVisit.Date1 = date;
            Assert.Equal(date, medicalVisit.Date1);
        }

        [Fact]
        public void TestTimeProperty()
        {
            MedicalVisit medicalVisit = new MedicalVisit();
            TimeSpan time = new TimeSpan(14, 0, 0);
            medicalVisit.Time = time;
            Assert.Equal(time, medicalVisit.Time);
        }
    }
}
