using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OtoGaleriProjesi;
using OtoGaleriProjesi.Context;

#nullable disable

namespace OtoGaleriProjem.Migrations
{
    [DbContext(typeof(OtoGaleriContext))]
    partial class OtoGaleriContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Arac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Durum")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Kilometre")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Renk")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SasiNo")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("Vites")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("YakitTipi")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Yil")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SasiNo")
                        .IsUnique();

                    b.ToTable("Araclar");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Calisan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Calisanlar");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Eposta")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roller");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Satis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AracId")
                        .HasColumnType("int");

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("Notlar")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("SatisFiyati")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("SatisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AracId");

                    b.HasIndex("CalisanId");

                    b.HasIndex("MusteriId");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Calisan", b =>
                {
                    b.HasOne("OtoGaleriProjem.Data.Models.Rol", "Rol")
                        .WithMany("Calisanlar")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Satis", b =>
                {
                    b.HasOne("OtoGaleriProjem.Data.Models.Arac", "Arac")
                        .WithMany("Satislar")
                        .HasForeignKey("AracId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OtoGaleriProjem.Data.Models.Calisan", "Calisan")
                        .WithMany("Satislar")
                        .HasForeignKey("CalisanId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OtoGaleriProjem.Data.Models.Musteri", "Musteri")
                        .WithMany("Satislar")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Arac");

                    b.Navigation("Calisan");

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Arac", b =>
                {
                    b.Navigation("Satislar");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Calisan", b =>
                {
                    b.Navigation("Satislar");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Musteri", b =>
                {
                    b.Navigation("Satislar");
                });

            modelBuilder.Entity("OtoGaleriProjem.Data.Models.Rol", b =>
                {
                    b.Navigation("Calisanlar");
                });
#pragma warning restore 612, 618
        }
    }
}
