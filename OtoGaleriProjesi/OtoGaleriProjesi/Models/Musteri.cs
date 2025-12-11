using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtoGaleriProjesi.Models;

[Table("Musteriler")]
public class Musteri
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Ad { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Soyad { get; set; } = string.Empty;

    [MaxLength(15)]
    public string? Telefon { get; set; }

    [MaxLength(100)]
    public string? Eposta { get; set; }

    [MaxLength(250)]
    public string? Adres { get; set; }

    // Navigation properties
    public ICollection<Satis> Satislar { get; set; } = new List<Satis>();
}
