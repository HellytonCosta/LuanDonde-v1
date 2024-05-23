using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LuanDonde.Models.ViewModels
{
    public class AssessmentFormVM
    {
        public AssessmentForm AssessmentForm { get; set; }

        [ValidateNever]
        public int ContatoId { get; set; }
    }
}
