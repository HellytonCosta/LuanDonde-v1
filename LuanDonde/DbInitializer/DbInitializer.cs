using LuanDonde.Data;
using Microsoft.EntityFrameworkCore;

namespace TransformaSeu.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        public DbInitializer(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0 )
                {
                    _db.Database.Migrate();
                }


            } catch (Exception ex)
            {

            }

            return;

        }
    }
}
