using System.ComponentModel.DataAnnotations;

namespace Lab0.Models;

public enum ProductCategory
{
    [Display(Name = "Niska")]
    Low = 1,

    [Display(Name = "Normalna")]
    Normal = 2,

    [Display(Name = "Wysoka")]
    High = 3,

    [Display(Name = "Pilna")]
    Urgent = 4
}