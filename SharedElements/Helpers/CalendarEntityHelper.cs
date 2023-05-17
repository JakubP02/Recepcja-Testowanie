using SharedElements.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedElements.Helpers
{
    public static class CalendarEntityHelper
    {
        public static bool CheckIfBreak(DateTime startHour, DateTime endHour, int actualHour)
        {
            TimeSpan hourDiff = endHour.Subtract(startHour);
            
            int value = (int)hourDiff.TotalHours;
            
            if(value < 4)
            {
                return false;
            }
            if(actualHour %4 == 0) 
            { 
                return true; 
            }

            return false;
        }
        public static int CalculateNumberOfAppointments(DateTime timeFrom, DateTime timeTo)
        {
            timeFrom = new DateTime(timeFrom.Year, timeFrom.Month, timeFrom.Day, timeFrom.Hour,timeFrom.Minute, 0);
            timeTo = new DateTime(timeTo.Year, timeTo.Month, timeTo.Day, timeTo.Hour, timeTo.Minute, 0);

            if (timeFrom.Hour <= 7)
            {
                throw new Exception("Clinic working hours are between 7am and 8pm");
            }
            if (timeTo.Hour > 20)
            {
                throw new Exception("Clinic working hours are between 7am and 8pm");
            }
            if ((timeTo.Hour >= 20 && timeTo.Minute != 0) == true)
            {
                throw new Exception("Clinic working hours are between 7am and 8pm");
            }
            if (timeFrom.Hour == 19)
            {
                if(timeFrom.Minute > 40)
                {
                    throw new Exception("There will be no time for that session");
                }
            }

            int numberOfAppointments = 0;

            TimeSpan timeDiffrence = timeTo.Subtract(timeFrom);

            int minuteValue = (int)timeDiffrence.TotalMinutes;
            if(minuteValue < 20 ){
                throw new Exception("Minimum time of one session is 20 minutes");
            }

            for(int i = 0; i <= minuteValue; i+=20)
            {
                numberOfAppointments++;
            }


            return numberOfAppointments-1;
        }

        public static bool CheckDateAndEntity(DateOnly date)
        {
            SqlConnection conn = DbConnection.GetConnection();
            string query = "SELECT * FROM CalendarEntity WHERE Date = @Date";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
            SqlDataReader? r = null;
            try
            {
                conn.Open();
                r = cmd.ExecuteReader();

                while (r.Read()) 
                {
                    if(r.HasRows == true)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }finally { conn.Close(); }


            return true;
        }
    }
}
