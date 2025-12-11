using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtoGaleriProjesi.Models;

public enum AracDurum
{
    Uygun,
    Rezerve,
    Satildi
}

[Table("Araclar")]
public class Arac
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Marka { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Model { get; set; } = string.Empty;

    public int Yil { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Fiyat { get; set; }

    public int Kilometre { get; set; }

    [MaxLength(20)]
    public string? Renk { get; set; }

    [MaxLength(20)]
    public string? YakitTipi { get; set; }

    [MaxLength(20)]
    public string? Vites { get; set; }

    [Required]
    [MaxLength(17)]
    public string SasiNo { get; set; } = string.Empty;

    public AracDurum Durum { get; set; } = AracDurum.Uygun;

    [MaxLength(500)]
    public string? Aciklama { get; set; }

    // Navigation properties
    public ICollection<Satis> Satislar { get; set; } = new List<Satis>();
}
