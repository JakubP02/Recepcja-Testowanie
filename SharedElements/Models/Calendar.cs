namespace SharedElements.Models;

public class Calendar
{
    public int? Id { get; private set; }
    public string Name { get; private set; }
    public List<CalendarEntity> CalendarEntities { get; private set; }
    public string Status { get; private set; }
    public int Year { get; private set; }
    public int Month { get; private set; }

    public Calendar(int? id, string name, List<CalendarEntity> calendarEntities, string status, int year, int month)
    {
        Id = id;
        Name = name;
        CalendarEntities = calendarEntities;
        Status = status;
        Year = year;
        Month = month;
    }
}