namespace SharedElements.Models;

public class CalendarEntity
{
    public int? Id { get; private set; }
    public DateOnly Date { get; private set; }
    public TimeOnly Time { get; private set; }
    public Employee? Employee { get; private set; }
    public Office? Office { get; private set; }
    public DateTime CreationDate { get; private set; }

    public CalendarEntity(int? id, DateOnly date, TimeOnly time, Employee? employee, Office? office, DateTime creationDate)
    {
        Id = id;
        Date = date;
        Time = time;
        Employee = employee;
        Office = office;
        CreationDate = creationDate;
    }
}