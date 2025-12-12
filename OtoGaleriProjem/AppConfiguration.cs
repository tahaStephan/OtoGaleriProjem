using Microsoft.Extensions.Configuration;

namespace OtoGaleriProjem;

public static class AppConfiguration
{
    private static readonly Lazy<IConfigurationRoot> _configuration = new(() =>
        new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build());

    public static IConfigurationRoot Configuration => _configuration.Value;

    public static string ConnectionString
    {
        get
        {
            var fromEnv = Environment.GetEnvironmentVariable("OTOGALERI_CONNECTIONSTRING");
            if (!string.IsNullOrWhiteSpace(fromEnv))
            {
                return fromEnv;
            }

            var fromConfig = Configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrWhiteSpace(fromConfig))
            {
                throw new InvalidOperationException("Bağlantı dizesi bulunamadı. OTOGALERI_CONNECTIONSTRING ortam değişkenini veya appsettings.json değerini ayarlayın.");
            }

            return fromConfig;
        }
    }
}
