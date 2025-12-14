namespace Lab0.Models.Providers;

public class CurrentDateTimeProvider : IDateTimeProvider
{
    public DateTime Now() => DateTime.Now;
}