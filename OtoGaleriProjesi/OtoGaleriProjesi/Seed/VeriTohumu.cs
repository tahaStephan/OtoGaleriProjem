using OtoGaleriProjesi.Context;
using OtoGaleriProjesi.Models;

namespace OtoGaleriProjesi.Seed;

public static class VeriTohumu
{
    public static void SeedData(OtoGaleriContext context)
    {
        // Check if data already exists
        if (context.Roller.Any())
            return;

        // Seed Roles
        var adminRol = new Rol { Ad = "Admin" };
        var managerRol = new Rol { Ad = "Manager" };
        var satisRol = new Rol { Ad = "Satis" };

        context.Roller.AddRange(adminRol, managerRol, satisRol);
        context.SaveChanges();

        // Seed Admin User with plain text password
        var adminCalisan = new Calisan
        {
            Ad = "Admin",
            Soyad = "User",
            KullaniciAdi = "admin",
            Sifre = "Admin123!", // Plain text password as per requirement
            RolId = adminRol.Id
        };

        context.Calisanlar.Add(adminCalisan);
        context.SaveChanges();
    }
}
