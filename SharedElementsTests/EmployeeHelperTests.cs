using SharedElements;
using SharedElements.Helpers;
using Xunit.Sdk;

namespace SharedElementsTests
{
    public class EmployeeHelperTests
    {
        [Fact]
        public void CheckEmialIsValid()
        {
            //Adminstrator filled our for correct
            bool actual = EmployeeHelper.IsEmailAddressCorrect("michal.osyszek@gmail.com","Michal","Osyszek");

            Assert.True(actual);
        }
        [Theory]
        [InlineData("Kacper", "Kowalski", "kowalkacper@jakax.fk")]//Skrócone nazwisko
        [InlineData("Adam", "Ma³ysz", "kowalskiMa³ysz@gmail.com")]//Z³e imie
        [InlineData("Alicja", "Ma³a", "alICJA@google.com")]//brak nazwiska
        [InlineData("Klaudia", "Myszka", "klaudia.myszka123o2.pl")]//brak @
        public void CheckEmailIsNotValid(string name, string lastname, string email)
        {
            //Administrator forget to type "@" in email 
            bool actual = EmployeeHelper.IsEmailAddressCorrect(email, name, lastname);

            Assert.False(actual);
        }
        [Theory]
        [InlineData("2018-01-01")]//Employee is not old enough
        [InlineData("1000-05-25")]//Wrong year in date
        public void EmployeeHasIncorrectDate(string date)
        {
            DateTime dateConverterd = DateTime.Parse(date);
            //Administrator forgot to chnage birth date of employee in form
            bool actual = EmployeeHelper.IsDateOfBirthCorrect(DateTime.Now);

            Assert.False(actual);
        }
        [Fact]
        public void EmployeeHasCorrectDate()
        {
            DateTime data = DateTime.Parse("2001-03-09 20:58:34.253");
            //Administrator forgot to chnage birth date of employee in form
            bool actual = EmployeeHelper.IsDateOfBirthCorrect(data);

            Assert.True(actual);
        }
        [Fact]
        public void PhoneNumberIsCorrect()
        {
            bool actual = EmployeeHelper.IsPhoneNumberCorrect("123456789");

            Assert.True(actual);
        }
        [Theory]
        [InlineData("1234")]//Too short
        [InlineData("959e4w85w")]//letters in phone number
        [InlineData("1112 0489")]//blank space in phone number
        [InlineData("00000000000")]//too long
        public void PhoneNumberIsNotValid(string phone)
        {
            bool actual = EmployeeHelper.IsPhoneNumberCorrect(phone);

            Assert.False(actual);
        }
        
        [Fact]
        public void PeselIsValid()
        {
            string pesel = "01292000833";
            DateTime data = new DateTime(2001, 9, 20);
            string? sex = "M";

            bool actual = EmployeeHelper.IsPeselCorrect(pesel,data,sex);

            Assert.True(actual);
        }
        [Theory]
        [InlineData("98040359396", "1998-04-03", "F")]//Wrong sex female
        [InlineData("98040351460", "1998-04-03", "M")]//Wrong sex male
        [InlineData("98040351459", "1998-01-01", "M")]//Wrong date
        [InlineData("980403", "1998-04-03", "F")]//pesel is too short
        [InlineData("98040351459555", "1998-04-03", "F")]// pesel is too long
        public void PeselIsNotValid(string pesel, string date, string? sex)
        {
            DateTime dateConverted = DateTime.Parse(date); 

            bool actual = EmployeeHelper.IsPeselCorrect(pesel, dateConverted, sex);

            Assert.False(actual);
        }
    }
}