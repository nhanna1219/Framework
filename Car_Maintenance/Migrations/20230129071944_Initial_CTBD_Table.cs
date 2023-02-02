using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarMaintenance.Migrations
{
    /// <inheritdoc />
    public partial class InitialCTBDTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Macv",
                table: "CT_BD",
                newName: "MaCV");

            migrationBuilder.RenameColumn(
                name: "Mabd",
                table: "CT_BD",
                newName: "MaBD");

            migrationBuilder.RenameIndex(
                name: "IX_CT_BD_Macv",
                table: "CT_BD",
                newName: "IX_CT_BD_MaCV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaCV",
                table: "CT_BD",
                newName: "Macv");

            migrationBuilder.RenameColumn(
                name: "MaBD",
                table: "CT_BD",
                newName: "Mabd");

            migrationBuilder.RenameIndex(
                name: "IX_CT_BD_MaCV",
                table: "CT_BD",
                newName: "IX_CT_BD_Macv");
        }
    }
}
