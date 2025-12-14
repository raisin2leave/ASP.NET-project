using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lab0.Models;

namespace Lab0.Data.Entities;

[Table("products")]
public class ProductEntity
{
    public int ManufacturerId { get; set; }

    [ForeignKey("ManufacturerId")]
    public ManufacturerEntity? ManufacturerEntity { get; set; }
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public decimal Price { get; set; }

    [Column("production_date")]
    public DateTime ProductionDate { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    public ProductCategory Category { get; set; }

    public DateTime Created { get; set; }
}