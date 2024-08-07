using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransformaSeu.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainGoal1",
                table: "Formularios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainGoal2",
                table: "Formularios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainGoal3",
                table: "Formularios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainGoal1",
                table: "Formularios");

            migrationBuilder.DropColumn(
                name: "MainGoal2",
                table: "Formularios");

            migrationBuilder.DropColumn(
                name: "MainGoal3",
                table: "Formularios");
        }
    }
}
