using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LuanDonde.Models
{
    public class AssessmentForm
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Termos de Uso")]
        public bool TermosDeUso { get; set; }
        [Required]
        [MaxLength(60)]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required]
        [MaxLength(60)]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Grau de Instrução")]
        public string GrauInstrucao{ get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Número para Contato")]
        public string PhoneNumber { get; set; }

        [AllowNull]
        [MaxLength(30)]
        [DisplayName("Nome Social da Empresa")]
        public string CompanySocialName { get; set; }

        [AllowNull]
        [MaxLength(30)]
        [DisplayName("CNPJ da Empresa")]
        public string CompanyCNPJ { get; set; }

        [AllowNull]
        [MaxLength(30)]
        [DisplayName("Setor de Atuação da Empresa")]
        public string CompanySector { get; set; }

        [AllowNull]
        [MaxLength(30)]
        [DisplayName("Tamanho da Empresa")]
        public string CompanySize { get; set; }

        [AllowNull]
        [MaxLength(30)]
        [DisplayName("Cargo na Empresa")]
        public string RolePosition { get; set; }
        [AllowNull]
        [MaxLength(30)]
        [DisplayName("Departamento")]
        public string Department { get; set; }
        [AllowNull]
        [MaxLength(30)]
        [DisplayName("UF da Empresa")]
        public string TimeInRole { get; set; }
        [AllowNull]
        [MaxLength(80)]
        [DisplayName("Objetivo Principal")]
        public string MainGoal { get; set; }
        [AllowNull]
        [MaxLength(15)]
        [DisplayName("Proximidade com o objetivo")]
        public string ProximityOfGoal { get; set; }
        [AllowNull]
        [MaxLength(80)]
        [DisplayName("Prioridade")]
        public string Priority { get; set; }

        // RESULTADO FINAL
        [Range(1,100)]
        public double MaturidadeDigital { get; set; }

        //   FORMULÁRIO CULTURA   
        [Range(0, 1000)]
        public int CulturaPeso { get; set; }
        [Range(0, 1000)]
        public int CulturaTotal { get; set; }
        [Range(0, 1000.0)]
        public double CulturaMedia { get; set; }
        [Range(0, 100.0)]
        public double CulturaFinal { get; set; }
        public int Cultura1 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Cultura2 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Cultura3 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Cultura4 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Cultura5 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Cultura6 { get; set; }


        //   FORMULÁRIO EXPERIÊNCIA   
        [Range(0, 1000)]
        public int ExperienciaPeso { get; set; }
        [Range(0, 1000)]
        public int ExperienciaTotal { get; set; }
        [Range(0, 1000.0)]
        public double ExperienciaMedia { get; set; }
        [Range(0, 100.0)]
        public double ExperienciaFinal { get; set; }
        public int Experiencia1 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Experiencia2 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Experiencia3 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Experiencia4 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Experiencia5 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Experiencia6 { get; set; }


        //   FORMULÁRIO MERCADO   
        [Range(0, 1000)]
        public int MercadoPeso { get; set; }
        [Range(0, 1000)]
        public int MercadoTotal { get; set; }
        [Range(0, 1000.0)]
        public double MercadoMedia { get; set; }
        [Range(0, 100.0)]
        public double MercadoFinal { get; set; }
        public int Mercado1 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Mercado2 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Mercado3 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Mercado4 { get; set; }


        //   FORMULÁRIO INOVAÇÃO   
        [Range(0, 1000)]
        public int InovacaoPeso { get; set; }
        [Range(0, 1000)]
        public int InovacaoTotal { get; set; }
        [Range(0, 1000.0)]
        public double InovacaoMedia { get; set; }
        [Range(0, 100.0)]
        public double InovacaoFinal { get; set; }
        public int Inovacao1 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Inovacao2 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Inovacao3 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Inovacao4 { get; set; }


        //   FORMULÁRIO PROCESSOS  
        [Range(0, 1000)]
        public int ProcessosPeso { get; set; }
        [Range(0, 1000)]
        public int ProcessosTotal { get; set; }
        [Range(0, 1000.0)]
        public double ProcessosMedia { get; set; }
        [Range(0, 100.0)]
        public double ProcessosFinal { get; set; }
        public int Processos1 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Processos2 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Processos3 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Processos4 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Processos5 { get; set; }


        //   FORMULÁRIO MODELOS DE NEGÓCIO   
        [Range(0, 1000)]
        public int ModelosPeso { get; set; }
        [Range(0, 1000)]
        public int ModelosTotal { get; set; }
        [Range(0, 1000.0)]
        public double ModelosMedia { get; set; }
        [Range(0, 100.0)]
        public double ModelosFinal { get; set; }
        public int Modelos1 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Modelos2 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Modelos3 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Modelos4 { get; set; }


        //   FORMULÁRIO DADOS   
        [Range(0, 1000)]
        public int DadosPeso { get; set; }
        [Range(0, 1000)]
        public int DadosTotal { get; set; }
        [Range(0, 1000.0)]
        public double DadosMedia { get; set; }
        [Range(0, 100.0)]
        public double DadosFinal { get; set; }
        public int Dados1 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Dados2 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Dados3 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Dados4 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Dados5 { get; set; }


        //   FORMULÁRIO TECNOLOGIAS  
        [Range(0, 1000)]
        public int TecnologiaPeso { get; set; }
        [Range(0, 1000)]
        public int TecnologiaTotal { get; set; }
        [Range(0, 1000.0)]
        public double TecnologiaMedia { get; set; }
        [Range(0, 100.0)]
        public double TecnologiaFinal { get; set; }
        public int Tecnologia1 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Tecnologia2 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Tecnologia3 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Tecnologia4 { get; set; }
        [Required]
        [Range(0, 100)]
        public int Tecnologia5 { get; set; }

        // starting variables to broke the form in some pages
        public void auxIndex()
        {
            PhoneNumber = "";
            CompanyCNPJ = "";
            CompanySector = "";
            CompanySize = "";
            CompanySocialName = "";
            TimeInRole = "";
            Department = "";
            RolePosition = "";
            ProximityOfGoal = "";
            Priority = "";
            MainGoal = "";
        }
        public void auxIndex2()
        {
            PhoneNumber = "";
            CompanySize = "";
            TimeInRole = "";
            Department = "";
            RolePosition = "";
            ProximityOfGoal = "";
            Priority = "";
            MainGoal = "";
        }
        public void auxIndex3()
        {
            PhoneNumber = "";
            TimeInRole = "";
            Department = "";
            ProximityOfGoal = "";
            Priority = "";
            MainGoal = "";
        }
        public void auxIndex4()
        {
            PhoneNumber = "";
            ProximityOfGoal = "";
            Priority = "";
            MainGoal = "";
        }
        public void auxQuestion1()
        {
            PhoneNumber = "";
            ProximityOfGoal = "";
            Priority = "";
            
        }
        public void auxQuestion2()
        {
            PhoneNumber = "";
            Priority = "";
        }
        public void auxQuestion3()
        {
            PhoneNumber = "";
         
        }

        // CALCULO DE MEDIANA
        public double CalculoMediana(List<Double> ListaFormulario)
        {
            double mediana;
            if (ListaFormulario.Count % 2 == 0)
            {
                // Se o número de elementos for par, a mediana é a média dos dois elementos do meio
                int meioEsquerda = ListaFormulario.Count / 2 - 1;
                int meioDireita = ListaFormulario.Count / 2;
                mediana = (ListaFormulario[meioEsquerda] + ListaFormulario[meioDireita]) / 2.0;
            }
            else
            {
                // Se o número de elementos for ímpar, a mediana é o elemento do meio
                int meio = ListaFormulario.Count / 2;
                mediana = ListaFormulario[meio];
            }
            return mediana;
        }
    }
}
