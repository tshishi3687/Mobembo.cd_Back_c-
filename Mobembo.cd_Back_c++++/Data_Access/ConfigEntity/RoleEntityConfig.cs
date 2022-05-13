using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Security;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class RoleEntityConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // nom de la table
            builder.ToTable("RolePersonne");

            //Primary Key
            builder.HasKey(x => x.Id);
            // rendre la primary key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.NomRole).HasDefaultValue(Constente.RoleCl);

            builder.HasMany(r => r.Personnes)
                .WithOne(p => p.Roles);

        }
    }
}
