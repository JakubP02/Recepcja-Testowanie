using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedElements.Models;
using SharedElements.DB;

namespace SharedElements.Services
{
    public class OfficeService
    {
        public void DeleteOffice(Office office)
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "Delete from Offices WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Id", office.Id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Database error: {ex.Message}");
            }
            finally { conn.Close(); }
        }
        public void UpdateOffice(Office office)
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "Update Offices SET Number = @Number, IdSpecialization = @Specialization, Active = @IsActive, IsGeneral = @IsGeneral WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", office.Id);
            cmd.Parameters.AddWithValue("@Number", office.Number);
            cmd.Parameters.AddWithValue("@Specialization", office.Specialization.Id);
            cmd.Parameters.AddWithValue("@IsActive", office.IsActive);
            cmd.Parameters.AddWithValue("@IsGeneral", office.IsGeneral);

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
        public void ChangeIsActiveStatus(int officeId, bool active)
        {
            SqlConnection connection = DbConnection.GetConnection();
            string query = "UPDATE Offices SET Active = @Active WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Active", active);
            command.Parameters.AddWithValue("@Id", officeId);
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
        private bool exists(string number)
        {
            List<Office> officeList = GetOfficeList();
            bool alreadyExists = false;
            foreach (Office o in officeList)
            {
                if(o.Number == number)
                {
                    alreadyExists = true;
                }
            }
            return alreadyExists;
        }
        public void AddOffice(Office office)
        {
            if (exists(office.Number))
            {
                throw new Exception("This office already exists");
            }
            SqlConnection conn = DbConnection.GetConnection();
            string query = "INSERT INTO Offices (number,IdSpecialization, Active, IsGeneral) VALUES(@Number,@Specialization,@IsActive,@IsGeneral)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Number", office.Number);
            cmd.Parameters.AddWithValue("@Specialization", office.Specialization.Id);
            cmd.Parameters.AddWithValue("@IsActive", office.IsActive);
            cmd.Parameters.AddWithValue("@IsGeneral", office.IsGeneral);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
            finally { conn.Close(); }
        }
        public List<Office> GetOfficeList()
        {
            List<Office> offices = new();

            SqlConnection conn = DbConnection.GetConnection();
            string query = "Select * From OfficeData";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader? reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int? id = reader.GetInt32(0);
                    string number = reader.GetString(1);
                    Specialization spec = new(reader.GetInt32(2),reader.GetString(3));
                    bool IsActive = reader.GetBoolean(4);
                    bool IsGeneral = reader.GetBoolean(5);

                    Office? office = null;
                    office = new(id,number,spec, IsActive, IsGeneral);

                    offices.Add(office);
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

            return offices;
        }
        public bool GetFreeOffices(DateOnly? date, TimeOnly timeFrom, TimeOnly timeTo, Office office)
        {
            int count = 0;
            SqlConnection conn = DbConnection.GetConnection();
            string query = "SELECT * FROM CalendarEntity WHERE Date = @Date AND Time BETWEEN @TimeFrom AND @TimeTo AND OfficeId = @OfficeId";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@Date", date.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TimeFrom", timeFrom.ToString());
            cmd.Parameters.AddWithValue("@TimeTo", timeTo.ToString());
            cmd.Parameters.AddWithValue("@OfficeId", office.Id);
            SqlDataReader? reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(count <= 0)
                    {
                        count = count + 1;
                        break;
                    }
                    
                }
            }
            catch(Exception e)
            {
                throw new Exception($"{e.Message}");
            }
            finally { conn.Close(); }

            if (count > 0)
            {
                return false;
            }
            return true;
        }
        public bool CheckIfOfficeIsStillAvailable(DateOnly? date, TimeOnly timeFrom, TimeOnly timeTo, Office office, CalendarEntity entity)
        {
            int count = 0;
            SqlConnection conn = DbConnection.GetConnection();
            string query = "SELECT * FROM CalendarEntity WHERE Date = @Date AND Time BETWEEN @TimeFrom AND @TimeTo AND OfficeId = @OfficeId AND DoctorId != @DoctorId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Date", date.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TimeFrom", timeFrom.ToString());
            cmd.Parameters.AddWithValue("@TimeTo", timeTo.ToString());
            cmd.Parameters.AddWithValue("@OfficeId", office.Id);
            cmd.Parameters.AddWithValue("@DoctorId", entity.Employee.Id);
            SqlDataReader? reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (count <= 0)
                    {
                        count = count + 1;
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}");
            }
            finally { conn.Close(); }

            if (count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
