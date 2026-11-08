using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Actividad17.Migrations
{
    /// <inheritdoc />
    public partial class InicialEstudiantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Carrera = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Semestre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_Matricula",
                table: "Estudiantes",
                column: "Matricula",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}
