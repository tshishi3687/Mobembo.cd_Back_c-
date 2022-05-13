using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class ALaDispositionEntityConfig : IEntityTypeConfiguration<ALaDisposition>
    {
        public void Configure(EntityTypeBuilder<ALaDisposition> builder)
        {
            // nom de la table
            builder.ToTable("AlaDisposition");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_disposition");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.NomDuDisponible).IsRequired();

            //builder.Property(x => x.AppartientA).IsRequired();
            // pas de recquis pour le téléphone

            // prés recquis
            builder.HasCheckConstraint("CheckMinMail", "LEN(NomDuDisponible)>=2");
            builder.Property(x => x.NomDuDisponible).HasMaxLength(50);
            builder.HasIndex(x => x.NomDuDisponible).IsUnique();

        }
    }
}
