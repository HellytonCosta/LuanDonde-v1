using LuanDonde.Data;
using LuanDonde.Models;
using LuanDonde.Repository.IRepository;

namespace LuanDonde.Repository
{
    public class AssessmentFormRepository : Repository<AssessmentForm>, IAssessmentFormRepository
    {
        private ApplicationDbContext _db;
        public AssessmentFormRepository(ApplicationDbContext db) : base(db) 
        { 
            _db = db;
        }
        

        public void Update(AssessmentForm _assessmentForm)
        {
            _db.Formularios.Update(_assessmentForm);
        }
        
    }
}
