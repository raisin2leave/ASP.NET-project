using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab0.Data.Entities;

[Table("manufacturers")]
public class ManufacturerEntity
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public ISet<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();
}