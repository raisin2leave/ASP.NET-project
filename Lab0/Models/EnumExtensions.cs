using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lab0.Models;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum value)
    {
        var member = value.GetType().GetMember(value.ToString()).FirstOrDefault();
        if (member == null) return value.ToString();

        var display = member.GetCustomAttribute<DisplayAttribute>();
        return display?.GetName() ?? value.ToString();
    }
}