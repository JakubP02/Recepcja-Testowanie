using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using SharedElements.DB;
using SharedElements.Interfaces;
using SharedElements.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SharedElements.Services;

public class CalendarEntityService : ICalendarEntityService
{
    public List<DateOnly> GetUniqueDates(int calendarId)
    {
        List <DateOnly> list = new();


        SqlConnection conn = DbConnection.GetConnection();
        string query = "SELECT Distinct date FROM CalendarEntity WHERE CalendarId = @CalendarId";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@CalendarId", calendarId);
        SqlDataReader? reader = null;
        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                DateOnly date = DateOnly.FromDateTime(reader.GetDateTime(0));

                list.Add(date);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"{ex.Message}");
        }
        finally
        {
            reader?.Close();
            conn.Close();
        }
        return list;
    }
    public List<CalendarEntity> GetAllCalendarEntities(int? calendarId, DateOnly? selectedDate)
    {
        List<CalendarEntity> calendarEntities = new();
        SqlCommand cmd = new();
        SqlConnection conn = DbConnection.GetConnection();
        string query = "";
        if (calendarId == null) 
        {
            query = "Select * From CalendarEntityData";
            cmd = new SqlCommand(query, conn);
        }
        if(calendarId != null && selectedDate != null)
        {
            query = "Select * From CalendarEntityData WHERE CalendarId = @CalendarId AND Date = @Date";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CalendarId", calendarId);
            cmd.Parameters.AddWithValue("@Date", selectedDate.Value.ToString("yyyy-MM-dd"));
        }
        if (calendarId != null && selectedDate == null)
        {
            query = "Select * From CalendarEntityData WHERE CalendarId = @CalendarId";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CalendarId", calendarId);

        }

        SqlDataReader? reader = null;
        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                DateOnly date = DateOnly.FromDateTime(reader.GetDateTime(1));
                TimeOnly time = TimeOnly.FromTimeSpan(reader.GetTimeSpan(2));
                Employee? employee;
                if (!reader.IsDBNull(3))
                {
                    int employeeID = reader.GetInt32(3);
                    string firstName = reader.GetString(4);
                    string lastName = reader.GetString(5);
                    string pesel = reader.GetString(6);
                    DateTime birthDate = reader.GetDateTime(7);
                    Role role = new(reader.GetInt32(8), reader.GetString(9));

                    string query3 = "Select Specializations.Id, Specializations.Name FROM Specializations, SelectedSpecializations  WHERE Specializations.Id = SelectedSpecializations.SpecializationsId and SelectedSpecializations.UserId = @employeeID";
                    SqlCommand command3 = new SqlCommand(query3, conn);
                    command3.Parameters.AddWithValue("employeeID", reader.GetInt32(3));
                    SqlDataReader reader2 = command3.ExecuteReader();

                    List<Specialization?> specializacja = new();
                    while (reader2.Read())
                    {
                        int SpecializationsId = reader2.GetInt32(0);
                        string SpecializationsName = reader2.GetString(1);
                        Specialization spec = new Specialization(SpecializationsId, SpecializationsName);
                        specializacja.Add(spec);

                    }
                    reader2.Close();

                    string? address = reader[10] as string;
                    string? email = reader[11] as string;
                    string? phone = reader[12] as string;
                    char? sex;
                    if (reader[13] as string is not null)
                    {
                        sex = reader.GetString(13)[0];
                    }
                    else
                    {
                        sex = null;
                    }
                    bool isActive = reader.GetBoolean(14);

                    employee = new(employeeID, firstName, lastName, pesel, birthDate, isActive, role,
                        specializacja ,address, email, phone, sex);
                }
                else
                {
                    employee = null;
                }

                Office office;
                if (!reader.IsDBNull(15))
                {
                    office = new(reader.GetInt32(15), reader.GetString(16),
                        new Specialization(reader.GetInt32(17), reader.GetString(18)), reader.GetBoolean(19),
                        reader.GetBoolean(20));
                }
                else
                {
                    office = null;
                }
                DateTime creationDate = reader.GetDateTime(22);
                CalendarEntity? calendarEntity = null;
                calendarEntity = new(id, date, time, employee, office, creationDate);

                calendarEntities.Add(calendarEntity);
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

        return calendarEntities;
    }

    private bool exists(DateOnly date, TimeOnly time, Employee doctor)
    {
        List<CalendarEntity> calendarEntities = GetAllCalendarEntities(null, null);
        bool alreadyExists = false;
        foreach (CalendarEntity c in calendarEntities)
        {
            if (c.Employee.Id == null)
            {
                continue;
            }
            if(c.Date == date && c.Time == time && c.Employee.Id == doctor.Id)
            {
                alreadyExists = true;
            }
            
        }
        return alreadyExists;
    }
    public bool CheckIfDoctorIsAsigned(DateOnly? date, TimeOnly timeFrom, TimeOnly timeTo, Employee employee)
    {
        int count = 0;
        SqlConnection conn = DbConnection.GetConnection();
        string query = "SELECT * FROM CalendarEntity WHERE Date = @Date AND Time BETWEEN @TimeFrom AND @TimeTo AND DoctorId = @DoctorId";
        SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Date", date.Value.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@TimeFrom", timeFrom.ToString());
        cmd.Parameters.AddWithValue("@TimeTo", timeTo.ToString());
        cmd.Parameters.AddWithValue("@DoctorId", employee.Id);
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
    public bool CheckIfDoctorIsAsignedUpdate(DateOnly? date, TimeOnly timeFrom, TimeOnly timeTo, Employee employee)
    {
        int count = 0;
        SqlConnection conn = DbConnection.GetConnection();
        string query = "SELECT * FROM CalendarEntity WHERE Date = @Date AND Time BETWEEN @TimeFrom AND @TimeTo AND DoctorId != @DoctorId";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Date", date.Value.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@TimeFrom", timeFrom.ToString());
        cmd.Parameters.AddWithValue("@TimeTo", timeTo.ToString());
        cmd.Parameters.AddWithValue("@DoctorId", employee.Id);
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

    public void AddCalendarEntity(CalendarEntity calendarEntity, int calendarId)
    {
        if (exists(calendarEntity.Date, calendarEntity.Time, calendarEntity.Employee))
        {
            throw new Exception("This appointment already exists");
        }
        SqlConnection conn = DbConnection.GetConnection();
        string query =
            "INSERT INTO CalendarEntity (Date, Time, DoctorId, OfficeId, CalendarId, CreationDate) VALUES(@Date,@Time,@DoctorId,@OfficeId,@CalendarId,@CreationDate)";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Date", calendarEntity.Date.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@Time", calendarEntity.Time.ToString("HH:mm"));
        cmd.Parameters.AddWithValue("@DoctorId", calendarEntity.Employee.Id);
        cmd.Parameters.AddWithValue("@OfficeId", calendarEntity.Office.Id);
        cmd.Parameters.AddWithValue("@CalendarId", calendarId);
        cmd.Parameters.AddWithValue("@CreationDate", calendarEntity.CreationDate);
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
    public void UpdateCalendarEntity(CalendarEntity calendarEntity, int calendarId)
    {
        SqlConnection conn = DbConnection.GetConnection();
        
        if (exists(calendarEntity.Date, calendarEntity.Time, calendarEntity.Employee))
        {
            throw new Exception("This appointment already exists");
        }
        string query2 =
            "INSERT INTO CalendarEntity (Date, Time, DoctorId, OfficeId, CalendarId,CreationDate) VALUES(@Date,@Time,@DoctorId,@OfficeId,@CalendarId,@CreationDate)";
        SqlCommand cmd = new SqlCommand(query2, conn);
        cmd.Parameters.AddWithValue("@Date", calendarEntity.Date.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@Time", calendarEntity.Time.ToString("HH:mm"));
        cmd.Parameters.AddWithValue("@DoctorId", calendarEntity.Employee.Id);
        cmd.Parameters.AddWithValue("@OfficeId", calendarEntity.Office.Id);
        cmd.Parameters.AddWithValue("@CalendarId", calendarId);
        cmd.Parameters.AddWithValue("@CreationDate", calendarEntity.CreationDate.ToString("yyyy-MM-dd HH:mm:ss.fff"));

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception($"{ex.Message}");
        }finally { conn.Close(); }
        
    }
    public void DeleteAllEntity(CalendarEntity calendarEntity)
    {
        SqlConnection conn = DbConnection.GetConnection();

        string query = "Delete From CalendarEntity WHERE CreationDate = @CreationDate";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@CreationDate", calendarEntity.CreationDate.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        string dat = calendarEntity.CreationDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

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