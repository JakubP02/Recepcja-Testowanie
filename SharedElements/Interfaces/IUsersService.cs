using SharedElements.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedElements.Interfaces
{
    public interface IUsersService
    {
        public List<Users> GetAllUsers();
        public void AddUser(Users user);
        public void UpdateUser(Users user);
        public void ChangeUserStatus(int userId, bool userStatus);
    }
}
