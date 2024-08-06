using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TransformaSeu.Models
{
    public class CheckBoxOption
    {
        [Key] 
        public int Id { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
