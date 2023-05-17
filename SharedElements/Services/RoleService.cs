using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedElements.DB;
using SharedElements.Interfaces;
using SharedElements.Models;

namespace SharedElements.Services
{
    public class RoleService : IRoleService
    {
        public void AddRole(string roleName)
        {
            if (exists(roleName))
            {
                throw new Exception("Such role already exists");
                return;
            }
            SqlConnection connection = DbConnection.GetConnection();
            string query = "INSERT INTO Roles (Name) VALUES (@Name)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", roleName);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { connection.Close(); }
        }

        public void DeleteRole(int roleId)
        {
            EmployeeService employeeService = new();
            List<Employee> employees = employeeService.GetAllEmployees();
            bool isAssigned = false;
            foreach (Employee employee in employees)
            {
                if (employee.AssignedRole.Id == roleId)
                {
                    isAssigned = true;
                }
            }

            if (isAssigned)
            {
                throw new Exception("Cannot delete role that is assigned to someone!");
            }

            SqlConnection connection = DbConnection.GetConnection();
            string query = "DELETE FROM Roles WHERE Id = @RoleId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RoleId", roleId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { connection.Close(); }
        }

        public List<Role> GetAllRoles()
        {
            List<Role> roles = new();
            SqlConnection connection = DbConnection.GetConnection();
            string query = "SELECT * FROM Roles";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader? reader = null;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int roleID = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    Role role = new(roleID, name);
                    roles.Add(role);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally
            {
                reader?.Close();
                connection.Close();
            }
            return roles;
        }

        public Role GetRoleById(int roleId)
        {
            SqlConnection connection = DbConnection.GetConnection();
            string query = "SELECT * FROM Roles WHERE Id = @RoleId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RoleId", roleId);
            SqlDataReader reader = command.ExecuteReader();
            Role? role = null;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int roleID = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    role = new(roleID, name);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally
            {
                reader?.Close();
                connection.Close();
            }

            return role;
        }

        public void UpdateRole(Role role)
        {
            if (exists(role.Name))
            {
                throw new Exception("Such role already exists");
                return;
            }
            SqlConnection connection = DbConnection.GetConnection();
            string query = "UPDATE Roles SET Name = @Name WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", role.Name);
            command.Parameters.AddWithValue("@Id", role.Id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { connection.Close(); }
        }

        private bool exists(string name)
        {
            List<Role> roles = GetAllRoles();
            bool alreadyExist = false;
            foreach (Role role in roles)
            {
                if (role.Name == name)
                {
                    alreadyExist = true;
                }
            }

            return alreadyExist;
        }
    }
}
