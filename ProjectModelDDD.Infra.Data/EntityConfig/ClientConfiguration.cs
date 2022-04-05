using ModelProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProjectDDD.Infra.Data.EntityConfig
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(c => c.ClientId);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
