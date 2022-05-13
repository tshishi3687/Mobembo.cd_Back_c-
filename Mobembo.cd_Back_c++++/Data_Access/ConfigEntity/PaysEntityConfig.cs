using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class PaysEntityConfig : IEntityTypeConfiguration<Pays>
    {
        public void Configure(EntityTypeBuilder<Pays> builder)
        {
            // nom de la table
            builder.ToTable("Pays");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_pays");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.Alpha2).IsRequired();
            builder.Property(x => x.Alpha3).IsRequired();
            builder.Property(x => x.NomEnGb).IsRequired();
            builder.Property(x => x.NomFrFr).IsRequired();

            // Prés recquis
            builder.Property(x => x.Alpha2).HasMaxLength(255);
            builder.Property(x => x.Alpha3).HasMaxLength(255);
            builder.Property(x => x.NomEnGb).HasMaxLength(255);
            builder.Property(x => x.NomFrFr).HasMaxLength(255);
        }
    }
}
