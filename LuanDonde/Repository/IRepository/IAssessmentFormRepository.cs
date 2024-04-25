using LuanDonde.Models;

namespace LuanDonde.Repository.IRepository
{
    public interface IAssessmentFormRepository : IRepository<AssessmentForm>
    {
        void Update(AssessmentForm obj);
    }
}
