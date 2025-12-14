using System.ComponentModel.DataAnnotations;

namespace Lab0.Models;

public enum ProductCategory
{
    [Display(Name = "Spożywczy")]
    Food = 1,

    [Display(Name = "Elektronika")]
    Electronics = 2,

    [Display(Name = "Odzież")]
    Clothes = 3,

    [Display(Name = "Inne")]
    Other = 4
}