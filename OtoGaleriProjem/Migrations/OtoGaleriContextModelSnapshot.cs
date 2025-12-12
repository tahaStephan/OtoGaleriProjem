using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OtoGaleriProjem.Data;

#nullable disable

namespace OtoGaleriProjem.Migrations;

[DbContext(typeof(OtoGaleriContext))]
partial class OtoGaleriContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.10");

        modelBuilder.Entity("OtoGaleriProjem.Models.Arac", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("Aciklama")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Fiyat")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("Kilometre")
                    .HasColumnType("int");

                b.Property<string>("Marka")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Model")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Renk")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ResimYolu")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Yil")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Araclar");
            });
#pragma warning restore 612, 618
    }
}
