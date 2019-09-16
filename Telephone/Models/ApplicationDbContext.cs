using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Telephone.EntityConfigurations;

namespace Telephone.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Individual> Persons { get; set; }

        public DbSet<Setad> Setads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new SetadConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}