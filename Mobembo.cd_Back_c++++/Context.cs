using Microsoft.EntityFrameworkCore;
using Mobembo.cd_Back_c____.Data_Access.ConfigEntity;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Security;

namespace Mobembo.cd_Back_c____
{
    public class Context: DbContext
    {
        public DbSet<Personne> personnes { get; set; }
        public DbSet<ContactPersonne> contacts { get; set; }
        public DbSet<RolePersonne> roles { get; set; }
        public DbSet<PassWord> passWords { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mobembo.ce;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Config Entity
            modelBuilder.ApplyConfiguration<Personne>(new PersonneEntityConfig());
            modelBuilder.ApplyConfiguration<ContactPersonne>(new ContactPersonneEntityConfig());
            modelBuilder.ApplyConfiguration<PassWord>(new PassWordEntityConfig());
            modelBuilder.ApplyConfiguration<RolePersonne>(new RolePersonneEntityConfig());

            // modelBuilder.Entity<RolePersonne>().HasData(new RolePersonne() { Id=1,NomRole=Constente.RoleAd}, new RolePersonne() { Id=2,NomRole=Constente.RoleCl});

            // Add data
            base.OnModelCreating(modelBuilder);
        }
    }
}
