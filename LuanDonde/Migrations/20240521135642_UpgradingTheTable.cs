using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransformaSeu.Migrations
{
    /// <inheritdoc />
    public partial class UpgradingTheTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyRevenue",
                table: "Formularios");

            migrationBuilder.RenameColumn(
                name: "CompanyState",
                table: "Formularios",
                newName: "TimeInRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeInRole",
                table: "Formularios",
                newName: "CompanyState");

            migrationBuilder.AddColumn<string>(
                name: "CompanyRevenue",
                table: "Formularios",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
