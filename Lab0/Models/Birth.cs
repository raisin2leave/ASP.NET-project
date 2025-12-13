namespace Lab0.Models;

public class Birth
{
    public string Name { get; set; }
    public DateTime? Date { get; set; }

    public bool IsValid()
    {
        return !string.IsNullOrEmpty(Name)
               && Date != null
               && Date < DateTime.Now;
    }

    public int GetAge()
    {
        var today = DateTime.Today;
        int age = today.Year - Date.Value.Year;

        if (Date.Value.Date > today.AddYears(-age))
            age--;

        return age;
    }
}
