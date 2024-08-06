using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransformaSeu.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewFieldsForCheckbox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainGoalOptions",
                table: "Formularios");

            migrationBuilder.CreateTable(
                name: "CheckBoxOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentFormId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckBoxOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckBoxOption_Formularios_AssessmentFormId",
                        column: x => x.AssessmentFormId,
                        principalTable: "Formularios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckBoxOption_AssessmentFormId",
                table: "CheckBoxOption",
                column: "AssessmentFormId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckBoxOption");

            migrationBuilder.AddColumn<string>(
                name: "MainGoalOptions",
                table: "Formularios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
