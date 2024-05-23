using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransformaSeu.Migrations
{
    /// <inheritdoc />
    public partial class CreatingAllAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermosDeUso = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    GrauInstrucao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RolePosition = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanySocialName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyCNPJ = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyState = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyRevenue = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanySector = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanySize = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MaturidadeDigital = table.Column<double>(type: "float", nullable: false),
                    CulturaPeso = table.Column<int>(type: "int", nullable: false),
                    CulturaTotal = table.Column<int>(type: "int", nullable: false),
                    CulturaMedia = table.Column<double>(type: "float", nullable: false),
                    CulturaFinal = table.Column<double>(type: "float", nullable: false),
                    Cultura1 = table.Column<int>(type: "int", nullable: false),
                    Cultura2 = table.Column<int>(type: "int", nullable: false),
                    Cultura3 = table.Column<int>(type: "int", nullable: false),
                    Cultura4 = table.Column<int>(type: "int", nullable: false),
                    Cultura5 = table.Column<int>(type: "int", nullable: false),
                    Cultura6 = table.Column<int>(type: "int", nullable: false),
                    ExperienciaPeso = table.Column<int>(type: "int", nullable: false),
                    ExperienciaTotal = table.Column<int>(type: "int", nullable: false),
                    ExperienciaMedia = table.Column<double>(type: "float", nullable: false),
                    ExperienciaFinal = table.Column<double>(type: "float", nullable: false),
                    Experiencia1 = table.Column<int>(type: "int", nullable: false),
                    Experiencia2 = table.Column<int>(type: "int", nullable: false),
                    Experiencia3 = table.Column<int>(type: "int", nullable: false),
                    Experiencia4 = table.Column<int>(type: "int", nullable: false),
                    Experiencia5 = table.Column<int>(type: "int", nullable: false),
                    Experiencia6 = table.Column<int>(type: "int", nullable: false),
                    MercadoPeso = table.Column<int>(type: "int", nullable: false),
                    MercadoTotal = table.Column<int>(type: "int", nullable: false),
                    MercadoMedia = table.Column<double>(type: "float", nullable: false),
                    MercadoFinal = table.Column<double>(type: "float", nullable: false),
                    Mercado1 = table.Column<int>(type: "int", nullable: false),
                    Mercado2 = table.Column<int>(type: "int", nullable: false),
                    Mercado3 = table.Column<int>(type: "int", nullable: false),
                    Mercado4 = table.Column<int>(type: "int", nullable: false),
                    InovacaoPeso = table.Column<int>(type: "int", nullable: false),
                    InovacaoTotal = table.Column<int>(type: "int", nullable: false),
                    InovacaoMedia = table.Column<double>(type: "float", nullable: false),
                    InovacaoFinal = table.Column<double>(type: "float", nullable: false),
                    Inovacao1 = table.Column<int>(type: "int", nullable: false),
                    Inovacao2 = table.Column<int>(type: "int", nullable: false),
                    Inovacao3 = table.Column<int>(type: "int", nullable: false),
                    Inovacao4 = table.Column<int>(type: "int", nullable: false),
                    ProcessosPeso = table.Column<int>(type: "int", nullable: false),
                    ProcessosTotal = table.Column<int>(type: "int", nullable: false),
                    ProcessosMedia = table.Column<double>(type: "float", nullable: false),
                    ProcessosFinal = table.Column<double>(type: "float", nullable: false),
                    Processos1 = table.Column<int>(type: "int", nullable: false),
                    Processos2 = table.Column<int>(type: "int", nullable: false),
                    Processos3 = table.Column<int>(type: "int", nullable: false),
                    Processos4 = table.Column<int>(type: "int", nullable: false),
                    Processos5 = table.Column<int>(type: "int", nullable: false),
                    ModelosPeso = table.Column<int>(type: "int", nullable: false),
                    ModelosTotal = table.Column<int>(type: "int", nullable: false),
                    ModelosMedia = table.Column<double>(type: "float", nullable: false),
                    ModelosFinal = table.Column<double>(type: "float", nullable: false),
                    Modelos1 = table.Column<int>(type: "int", nullable: false),
                    Modelos2 = table.Column<int>(type: "int", nullable: false),
                    Modelos3 = table.Column<int>(type: "int", nullable: false),
                    Modelos4 = table.Column<int>(type: "int", nullable: false),
                    DadosPeso = table.Column<int>(type: "int", nullable: false),
                    DadosTotal = table.Column<int>(type: "int", nullable: false),
                    DadosMedia = table.Column<double>(type: "float", nullable: false),
                    DadosFinal = table.Column<double>(type: "float", nullable: false),
                    Dados1 = table.Column<int>(type: "int", nullable: false),
                    Dados2 = table.Column<int>(type: "int", nullable: false),
                    Dados3 = table.Column<int>(type: "int", nullable: false),
                    Dados4 = table.Column<int>(type: "int", nullable: false),
                    Dados5 = table.Column<int>(type: "int", nullable: false),
                    TecnologiaPeso = table.Column<int>(type: "int", nullable: false),
                    TecnologiaTotal = table.Column<int>(type: "int", nullable: false),
                    TecnologiaMedia = table.Column<double>(type: "float", nullable: false),
                    TecnologiaFinal = table.Column<double>(type: "float", nullable: false),
                    Tecnologia1 = table.Column<int>(type: "int", nullable: false),
                    Tecnologia2 = table.Column<int>(type: "int", nullable: false),
                    Tecnologia3 = table.Column<int>(type: "int", nullable: false),
                    Tecnologia4 = table.Column<int>(type: "int", nullable: false),
                    Tecnologia5 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formularios");
        }
    }
}
