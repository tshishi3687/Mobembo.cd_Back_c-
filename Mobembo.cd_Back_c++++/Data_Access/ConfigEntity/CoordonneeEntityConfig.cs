using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class CoordonneeEntityConfig : IEntityTypeConfiguration<Coordonnee>
    {
        public void Configure(EntityTypeBuilder<Coordonnee> builder)
        {
            // nom de la table
            builder.ToTable("Coordonnee");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_coordonnee");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // relation 
            builder.HasOne(c => c.Ville)
                .WithMany(v => v.Coordonnees)
                .HasForeignKey(c => c.VilleID);
        }
    }
}
