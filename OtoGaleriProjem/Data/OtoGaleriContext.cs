using Microsoft.EntityFrameworkCore;
using OtoGaleriProjem.Models;

namespace OtoGaleriProjem.Data;

public class OtoGaleriContext : DbContext
{
    public DbSet<Arac> Araclar => Set<Arac>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(AppConfiguration.ConnectionString);
        }
    }
}
