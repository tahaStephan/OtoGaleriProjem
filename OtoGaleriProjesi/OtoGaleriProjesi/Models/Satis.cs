using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtoGaleriProjesi.Models;

[Table("Satislar")]
public class Satis
{
    [Key]
    public int Id { get; set; }

    public int AracId { get; set; }

    public int MusteriId { get; set; }

    public int CalisanId { get; set; }

    public DateTime SatisTarihi { get; set; } = DateTime.Now;

    [Column(TypeName = "decimal(18,2)")]
    public decimal SatisFiyati { get; set; }

    [MaxLength(500)]
    public string? Notlar { get; set; }

    // Navigation properties
    [ForeignKey("AracId")]
    public Arac Arac { get; set; } = null!;

    [ForeignKey("MusteriId")]
    public Musteri Musteri { get; set; } = null!;

    [ForeignKey("CalisanId")]
    public Calisan Calisan { get; set; } = null!;
}
