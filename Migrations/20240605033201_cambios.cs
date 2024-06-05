using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nutricionista.Migrations
{
    /// <inheritdoc />
    public partial class cambios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Altura",
                table: "Paciente",
                newName: "Peso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Peso",
                table: "Paciente",
                newName: "Altura");
        }
    }
}
