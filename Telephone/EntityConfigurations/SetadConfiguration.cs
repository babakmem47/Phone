using System.Data.Entity.ModelConfiguration;
using Telephone.Models;

namespace Telephone.EntityConfigurations
{
    public class SetadConfiguration : EntityTypeConfiguration<Setad>
    {
        public SetadConfiguration()
        {
            HasKey(s => s.Id);

            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(30);

            // Many-To-(0..1) with Person
            HasMany(s => s.Persons)
                .WithOptional(p => p.Setad)
                .WillCascadeOnDelete(false);
                
        }
    }
}