using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab0.Models;

public class Product
{
    [HiddenInput]
    public int Id { get; set; }

    [Required(ErrorMessage = "Podaj nazwę produktu")]
    [StringLength(100, ErrorMessage = "Nazwa max 100 znaków")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Podaj cenę")]
    [Range(0.01, 100000, ErrorMessage = "Cena musi być większa od 0")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Podaj producenta")]
    public string Manufacturer { get; set; }

    [Required(ErrorMessage = "Podaj datę produkcji")]
    [DataType(DataType.Date)]
    public DateTime ProductionDate { get; set; }

    [StringLength(500, ErrorMessage = "Opis max 500 znaków")]
    public string Description { get; set; }
}