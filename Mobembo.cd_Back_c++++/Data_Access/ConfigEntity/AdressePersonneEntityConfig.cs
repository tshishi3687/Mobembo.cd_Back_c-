using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class AdressePersonneEntityConfig : IEntityTypeConfiguration<AdressePersonne>
    {
        public void Configure(EntityTypeBuilder<AdressePersonne> builder)
        {
            // nom de la table
            builder.ToTable("AdressePersonne");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_adresse_personne");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // prés recquis et null
            builder.Property(x => x.NumHabitation).HasMaxLength(10);
            builder.Property(x => x.NomRue).HasMaxLength(100);
            builder.Property(x => x.CodePostalLocalite).HasMaxLength(20);

            // relations
            builder.HasOne(a => a.Pays)
                .WithMany(p => p.Adresses);
        }
    }
}
