using Microsoft.Extensions.Configuration;

namespace OtoGaleriProjem;

public static class AppConfiguration
{
    private static readonly Lazy<IConfigurationRoot> _configuration = new(() =>
        new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build());

    public static IConfigurationRoot Configuration => _configuration.Value;

    public static string ConnectionString =>
        Configuration.GetConnectionString("DefaultConnection") ??
        "Server=localhost,1445;Database=OtoGaleriDb;User ID=sa;Password=Oo_454545;TrustServerCertificate=True;";
}
