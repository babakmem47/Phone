using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Telephone.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Setad> Setads { get; set; }

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