using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ModelProjectDDD.Infra.Data.Context
{
    public class ModelProjectContext : DbContext
    {
        public ModelProjectContext()
            : base("ProjectModelDDD")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateRegistration") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateRegistration").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateRegistration").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
