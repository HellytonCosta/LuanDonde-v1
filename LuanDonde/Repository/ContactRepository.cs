using LuanDonde.Data;
using LuanDonde.Models;
using LuanDonde.Repository.IRepository;

namespace LuanDonde.Repository
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        private ApplicationDbContext _db;
        public ContactRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Contact _contato)
        {
        //    _db.Contatos.Update(_contato);
        }
    }
}
