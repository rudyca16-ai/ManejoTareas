using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManejoDeTareas.Migrations
{
    /// <inheritdoc />
    public partial class RenameArchivoAdjuntoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ArchivoAdjunto",
                newName: "ArchivosAdjuntos"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ArchivosAdjuntos",
                newName: "ArchivoAdjunto"
            );
        }
    }
}
