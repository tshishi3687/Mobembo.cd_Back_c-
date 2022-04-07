using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class RolePersonneEntityConfig : IEntityTypeConfiguration<RolePersonne>
    {
        public void Configure(EntityTypeBuilder<RolePersonne> builder)
        {
            // nom de la table
            builder.ToTable("RolePersonne");

            //Primary Key
            builder.HasKey(x => x.Id);
            // rendre la primary key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.NomRole).HasDefaultValue("Client");


            // relation one to many
            builder.HasMany(x => x.Personnes)
                .WithOne(p => p.RolePersonne);
        }
    }
}
