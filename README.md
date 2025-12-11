# OtoGaleriProjem

Basit bir Windows Forms oto galeri uygulaması. .NET 8 ve EF Core (code-first) ile SQL Server (localhost,1445 / sa / Oo_454545) kullanır. Açılışta TreeView ile araçları listeler; ekleme/düzenleme/silme, resim yolu seçimi ve detay görüntüleme içerir.

## Kurulum
1. .NET 8 SDK yüklü bir **Windows** ortamı kullanın (Windows hedefli projeler için önerilir). Linux/macOS üzerinde derlemek için `EnableWindowsTargeting=true` tanımlıdır ancak yayın senaryoları için Windows önerilir.
2. Gerekirse bağlantı bilgisini `OtoGaleriProjem/appsettings.json` içinden güncelleyin.
3. NuGet bağımlılıklarını yükleyin:
   ```bash
   dotnet restore
   ```
4. Veritabanını oluşturun (code-first):
   ```bash
   dotnet ef database update
   # veya Visual Studio Paket Yöneticisi'nden: Update-Database
   ```
5. Uygulamayı çalıştırın:
   ```bash
   dotnet run --project OtoGaleriProjem/OtoGaleriProjem.csproj
   ```

## Notlar
- TreeView üzerinde marka altında modeller listelenir; bir model seçildiğinde detay, fiyat, KM ve resim önizlemesi gösterilir.
- Araç formunda resim yolu seçilebilir; dosya yolu saklanır, dosyanın kendisi veritabanına kaydedilmez.
