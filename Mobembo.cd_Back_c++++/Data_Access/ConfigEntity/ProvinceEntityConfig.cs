using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class ProvinceEntityConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            // nom de la table
            builder.ToTable("Province");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_province");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.NomProvince).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            // près recquis
            builder.HasCheckConstraint("CheckMinMail", "LEN(Description)>=50");
            builder.Property(x => x.Description).HasMaxLength(1000);

        }
    }
}
