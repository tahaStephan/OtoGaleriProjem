using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtoGaleriProjesi.Models;

[Table("Roller")]
public class Rol
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Ad { get; set; } = string.Empty;

    // Navigation properties
    public ICollection<Calisan> Calisanlar { get; set; } = new List<Calisan>();
}
