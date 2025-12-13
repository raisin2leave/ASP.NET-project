namespace Lab0.Models;

public class CurrentDateTimeProvider : IDateTimeProvider
{
    public DateTime Now() => DateTime.Now;
}