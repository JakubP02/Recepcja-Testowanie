using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedElements.Models;

namespace SharedElements.Interfaces
{
    public interface IRoleService
    {
        public List<Role> GetAllRoles();
        public Role GetRoleById(int roleId);
        public void AddRole(string roleName);
        public void UpdateRole(Role role);
        public void DeleteRole(int roleId);
    }
}
