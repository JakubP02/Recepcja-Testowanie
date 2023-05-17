using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedElements.Models;
using SharedElements.Helpers;

namespace SharedElements.Models
{
    public class Users
    {
        public int? Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public DateTime ExpirationDateOfUser { get; private set; }
        public Employee AssignedEmployee { get; private set; }
        public bool IsActive { get; private set; }

        public Users(int? id, string username, string password, DateTime expirationDate, Employee employee, bool isActive)
        {
            Id = id;
            Username = username;
            Password = password;
            ExpirationDateOfUser = expirationDate;
            AssignedEmployee = employee;
            IsActive = isActive;
        }
    }


}
