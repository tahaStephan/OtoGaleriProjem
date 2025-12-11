using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoGaleriProjem.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Araclar",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Yil = table.Column<int>(type: "int", nullable: false),
                Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Kilometre = table.Column<int>(type: "int", nullable: false),
                Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Araclar", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Araclar");
    }
}
