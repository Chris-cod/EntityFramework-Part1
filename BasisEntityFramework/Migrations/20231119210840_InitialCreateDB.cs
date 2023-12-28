using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasisEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionStudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnzahlStaffel = table.Column<int>(type: "int", nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StafellNummer = table.Column<int>(type: "int", nullable: false),
                    StafellName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnzahlFolge = table.Column<int>(type: "int", nullable: false),
                    AnimeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffels_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Folges",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FolgeNummer = table.Column<int>(type: "int", nullable: false),
                    FolgeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Daeur = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folges", x => x.id);
                    table.ForeignKey(
                        name: "FK_Folges_Staffels_StaffelId",
                        column: x => x.StaffelId,
                        principalTable: "Staffels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Folges_StaffelId",
                table: "Folges",
                column: "StaffelId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffels_AnimeId",
                table: "Staffels",
                column: "AnimeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folges");

            migrationBuilder.DropTable(
                name: "Staffels");

            migrationBuilder.DropTable(
                name: "Animes");
        }
    }
}
