using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OtoGaleriProjesi.Context;

namespace OtoGaleriProjesi.DbContextFactory;

public class OtoGaleriContextFactory : IDesignTimeDbContextFactory<OtoGaleriContext>
{
    public OtoGaleriContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<OtoGaleriContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);

        return new OtoGaleriContext(optionsBuilder.Options);
    }
}
