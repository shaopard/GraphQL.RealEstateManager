using GraphQL.RealEstateManager.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.RealEstateManager.Database
{
    public class RealEstateContext // : DbContext
    {
        //public RealEstateContext(DbContextOptions<RealEstateContext> options)
        //    : base(options)
        //{
        //    this.EnsureSeedData();
        //}

        public RealEstateContext()
        {
            this.EnsureSeedData();
        }

        //public DbSet<Property> Properties { get; set; }
        //public DbSet<Payment> Payments { get; set; }

        public List<Property> Properties { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
