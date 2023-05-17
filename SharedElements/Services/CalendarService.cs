using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedElements.Models;
using SharedElements.DB;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SharedElements.Services
{
    public class CalendarService
    {
        public void DeleteCalendar(Calendar calendar)
        {
            if (calendar.Status != "Inactive")
            {
                throw new Exception("Can't delete calendar because status is not inactive");
            }
            SqlConnection conn = DbConnection.GetConnection();
            string query = "Delete From Calendar WHERE Id = @Id";
            string query2 = "Delete From CalendarEntity WHERE CalendarId = @CalendarId";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd.Parameters.AddWithValue("@Id", calendar.Id);
            cmd2.Parameters.AddWithValue("@CalendarId", calendar.Id);

            try
            {
                conn.Open();
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
            finally { conn.Close(); }
        }
        public void GenerateCalendar(Calendar calendar)
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "INSERT INTO Calendar (Name,Status,Year,Month) VALUES (@Name,@Status,@Year,@Month)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", calendar.Name);
            cmd.Parameters.AddWithValue("@Status", calendar.Status);
            cmd.Parameters.AddWithValue("@Year", calendar.Year);
            cmd.Parameters.AddWithValue("@Month", calendar.Month);

            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
            finally { conn.Close(); }
        }
        public int GenerateCalendarAndReturnId(Calendar calendar)
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "INSERT INTO Calendar (Name,Status,Year,Month) output INSERTED.ID VALUES (@Name,@Status,@Year,@Month)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", calendar.Name);
            cmd.Parameters.AddWithValue("@Status", calendar.Status);
            cmd.Parameters.AddWithValue("@Year", calendar.Year);
            cmd.Parameters.AddWithValue("@Month", calendar.Month);
            int value;
            try
            {
                conn.Open();
                value = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
            finally { conn.Close(); }
            return value;
        }
        public List<Calendar> GetAllCalendars()
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "Select * From Calendar";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader? calendarReader = null;
            List<CalendarEntity> calendarEntities = new();
            List<Calendar> calendars = new();
            try
            {
                conn.Open();
                calendarReader = cmd.ExecuteReader();
                while (calendarReader.Read())
                {
                    int id = calendarReader.GetInt32(0);
                    string name = calendarReader.GetString(1);
                    string active = calendarReader.GetString(2);
                    int year = calendarReader.GetInt32(3);
                    int month = calendarReader.GetInt32(4);
                    //reading calendar entities that match our calendar
                    List<CalendarEntity> list = new();
                    string querySelect = "SELECT * FROM CalendarEntityData WHERE CalendarId = @Id";
                    SqlCommand cmd2 = new SqlCommand(querySelect, conn);
                    cmd2.Parameters.AddWithValue("@Id", id);
                    SqlDataReader? reader2 = null;
                    Employee? employee;
                    try
                    {
                        reader2 = cmd2.ExecuteReader();
                        while (reader2.Read())
                        {
                            int entityId = reader2.GetInt32(0);
                            DateOnly date = DateOnly.FromDateTime(reader2.GetDateTime(1));
                            TimeOnly time = TimeOnly.FromTimeSpan(reader2.GetTimeSpan(2));
                            int employeeID = reader2.GetInt32(3);
                            string firstName = reader2.GetString(4);
                            string lastName = reader2.GetString(5);
                            string pesel = reader2.GetString(6);
                            DateTime birthDate = reader2.GetDateTime(7);
                            Role role = new(reader2.GetInt32(8), reader2.GetString(9));
                            //searching for specializations that are assigned to our employee
                            string query3 = "Select Specializations.Id, Specializations.Name FROM Specializations, SelectedSpecializations  WHERE Specializations.Id = SelectedSpecializations.SpecializationsId and SelectedSpecializations.UserId = @employeeID";
                            SqlCommand command3 = new SqlCommand(query3, conn);
                            command3.Parameters.AddWithValue("employeeID", reader2.GetInt32(3));
                            SqlDataReader? reader3 = null;

                            List<Specialization?> specializacja = new();
                            reader3 = command3.ExecuteReader();
                            while (reader3.Read())
                            {
                                int SpecializationsId = reader3.GetInt32(0);
                                string SpecializationsName = reader3.GetString(1);
                                Specialization spec = new Specialization(SpecializationsId, SpecializationsName);
                                specializacja.Add(spec);
                            }
                            reader3.Close();
                            string? address = reader2[10] as string;
                            string? email = reader2[11] as string;
                            string? phone = reader2[12] as string;
                            char? sex;
                            if (reader2[13] as string is not null)
                            {
                                sex = reader2.GetString(13)[0];
                            }
                            else
                            {
                                sex = null;
                            }
                            bool isActive = reader2.GetBoolean(14);

                            employee = new(employeeID, firstName, lastName, pesel, birthDate, isActive, role,
                                specializacja, address, email, phone, sex);

                            Office office;
                            if (!reader2.IsDBNull(15))
                            {
                                office = new(reader2.GetInt32(15), reader2.GetString(16),
                                    new Specialization(reader2.GetInt32(17), reader2.GetString(18)), reader2.GetBoolean(19),
                                    reader2.GetBoolean(20));
                            }
                            else
                            {
                                office = null;
                            }
                            DateTime creationDate = reader2.GetDateTime(22);
                            CalendarEntity? calendarEntity = null;
                            calendarEntity = new(entityId, date, time, employee, office, creationDate);

                            calendarEntities.Add(calendarEntity);
                        }
                        reader2.Close();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"{ex.Message}");
                    }
                    Calendar calendar = new(id, name, calendarEntities, active, year, month);
                    calendars.Add(calendar);
                }
                calendarReader?.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return calendars;
        }
        
        public void UpdateStatus(int id, string status)
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "UPDATE Calendar SET Status = @Status WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Id", id);
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
    }
}
