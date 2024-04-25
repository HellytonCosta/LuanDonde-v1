using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuanDonde.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
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
        [DisplayName("Número para Contato")]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Cargo na Empresa")]
        public string RolePosition { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Departamento")]
        public string Department { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Nome Social da Empresa")]
        public string CompanySocialName { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("CNPJ da Empresa")]
        public string CompanyCNPJ { get; set;  }
        [Required]
        [MaxLength(30)]
        [DisplayName("UF da Empresa")]
        public string CompanyState { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Lucro da Empresa")]
        public string CompanyRevenue { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Setor de Atuação da Empresa")]
        public string CompanySector { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Tamanho da Empresa")]
        public string CompanySize { get; set; }
    }
}
