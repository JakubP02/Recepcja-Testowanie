using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using SharedElements.DB;
using SharedElements.Interfaces;
using SharedElements.Models;

namespace SharedElements.Services
{
    public class SpecializationService : ISpecializationService
    {
        public void AddSpecialization(string specializationName)
        {
            if (exists(specializationName))
            {
                throw new Exception("Specialization name is not unique");
                return;
            }
            SqlConnection connection = DbConnection.GetConnection();
            string query = "INSERT INTO Specializations ([Name]) VALUES (@Name)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", specializationName);
            
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally{connection.Close();}
        }

        public void DeleteSpecialization(int specializationId)
        {
            EmployeeService employeeService = new();
            List<Employee> employees = employeeService.GetAllEmployees();
            bool isAssigned = false;
            foreach (Employee employee in employees)
            {
                foreach(Specialization spec in employee.ListOfSpecialization)
                if (employee.ListOfSpecialization is not null && spec.Id == specializationId)
                {
                    isAssigned = true;
                }
            }

            if (isAssigned)
            {
                throw new Exception("This specialization is assigned to some doctor and can’t be removed");
            }

            SqlConnection connection = DbConnection.GetConnection();
            string query = "DELETE FROM Specializations WHERE Id = @SpecializationId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SpecializationId", specializationId);
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

        public List<Specialization> GetAllSpecializations()
        {
            List<Specialization> specializations = new();
            SqlConnection connection = DbConnection.GetConnection();
            string query = "SELECT * FROM Specializations";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int specializationID = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    Specialization specialization= new(specializationID, name);
                    specializations.Add(specialization);
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

            return specializations;
        }

        public Specialization GetSpecializationById(int specializationId)
        {
            SqlConnection connection = DbConnection.GetConnection();
            string query = "SELECT * FROM Specializations WHERE Id = @SpecializationId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RoleId", specializationId);
            SqlDataReader reader = command.ExecuteReader();
            Specialization? specialization = null;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int specializationID = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    specialization = new(specializationID, name);
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

            return specialization;
        }

        public void UpdateSpecialization(Specialization specialization)
        {
            if (exists(specialization.Name))
            {
                throw new Exception("Such specialization already exists");
                return;
            }
            SqlConnection connection = DbConnection.GetConnection();
            string query = "UPDATE Specializations SET Name = @Name WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", specialization.Name);
            command.Parameters.AddWithValue("@Id", specialization.Id);
            
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally{connection.Close();}
        }

        private bool exists(string name)
        {
            List<Specialization> specializations = GetAllSpecializations();
            bool alreadyExist = false;
            foreach (Specialization specialization in specializations)
            {
                if (specialization.Name == name)
                {
                    alreadyExist = true;
                }
            }

            return alreadyExist;
        }
    }
}
