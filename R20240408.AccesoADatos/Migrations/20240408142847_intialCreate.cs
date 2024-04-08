using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace R20240408.AccesoADatos.Migrations
{
    public partial class intialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonasR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidoR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNacimientoR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstatusR = table.Column<byte>(type: "tinyint", nullable: false),
                    ComentarioR = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonasR", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonasR");
        }
    }
}
