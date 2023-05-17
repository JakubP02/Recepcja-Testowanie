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

namespace SharedElements.Helpers
{
    public static class UserHelpers
    {
        public static bool CheckIfEmployeeIsAssigned(Employee employee)
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
                    /*reader.HasRows = true;*/
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
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { conn.Close(); }
            if (i > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckIfDateIsValid(DateTime date)
        {
            if (date.Date < DateTime.Now.Date) 
            {
                return false;
            }

            return true;
        }
    }
}
