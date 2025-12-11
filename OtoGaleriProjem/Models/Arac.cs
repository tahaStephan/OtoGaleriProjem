namespace OtoGaleriProjem.Models;

public class Arac
{
    public int Id { get; set; }
    public string Marka { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Yil { get; set; }
    public decimal Fiyat { get; set; }
    public string Renk { get; set; } = string.Empty;
    public int Kilometre { get; set; }
    public string? Aciklama { get; set; }
    public string? ResimYolu { get; set; }
}
