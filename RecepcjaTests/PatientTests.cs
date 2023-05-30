using System;
using Patient_Handling;
using Recepcja;
namespace RecepcjaTests
{
    public class PatientTests
    {
    [Fact]
        public void TestIfPeselIsInvalid()
        {
            DateTime birth = new DateTime(1980, 1, 1);
            bool result = Form_add_patient.IsValidPesel("12345678901", birth, "M");
            Assert.False(result);
        }

        [Fact]
        public void TestIfPeselIsValid()
        {
            DateTime birth = new DateTime(1980, 1, 1);
            bool result = Form_add_patient.IsValidPesel("80010112340", birth, "K");
            Assert.True(result);
        }

        [Fact]
        public void TestIfPeselHasWrongSex()
        {
            DateTime birth = new DateTime(1980, 1, 1);
            bool result = Form_add_patient.IsValidPesel("80010112345", birth, "X");
            Assert.False(result);
        }

        [Fact]
        public void TestIfPeselHasWrongBirthDate()
        {
            DateTime birth = new DateTime(2023, 4, 26);
            bool result = Form_add_patient.IsValidPesel("80010112345", birth, "M");
            Assert.False(result);
        }

        [Fact]
        public void TestIfPeselHasInvalidMonth()
        {
            DateTime birth = new DateTime(1980, 2, 1);
            bool result = Form_add_patient.IsValidPesel("80020112345", birth, "M");
            Assert.False(result);
        }

        [Fact]
        public void TestIfPeselHasInvalidDay()
        {
            DateTime birth = new DateTime(1980, 1, 2);
            bool result = Form_add_patient.IsValidPesel("80010112345", birth, "M");
            Assert.False(result);
        }
        [Fact]
        public void TestFirstNameProperty()
        {
            Patient patient = new Patient();
            string name = "John";
            patient.FirstName = name;
            Assert.Equal(name, patient.FirstName);
        }

        [Fact]
        public void TestLastNameProperty()
        {
            Patient patient = new Patient();
            string name = "Doe";
            patient.LastName = name;
            Assert.Equal(name, patient.LastName);
        }

        [Fact]
        public void TestBirthdateProperty()
        {
            Patient patient = new Patient();
            DateTime birthdate = new DateTime(1980, 1, 1);
            patient.Birthdate = birthdate;
            Assert.Equal(birthdate, patient.Birthdate);
        }

        [Fact]
        public void TestSexProperty()
        {
            Patient patient = new Patient();
            string sex = "M";
            patient.Sex = sex;
            Assert.Equal(sex, patient.Sex);
        }

        [Fact]
        public void TestPhoneNumberProperty()
        {
            Patient patient = new Patient();
            string phoneNumber = "+123456789";
            patient.PhoneNumber = phoneNumber;
            Assert.Equal(phoneNumber, patient.PhoneNumber);
        }

        [Fact]
        public void TestEmailAddressProperty()
        {
            Patient patient = new Patient();
            string email = "test@example.com";
            patient.EmailAddress = email;
            Assert.Equal(email, patient.EmailAddress);
        }

        [Fact]
        public void TestResidentialAddressProperty()
        {
            Patient patient = new Patient();
            string address = "123 Main St";
            patient.ResidentialAddress = address;
            Assert.Equal(address, patient.ResidentialAddress);
        }

        [Fact]
        public void TestPeselProperty()
        {
            Patient patient = new Patient();
            string pesel = "12345678901";
            patient.Pesel = pesel;
            Assert.Equal(pesel, patient.Pesel);
        }

        [Fact]
        public void TestStatusProperty()
        {
            Patient patient = new Patient();
            string status = "Active";
            patient.Status = status;
            Assert.Equal(status, patient.Status);
        }
    }
}