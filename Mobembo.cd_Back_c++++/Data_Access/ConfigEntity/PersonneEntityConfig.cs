using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class PersonneEntityConfig : IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            // nom de la table
            builder.ToTable("Personne");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_personne");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.Nom).IsRequired(); 
            builder.Property(x => x.Prenom).IsRequired(); 
            builder.Property(x => x.Ddn).IsRequired();
            builder.Property(x => x.NomBanque).HasDefaultValue("Null");
            builder.Property(x => x.NumCarte).HasDefaultValue("Null");
            builder.Property(x => x.NumCompte).HasDefaultValue("Null");
            //builder.Property(x => x.RolePersonne).IsRequired(); 
            //builder.Property(x => x.mdp).IsRequired();

            // Prés recquis
            builder.HasCheckConstraint("CheckMinMail", "LEN(Email)>=6");
            builder.Property(x => x.Email).HasMaxLength(320);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasCheckConstraint("CheckMinNom", "LEN(Nom)>=3");
            builder.Property(x => x.Nom).HasMaxLength(50);
            builder.HasCheckConstraint("CheckMinNom", "LEN(Prenom)>=3");
            builder.Property(x => x.Prenom).HasMaxLength(50);
            builder.HasCheckConstraint("CheckAdult", "DateDiff(year, Ddn, GetDate())>=18");

            
            // relation
            builder.HasOne(p => p.AdressePersonne)
                .WithOne(a => a.AppartienA)
                .HasForeignKey<AdressePersonne>(a => a.Id);

            builder.HasMany(p => p.biens)
                .WithOne(b => b.AppartientA);
        }
    }
}
