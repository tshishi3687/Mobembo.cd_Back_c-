using Microsoft.EntityFrameworkCore;
using Mobembo.cd_Back_c____.Data_Access.ConfigEntity;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Security;
using Mobembo.cd_Back_c____.Validation;

namespace Mobembo.cd_Back_c____
{
    public class Context : DbContext
    {
        private DonneesDB DonneesDB = new DonneesDB();
        public DbSet<Personne> personnes { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Pays> pays { get; set; }
        public DbSet<AdressePersonne> adressePersonnes { get; set; }
        public DbSet<PersonnesRoles> PersonneRoles { get; set; }
        public DbSet<Ville> villes { get; set; }
        public DbSet<Province> provinces { get; set; }
        public DbSet<Coordonnee> coordonnees { get; set; }
        public DbSet<TypeBien> typeBiens { get; set; }
        public DbSet<ALaDisposition> aLaDispositions { get; set; }
        public DbSet<ALaDispositionBien> aLaDispositionBiens { get; set; }
        public DbSet<Bien> biens { get; set; }

       

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
            modelBuilder.ApplyConfiguration<Role>(new RoleEntityConfig());
            modelBuilder.ApplyConfiguration<Pays>(new PaysEntityConfig());
            modelBuilder.ApplyConfiguration<AdressePersonne>(new AdressePersonneEntityConfig());
            modelBuilder.ApplyConfiguration<PersonnesRoles>(new PerosnnesRolesEntityConfig());
            modelBuilder.ApplyConfiguration<Ville>(new VilleEntityConfig());
            modelBuilder.ApplyConfiguration<Province>(new ProvinceEntityConfig());
            modelBuilder.ApplyConfiguration<Coordonnee>(new CoordonneeEntityConfig());
            modelBuilder.ApplyConfiguration<TypeBien>(new TypeBienEntityConfig());
            modelBuilder.ApplyConfiguration<ALaDisposition>(new ALaDispositionEntityConfig());
            modelBuilder.ApplyConfiguration<ALaDispositionBien>(new ALadispositionBienEntityConfig());
            modelBuilder.ApplyConfiguration<Bien>(new BienEntityConfig());

            // Allimenter la DB
            DonneesDB.Role(modelBuilder.Entity<Role>());
           
            //DonneesDB.Pays(pays);


            // Add data
            base.OnModelCreating(modelBuilder);
            }
        }
    }
