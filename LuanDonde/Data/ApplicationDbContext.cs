using LuanDonde.Models;
using LuanDonde.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LuanDonde.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
         
        }
        // public DbSet<Contact> Contatos { get; set; }
        public DbSet<AssessmentForm> Formularios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
        }

    }
}
