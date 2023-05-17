using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace SharedElements.Helpers
{
    public static class EmployeeHelper
    {
        public static bool IsPeselCorrect(string pesel, DateTime birth, string? sex)
        {
            Regex regex = new Regex(@"[0-9]{11}");
            Match match = regex.Match(pesel);
            if (!match.Success)
            {
                throw new Exception("Entered user PESEL is not exactly 11 characters long");
            }

            if (pesel.Substring(0, 2) != birth.Year.ToString("D2").Substring(2, 2))
            {
                throw new Exception("PESEL and date of birth do not match");
            }

            string correctMonth;
            if (int.Parse(pesel[2].ToString()) > 1)
            {
                correctMonth = (int.Parse(pesel[2].ToString()) - 2).ToString() + pesel[3].ToString();
            }
            else
            {
                correctMonth = pesel.Substring(2, 2);
            }
            if (correctMonth != birth.Month.ToString("D2"))
            {
                throw new Exception("PESEL and date of birth do not match");
            }

            if (pesel.Substring(4, 2) != birth.Day.ToString("D2"))
            {
                throw new Exception("PESEL and date of birth do not match");
            }

            List<char> maleIndicators = new() { '1', '3', '5', '7', '9' };
            List<char> femaleIndicators = new() { '0', '2', '4', '6', '8' };
            if (sex is not null)
            {
                if (sex[0] == 'M' && !maleIndicators.Contains(pesel[9]))
                {
                    throw new Exception("PESEL and sex do not match");
                }

                if (sex[0] == 'F' && !femaleIndicators.Contains(pesel[9]))
                {
                    throw new Exception("PESEL and sex do not match");
                }
            }

            return true;
        }

        public static bool IsDateOfBirthCorrect(DateTime date)
        {
            if (date >= DateTime.Now.Date)
            {
                throw new Exception("Incorrect birth date");
            }
            int age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.Month < date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day))
            {
                age--;
            }
            if (age is < 18 or > 120)
            {
                throw new Exception("Incorrect birth date");
            }
            return true;
        }

        public static bool IsEmailAddressCorrect(string email, string firstName, string lastName)
        {
            if (!email.Contains("@"))
            {
                throw new Exception("Incorrect E-mail");
            }
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regex.IsMatch(email))
            {
                throw new Exception("Incorrect E-mail");
            }
            regex = new Regex(@"\.[a-zA-Z]{2,}$");
            if (!regex.IsMatch(email))
            {
                throw new Exception("Incorrect E-mail");
            }
            if (!(email.ToLower().Contains(firstName.ToLower()) && email.ToLower().Contains(lastName.ToLower())))
            {
                throw new Exception("E-mail does not contain the recipient's name");
            }

            return true;
        }

        public static bool IsPhoneNumberCorrect(string phoneNumber)
        {
            var regex = new Regex(@"^\d{9}$");
            if (!regex.IsMatch(phoneNumber))
            {
                throw new Exception("Incorrect phone number");
            }

            return true;
        }
        public static bool NameCheck(string name,string lastname)
        {
            if (name == string.Empty) 
            {
                throw new Exception("First name can't be empty");
            }
            if(lastname == string.Empty)
            {
                throw new Exception("Last name can't be empty");
            }
            var regex = new Regex("^[\\p{L} \\.'\\-]+$");
            if (!regex.IsMatch(name) || !regex.IsMatch(lastname)) 
            {
                return false;
            }
            return true;
        }
    }
}
