using SharedElements.Models;

namespace SharedElements.Interfaces;

public interface ICalendarEntityService
{
    public List<CalendarEntity> GetAllCalendarEntities(int? calendarId, DateOnly? selectedDate);
    public void AddCalendarEntity(CalendarEntity calendarEntity, int calendarId);
    public void UpdateCalendarEntity(CalendarEntity calendarEntity, int calendarId);
}