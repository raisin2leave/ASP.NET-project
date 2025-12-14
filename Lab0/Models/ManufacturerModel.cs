using System.ComponentModel.DataAnnotations;

namespace Lab0.Models;

public class ManufacturerModel
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Nazwa producenta")]
    public string Name { get; set; }
}