using Microsoft.EntityFrameworkCore;
using OtoGaleriProjesi.Models;

namespace OtoGaleriProjesi.Context;

public class OtoGaleriContext : DbContext
{
    public OtoGaleriContext(DbContextOptions<OtoGaleriContext> options)
        : base(options)
    {
    }

    public DbSet<Rol> Roller { get; set; } = null!;
    public DbSet<Calisan> Calisanlar { get; set; } = null!;
    public DbSet<Musteri> Musteriler { get; set; } = null!;
    public DbSet<Arac> Araclar { get; set; } = null!;
    public DbSet<Satis> Satislar { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Unique index on SasiNo
        modelBuilder.Entity<Arac>()
            .HasIndex(a => a.SasiNo)
            .IsUnique();

        // Configure relationships
        modelBuilder.Entity<Calisan>()
            .HasOne(c => c.Rol)
            .WithMany(r => r.Calisanlar)
            .HasForeignKey(c => c.RolId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Satis>()
            .HasOne(s => s.Arac)
            .WithMany(a => a.Satislar)
            .HasForeignKey(s => s.AracId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Satis>()
            .HasOne(s => s.Musteri)
            .WithMany(m => m.Satislar)
            .HasForeignKey(s => s.MusteriId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Satis>()
            .HasOne(s => s.Calisan)
            .WithMany(c => c.Satislar)
            .HasForeignKey(s => s.CalisanId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
