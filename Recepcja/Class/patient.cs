using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_handling
{
    internal class Patient
    {
    
        private string _firstName;
        private string _lastName;
        private DateTime _birthdate;
        private string _sex;
        private string _phoneNumber;
        private string _emailAddress;
        private string _residentialAddress;
        private string _pesel;
        private string _status;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime Birthdate { get => _birthdate; set => _birthdate = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string EmailAddress { get => _emailAddress; set => _emailAddress = value; }
        public string ResidentialAddress { get => _residentialAddress; set => _residentialAddress = value; }
        public string Pesel { get => _pesel; set => _pesel = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
