using Microsoft.EntityFrameworkCore;

namespace MS.EntityFramworkCore.ExistingDb.Models
{
    public class MyContext:DbContext 
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasKey(p => p.LicensePlate);
        }
    }

    public class Car
    {
        public string LicensePlate { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
    }
}
