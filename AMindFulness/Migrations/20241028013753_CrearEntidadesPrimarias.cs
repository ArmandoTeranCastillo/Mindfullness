using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AMindFulness.Migrations
{
    /// <inheritdoc />
    public partial class CrearEntidadesPrimarias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Distorsiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distorsiones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Etiquetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etiquetas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pensamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Distorsiones = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Etiquetas = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Reformacion = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaReformacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pensamientos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DistorsionCognitivaPensamiento",
                columns: table => new
                {
                    DistorsionesCognitivasId = table.Column<int>(type: "int", nullable: false),
                    PensamientosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistorsionCognitivaPensamiento", x => new { x.DistorsionesCognitivasId, x.PensamientosId });
                    table.ForeignKey(
                        name: "FK_DistorsionCognitivaPensamiento_Distorsiones_DistorsionesCogn~",
                        column: x => x.DistorsionesCognitivasId,
                        principalTable: "Distorsiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistorsionCognitivaPensamiento_Pensamientos_PensamientosId",
                        column: x => x.PensamientosId,
                        principalTable: "Pensamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EtiquetaPensamiento",
                columns: table => new
                {
                    EtiquetasPensamientoId = table.Column<int>(type: "int", nullable: false),
                    PensamientosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtiquetaPensamiento", x => new { x.EtiquetasPensamientoId, x.PensamientosId });
                    table.ForeignKey(
                        name: "FK_EtiquetaPensamiento_Etiquetas_EtiquetasPensamientoId",
                        column: x => x.EtiquetasPensamientoId,
                        principalTable: "Etiquetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EtiquetaPensamiento_Pensamientos_PensamientosId",
                        column: x => x.PensamientosId,
                        principalTable: "Pensamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Distorsiones",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Filtraje" },
                    { 2, "Polarización" },
                    { 3, "Sobregeneralización" },
                    { 4, "Desestimar lo Positivo" },
                    { 5, "Catastrofismo" },
                    { 6, "Personalización" },
                    { 7, "Falacia de Control" },
                    { 8, "Falacia de la Justicia" },
                    { 9, "Falacia del Cambio" },
                    { 10, "Culpa" },
                    { 11, "Deberías" },
                    { 12, "Razonamiento Emocional" },
                    { 13, "Etiquetado Global" },
                    { 14, "Siempre tener la razón" },
                    { 15, "Precipitar Conclusiones" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistorsionCognitivaPensamiento_PensamientosId",
                table: "DistorsionCognitivaPensamiento",
                column: "PensamientosId");

            migrationBuilder.CreateIndex(
                name: "IX_EtiquetaPensamiento_PensamientosId",
                table: "EtiquetaPensamiento",
                column: "PensamientosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistorsionCognitivaPensamiento");

            migrationBuilder.DropTable(
                name: "EtiquetaPensamiento");

            migrationBuilder.DropTable(
                name: "Distorsiones");

            migrationBuilder.DropTable(
                name: "Etiquetas");

            migrationBuilder.DropTable(
                name: "Pensamientos");
        }
    }
}
