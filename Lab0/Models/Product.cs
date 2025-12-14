using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab0.Models;

public class Product
{
    [HiddenInput]
    public int Id { get; set; }

    [Required(ErrorMessage = "Podaj nazwę produktu")]
    [Display(Name = "Nazwa produktu")]
    public string Name { get; set; }

    [Required]
    [Range(0.01, 100000)]
    [Display(Name = "Cena")]
    public decimal Price { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data produkcji")]
    public DateTime ProductionDate { get; set; }

    [StringLength(500)]
    [Display(Name = "Opis")]
    public string? Description { get; set; }

    [Display(Name = "Kategoria")]
    public ProductCategory Category { get; set; }

    [HiddenInput]
    public DateTime Created { get; set; }
    
    [HiddenInput]
    public int ManufacturerId { get; set; }

    [ValidateNever]
    public List<SelectListItem> Manufacturers { get; set; } = new();
    
    [Display(Name = "Producent")]
    public string? ManufacturerName { get; set; }
}