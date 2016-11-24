using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using CarShare.Entities;

namespace CarShare.DAL
{
    public class CarShareDBContext : DbContext
    {
        public CarShareDBContext() : base("CarShareDBContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
