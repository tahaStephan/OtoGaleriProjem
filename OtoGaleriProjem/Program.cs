using Microsoft.EntityFrameworkCore;
using OtoGaleriProjem.Data;

namespace OtoGaleriProjem;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using (var context = new OtoGaleriContext())
        {
            context.Database.Migrate();
        }

        Application.Run(new MainForm());
    }
}
