using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Telephone.Models;

namespace Telephone.EntityConfigurations
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            HasKey(p => p.Id);
            
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.TelDirect)
                .HasMaxLength(11);

            Property(p => p.TelInternal)
                .HasMaxLength(4);

            Property(p => p.Mobile)
                .HasMaxLength(11)
                .IsFixedLength();

            
            // (0..1)-To-Many with Setad
            HasOptional(p => p.Setad)
                .WithMany(s => s.Persons)
                .HasForeignKey(p => p.SetadId);
        }
    }
}