using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OtoGaleriProjesi.DbContextFactory;
using OtoGaleriProjesi.Context;


namespace OtoGaleriProjesi;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Setup dependency injection
        var services = new ServiceCollection();

        // Add DbContext
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<OtoGaleriContext>(options =>
            options.UseSqlServer(connectionString));

        var serviceProvider = services.BuildServiceProvider();

        // Get DbContext and ensure database is created
        using (var scope = serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<OtoGaleriContext>();

            try
            {
                // Optional: Auto-migrate if configured
                var autoMigrate = configuration.GetValue<bool>("App:AutoMigrate");
                if (autoMigrate)
                {
                    context.Database.Migrate();
                }

                // Seed initial data
                VeriTohumu.SeedData(context);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Veritabaný baþlatýlýrken hata oluþtu:\n{ex.Message}\n\n" +
                    "Lütfen Update-Database komutunu çalýþtýrýn.",
                    "Veritabaný Hatasý",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        // Run the application
        using (var scope = serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<OtoGaleriContext>();
            Application.Run(new GirisForm(context));
        }
    }
}
