using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransformaSeu.Migrations
{
    /// <inheritdoc />
    public partial class MainGoalUpdateTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MainGoal",
                table: "Formularios",
                newName: "MainGoalSelected");

            migrationBuilder.AddColumn<string>(
                name: "MainGoalOptions",
                table: "Formularios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainGoalOptions",
                table: "Formularios");

            migrationBuilder.RenameColumn(
                name: "MainGoalSelected",
                table: "Formularios",
                newName: "MainGoal");
        }
    }
}
