using LuanDonde.Models;

namespace LuanDonde.Repository.IRepository
{
    public interface IContactRepository : IRepository<Contact>
    {
        void Update(Contact obj);
    }
}
