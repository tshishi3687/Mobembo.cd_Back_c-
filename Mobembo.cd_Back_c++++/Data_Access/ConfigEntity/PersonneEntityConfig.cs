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
            //builder.Property(x => x.RolePersonne).IsRequired(); 
            //builder.Property(x => x.mdp).IsRequired();

            // Prés recquis
            builder.HasCheckConstraint("CheckMinNom", "LEN(Nom)>=3");
            builder.Property(x => x.Nom).HasMaxLength(50);
            builder.HasCheckConstraint("CheckMinNom", "LEN(Prenom)>=3");
            builder.Property(x => x.Prenom).HasMaxLength(50);
            builder.HasCheckConstraint("CheckAdult", "DateDiff(year, Ddn, GetDate())>=18");

            

        }
    }
}
