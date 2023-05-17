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

namespace SharedElements.Services
{
    public class EmployeeService : IEmployeeService
    {
        private bool exists(string pesel)
        {
            List<Employee> empList = GetAllEmployees();
            bool alreadyExist = false;
            foreach (Employee e in empList)
            {
                if (e.PESEL == pesel)
                {
                    alreadyExist = true;
                }
            }

            return alreadyExist;
        }
        public void AddEmployee(Employee employee)
        {
            if (exists(employee.PESEL))
            {
                throw new Exception("This PESEL number already exists");
            }
            SqlConnection connection = DbConnection.GetConnection();
            string query = 
                "INSERT INTO Employees (FirstName, LastName, Pesel, BirthDate, Role, Address, Email, Phone, Sex, Active) " +
                           "VALUES (@FirstName, @LastName, @Pesel, @BirthDate, @Role, @Address, @Email, @Phone, @Sex, @Active)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@Pesel", employee.PESEL);
            command.Parameters.AddWithValue("@BirthDate", employee.DateOfBirth);
            command.Parameters.AddWithValue("@Role", employee.AssignedRole.Id);
            object addr = DBNull.Value;
            if (employee.CorrespondenceAddress != null)
            {
                addr = employee.CorrespondenceAddress;
                addr = addr.ToString();
            }
            command.Parameters.AddWithValue("@Address", addr);
            object email = DBNull.Value;
            if (employee.EmailAddress != null)
            {
                email = employee.EmailAddress;
                email = email.ToString();
            }
            command.Parameters.AddWithValue("@Email", email);
            object phone = DBNull.Value;
            if (employee.PhoneNumber != null)
            {
                phone = employee.PhoneNumber;
                phone = phone.ToString();
            }
            command.Parameters.AddWithValue("@Phone", phone);
            object sex = DBNull.Value;
            if (employee.Sex != null)
            {
                sex = employee.Sex;
                sex = Convert.ToChar(sex);
            }
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Active", employee.IsActive);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}");
            }
            finally{connection.Close();}

            foreach(Specialization speciali in employee.ListOfSpecialization) {
                SqlConnection connection2 = DbConnection.GetConnection();
                string query2 = "INSERT INTO SelectedSpecializations (UserId, SpecializationsId) " +
                               "VALUES ((Select id from Employees where Pesel = @PESEL), @SpecializationsId)";
                SqlCommand command2 = new SqlCommand(query2, connection2);
                command2.Parameters.AddWithValue("@PESEL", employee.PESEL);
                command2.Parameters.AddWithValue("@SpecializationsId", speciali.Id);
                connection2.Open();
                command2.ExecuteNonQuery();
                connection2.Close();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            SqlConnection connection = DbConnection.GetConnection();
            string query = "DELETE FROM Employees WHERE Id = @EmployeeId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeId", employeeId);
            
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

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new();
            SqlConnection connection = DbConnection.GetConnection();
            string query = "SELECT * FROM EmployeesData";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader? reader = null;
            SqlDataReader? reader2 = null;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int employeeID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string pesel = reader.GetString(3);
                    DateTime birthDate = reader.GetDateTime(4);
                    Role role = new(reader.GetInt32(5), reader.GetString(6));
/*                    Specialization? specialization;
                    if (reader[7] as int? is not null)
                    {
                        specialization = new(reader.GetInt32(7), reader.GetString(8));
                    }
                    else
                    {
                        specialization = null;
                    }*/

                    string? address = reader[7] as string;
                    string? email = reader[8] as string;
                    string? phone = reader[9] as string;
                    char? sex;
                    if (reader[10] as string is not null)
                    {
                        sex = reader.GetString(10)[0];
                    }
                    else
                    {
                        sex = null;
                    }
                    bool isActive = reader.GetBoolean(11);

                    Employee employee;
                    SqlConnection connection3 = DbConnection.GetConnection();
                    string query3 = "Select Specializations.Id, Specializations.Name FROM Specializations, SelectedSpecializations  WHERE Specializations.Id = SelectedSpecializations.SpecializationsId and SelectedSpecializations.UserId = @employeeID";
                    SqlCommand command3 = new SqlCommand(query3, connection3);
                    command3.Parameters.AddWithValue("employeeID", employeeID);
                    connection3.Open();
                    reader2 = command3.ExecuteReader();

                    List<Specialization?> specializacja = new();
                    while (reader2.Read())
                    {
                        int SpecializationsId = reader2.GetInt32(0);
                        string SpecializationsName = reader2.GetString(1);
                        Specialization spec = new Specialization(SpecializationsId, SpecializationsName);
                        specializacja.Add(spec);

                    }
                    connection3.Close();
                        try
                    {
                        employee = new(employeeID, firstName, lastName, pesel, birthDate, isActive, role,
                            specializacja ,address, email, phone, sex);
                    }
                    catch (Exception e)
                    {
                        throw new Exception($"Invalid user data in database: {e.Message}");
                    }
                    employees.Add(employee);
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
            return employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
/*            SqlConnection connection = DbConnection.GetConnection();
            string query = "SELECT * FROM Employees WHERE Id = @EmployeeId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeId", employeeId);
            SqlDataReader? reader = null;*/
            Employee? employee = null;
            /*try
            {
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int employeeID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string pesel = reader.GetString(3);
                    DateTime birthDate = reader.GetDateTime(4);
                    Role role = new(reader.GetInt32(5), reader.GetString(6));
                    Specialization? specialization;
                    if (reader[7] as int? is not null)
                    {
                        specialization = new(reader.GetInt32(7), reader.GetString(8));
                    }
                    else
                    {
                        specialization = null;
                    }

                    string? address = reader[9] as string;
                    string? email = reader[10] as string;
                    string? phone = reader[11] as string;
                    char? sex;
                    if (reader[12] as string is not null)
                    {
                        sex = reader.GetString(12)[0];
                    }
                    else
                    {
                        sex = null;
                    }
                    bool isActive = reader.GetBoolean(13);

                    try
                    {
                        employee = new(employeeID, firstName, lastName, pesel, birthDate, isActive, role,
                            specialization, address, email, phone, sex);
                    }
                    catch (Exception e)
                    {
                        throw new Exception($"Invalid user data in database: {e.Message}");
                    }
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
            }*/

            return employee;
        }

        public void UpdateEmployee(Employee employee)
        {
            SqlConnection connection = DbConnection.GetConnection();

            string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Pesel = @Pesel, BirthDate = @BirthDate, Role = @Role, " +
                           "Address = @Address, Email = @Email, Phone = @Phone, Sex = @Sex WHERE Id = @Id";
            string deleteSpecialization = "DELETE FROM [SelectedSpecializations] WHERE UserId = @DeleteId";
            string querySpecialization = "Insert into SelectedSpecializations VALUES (@UserId, @SpecializationId)";

            SqlCommand command = new SqlCommand(query, connection);
            SqlCommand commandDelete = new SqlCommand(deleteSpecialization, connection);
            SqlCommand commandSpecialization = new SqlCommand(querySpecialization, connection);

            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@Pesel", employee.PESEL);
            command.Parameters.AddWithValue("@BirthDate", employee.DateOfBirth);
            command.Parameters.AddWithValue("@Role", employee.AssignedRole.Id);
            command.Parameters.AddWithValue("@Id", employee.Id);

            commandDelete.Parameters.AddWithValue("@DeleteId", employee.Id);

/*            object spec = DBNull.Value;
            if (employee.AssignedSpecialization != null)
            {
                spec = employee.AssignedSpecialization.Id;
                spec = Convert.ToInt32(spec);
            }*/
/*            command.Parameters.AddWithValue("@Specialization", spec);*/
            object addr = DBNull.Value;
            if (employee.CorrespondenceAddress != null)
            {
                addr = employee.CorrespondenceAddress;
                addr = addr.ToString();
            }
            command.Parameters.AddWithValue("@Address", addr);
            object email = DBNull.Value;
            if (employee.EmailAddress != null)
            {
                email = employee.EmailAddress;
                email = email.ToString();
            }
            command.Parameters.AddWithValue("@Email", email);
            object phone = DBNull.Value;
            if (employee.PhoneNumber != null)
            {
                phone = employee.PhoneNumber;
                phone = phone.ToString();
            }
            command.Parameters.AddWithValue("@Phone", phone);
            object sex = DBNull.Value;
            if (employee.Sex != null)
            {
                sex = employee.Sex;
                sex = Convert.ToChar(sex);
            }
            command.Parameters.AddWithValue("@Sex", sex);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                commandDelete.ExecuteNonQuery();
                foreach(Specialization spec in employee.ListOfSpecialization)
                {
                    commandSpecialization.Parameters.AddWithValue("@UserId", employee.Id);
                    commandSpecialization.Parameters.AddWithValue("@SpecializationId", spec.Id);
                    commandSpecialization.ExecuteNonQuery();
                    commandSpecialization.Parameters.Clear();
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Database error: {e.Message}");
            }
            finally { connection.Close(); }
        }

        public void ChangeIsActiveStatus(int employeeId, bool active)
        {
            SqlConnection connection = DbConnection.GetConnection();
            string query = "UPDATE Employees SET Active = @Active WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Active", active);
            command.Parameters.AddWithValue("@Id", employeeId);
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
    }
}
