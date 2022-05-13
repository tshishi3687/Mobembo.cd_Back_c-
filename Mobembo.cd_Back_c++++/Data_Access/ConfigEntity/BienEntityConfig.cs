using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class BienEntityConfig : IEntityTypeConfiguration<Bien>
    {
        public void Configure(EntityTypeBuilder<Bien> builder)
        {
            // nom de la table
            builder.ToTable("Bien");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_Bien");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.Prix).IsRequired();
            builder.Property(x => x.Superficie).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            // prés recquis
            builder.HasCheckConstraint("CheckMinMail", "LEN(Description)>=50");
            builder.Property(x => x.Description).HasMaxLength(1000);

            // Relation
            builder.HasOne(b => b.AppartientA)
                .WithMany(p => p.biens)
                .HasForeignKey(b => b.AppartientAId);

            builder.HasOne(b => b.Coordonnee)
                .WithMany(c => c.Biens)
                .HasForeignKey(b => b.CoordonneeId);

            builder.HasOne(b => b.TypeBien)
                .WithMany(tb => tb.Biens)
                .HasForeignKey(b => b.TypeBienId);
        }
    }
}
