using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class TypeBienEntityConfig : IEntityTypeConfiguration<TypeBien>
    {
        public void Configure(EntityTypeBuilder<TypeBien> builder)
        {
            // nom de la table
            builder.ToTable("TypeBien");

            // Primary Key
            builder.HasKey(x => x.Id).HasName("PK_type_bien");
            //Rendre la Primary Key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // relattion
            builder.HasMany(tb => tb.Biens)
                .WithOne(b => b.TypeBien);
        }
    }
}
