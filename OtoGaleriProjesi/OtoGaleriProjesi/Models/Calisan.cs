using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtoGaleriProjesi.Models;

[Table("Calisanlar")]
public class Calisan
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Ad { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Soyad { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string KullaniciAdi { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Sifre { get; set; } = string.Empty; // Plain text password

    public int RolId { get; set; }

    // Navigation properties
    [ForeignKey("RolId")]
    public Rol Rol { get; set; } = null!;

    public ICollection<Satis> Satislar { get; set; } = new List<Satis>();
}
