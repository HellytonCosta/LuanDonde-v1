using LuanDonde.Data;
using LuanDonde.Repository.IRepository;

namespace LuanDonde.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IAssessmentFormRepository Formulario { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Formulario = new AssessmentFormRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
