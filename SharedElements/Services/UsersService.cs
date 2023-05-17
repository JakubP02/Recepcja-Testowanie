using SharedElements.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedElements.DB;
using SharedElements.Interfaces;
using System.Data;
using System.Runtime.CompilerServices;

namespace SharedElements.Services
{
    public class UsersService : IUsersService
    {
        public List<Users> GetAllUsers()
        {
            List<Users> users = new();
            Employee employee = null;
            SqlConnection conn = DbConnection.GetConnection();
            string query = "SELECT * FROM [UserData2]";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader? reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    string username = reader.GetString(1);
                    string password = reader.GetString(2);
                    DateTime expirationDate = reader.GetDateTime(3);
                    int? employeeId = reader.GetInt32(4);
                    bool isActive = reader.GetBoolean(5);
                    EmployeeService employeeService = new EmployeeService();
                    List<Employee> employees = employeeService.GetAllEmployees();
                    foreach(Employee emp in employees) 
                    { 
                        if(emp.Id == employeeId)
                        {
                            employee = emp;
                        }
                    }
                    Users user;
                    try
                    {
                        user = new(userId, username, password, expirationDate, employee, isActive);
                    }
                    catch (Exception e)
                    {
                        throw new Exception($"Invalid user data in database: {e.Message}");
                    }
                    users.Add(user);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally
            {
                reader?.Close();
                conn.Close();
            }
            return users;
        }
        public void AddUser(Users user) 
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "INSERT INTO [User] (employeeId,username, password,active, expirationDate) VALUES (@AssignedEmployee,@username,@password,@Active,@ExpirationDate)";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@AssignedEmployee", user.AssignedEmployee.Id);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@Active", user.IsActive);
            cmd.Parameters.AddWithValue("@ExpirationDate", user.ExpirationDateOfUser);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { conn.Close(); }
        }
        public void UpdateUser(Users user) 
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "UPDATE [User] Set username = @Username, password = @Password, expirationDate = @ExpirationDate, employeeId = @AssignedEmployee WHERE Id = @UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@ExpirationDate", user.ExpirationDateOfUser);
            cmd.Parameters.AddWithValue("@AssignedEmployee", user.AssignedEmployee.Id);
            cmd.Parameters.AddWithValue("@UserId", user.Id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { conn.Close(); }
        }
        public void ChangeUserStatus(int userId, bool active)
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "UPDATE [User] SET active = @Active WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Active", active);
            cmd.Parameters.AddWithValue("@Id", userId);
            try
            {   
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { conn.Close(); }
        }
        public Boolean CheckIfEmployeeIsAssigned(Employee employee)
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "SELECT * FROM [User] WHERE employeeId = @EmployeeId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
            SqlDataReader? reader = null;
            int i = 0;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    if (i <= 0)
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { conn.Close(); }
            if(i > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void DeactivateUser(Employee employee)
        {
            if(employee.IsActive == false)
            {
                return;
            }
            SqlConnection conn = DbConnection.GetConnection();
            string query = "SELECT Id FROM [User] WHERE employeeId = @EmployeeId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
            SqlDataReader? reader = null;
            int i = 0;
            int? userId = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    if (i <= 0)
                    {
                        userId = reader.GetInt32(0);
                        i++;
                    }
                }
                if (i > 0)
                {
                    ChangeUserStatus((int)userId, false);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { conn.Close(); }
        }
    }
}
