using Recepcja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Handling
{
    public partial class Form_add_patient : Form
    {
        private readonly Form_reception_menu _formReceptionMenu;
        public Form_add_patient(Form_reception_menu formReceptionMenu)
        {
            InitializeComponent();
            _formReceptionMenu = formReceptionMenu;
        }

        public static bool IsValidPesel(string pesel, DateTime birth, string sex)
        {
            string dayOfBirth, monthOfBirth;
            char gender;
            bool result = false;

            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            if (sex == "M")
            {
                gender = 'M';
            }
            else
            {
                gender = 'K';
            }



            List<int> peselDigits = new List<int>();
            foreach (char digit in pesel)
            {
                if (char.IsDigit(digit))
                {
                    peselDigits.Add(Convert.ToInt32(digit.ToString()));
                }
                else
                {
                    return result;
                }
            }

            if (peselDigits.Count == 11)
            {
                dayOfBirth = birth.Day.ToString("00");
                monthOfBirth = birth.Month.ToString("00");

                string thirdAndFourthDigit;

                if (birth.Year >= 2000 && birth.Year < 2400)
                {

                    int digitOfHundreds = (birth.Year - 2000) / 100;
                    int toAddToMonth = 0;
                    switch (digitOfHundreds)
                    {
                        case 0:
                            toAddToMonth = 20;
                            break;
                        case 1:
                            toAddToMonth = 40;
                            break;
                        case 2:
                            toAddToMonth = 60;
                            break;
                        case 3:
                            toAddToMonth = 80;
                            break;

                    }
                    thirdAndFourthDigit = (Convert.ToInt32(monthOfBirth) + toAddToMonth).ToString();

                }
                else
                {
                    thirdAndFourthDigit = monthOfBirth;
                }

                string yearAsString = birth.Year.ToString();
                string firstTwoDigits = yearAsString[2].ToString() + yearAsString[3].ToString();

                string year = peselDigits[0].ToString() + peselDigits[1].ToString();
                string month = peselDigits[2].ToString() + peselDigits[3].ToString();
                string day = peselDigits[4].ToString() + peselDigits[5].ToString();

                bool verifyYear = (firstTwoDigits == year);
                bool verifyMonth = (thirdAndFourthDigit == month);
                bool verifyDay = (dayOfBirth == day);
                bool verifyGenderIfMen = (peselDigits[9] % 2 == 1 && gender == 'M');
                bool verifyGenderIfWomen = (peselDigits[9] % 2 == 0 && gender == 'K');

                if (verifyYear && verifyMonth && verifyDay && (verifyGenderIfMen || verifyGenderIfWomen))
                {
                    int checksum = 0;
                    for (int i = 0; i <= weights.Length - 1; i++)
                    {
                        checksum += peselDigits[i] * weights[i];
                    }
                    checksum %= 10;

                    if (checksum != 0)
                    {
                        checksum = 10 - checksum;
                    }

                    if (checksum.ToString() == peselDigits[10].ToString())
                    {
                        result = true;
                    }
                }

            }


            return result;
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_cancel_add_patient_form_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_add_patient_Load(object sender, EventArgs e)
        {

        }

        private void button_add_patient_form_Click(object sender, EventArgs e)
        {


            Patient newPatient = new Patient
            {
                FirstName = textBox_form_add_patient_First_name.Text,
                LastName = textBox_form_add_patient_last_name.Text,
                Birthdate = dateTimePicker_form_add_patient_birthdate.Value.Date,
                Sex = comboBox_gender.Text,
                PhoneNumber = textBox_form_add_patient_phone_number.Text,
                EmailAddress = textBox_form_add_patient_adress_email.Text,
                ResidentialAddress = textBox_form_add_patient_residential_adress.Text,
                Pesel = textBox_form_add_patient_social_security_number.Text
            };





            if (string.IsNullOrEmpty(newPatient.FirstName) ||
                  string.IsNullOrEmpty(newPatient.LastName) ||
                  string.IsNullOrEmpty(newPatient.Birthdate.ToString()) ||
                  string.IsNullOrEmpty(newPatient.PhoneNumber) ||
                  string.IsNullOrEmpty(newPatient.Sex) ||
                  string.IsNullOrEmpty(newPatient.EmailAddress) ||
                  string.IsNullOrEmpty(newPatient.ResidentialAddress) ||
                  string.IsNullOrEmpty(newPatient.Pesel))
             {
                 MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                 return;
             }

             if (!Regex.IsMatch(newPatient.PhoneNumber, @"^\+?[0-9]{3}-?[0-9]{3}-?[0-9]{3}$"))
             {
                 MessageBox.Show("Numer telefonu musi składać się z dziewięciu cyfr.");
                 return;
             }

             if (!Regex.IsMatch(newPatient.EmailAddress, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
             {
                 MessageBox.Show("Adres email jest nieprawidłowy.");
                 return;
             }

             if (string.IsNullOrEmpty(newPatient.Pesel))
             {
                 MessageBox.Show("Numer PESEL nie może być pusty.");
                 return;
             }

             if (newPatient.Pesel.Length != 11)
             {
                 MessageBox.Show("Numer PESEL musi składać się z 11 cyfr.");
                 return;
             }
             if (!IsValidPesel(newPatient.Pesel, DateTime.Parse(dateTimePicker1.Text), comboBox_gender.SelectedItem.ToString()))
             {

                 MessageBox.Show("Pesel nie zgadza się z datą urodzenia!");
                 return;
             }

            


            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "FirstName", "LastName", "BirthDate", "Sex", "PhoneNumber", "EmailAdress", "ResidentialAdress", "Pesel" };
            string[] columnValues = {newPatient.FirstName,newPatient.LastName,newPatient.Birthdate.ToString("yyyy-MM-dd"),newPatient.Sex,newPatient.PhoneNumber,
                newPatient.EmailAddress,newPatient.ResidentialAddress,newPatient.Pesel};
            databaseConnection.InsertDataToDatabase("Patients", columnNames, columnValues);
            this.Hide();
        }

        private void comboBox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
