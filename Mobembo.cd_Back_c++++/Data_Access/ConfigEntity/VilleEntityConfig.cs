using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class VilleEntityConfig : IEntityTypeConfiguration<Ville>
    {
        public void Configure(EntityTypeBuilder<Ville> builder)
        {
            // nom de la table
            builder.ToTable("Ville");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_ville");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            // gestion des null
            builder.Property(x => x.NomVille).IsRequired();
            builder.Property(x => x.NHabitant).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            // relation
            builder.HasMany(v => v.Coordonnees)
                .WithOne(c => c.Ville);
        }
    }
}
