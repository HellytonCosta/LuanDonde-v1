using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransformaSeu.Migrations
{
    /// <inheritdoc />
    public partial class AddingTheOtherField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanySectorOther",
                table: "Formularios",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanySectorOther",
                table: "Formularios");
        }
    }
}
