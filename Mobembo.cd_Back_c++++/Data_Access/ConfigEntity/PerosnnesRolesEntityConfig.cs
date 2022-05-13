using Microsoft.EntityFrameworkCore;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class PerosnnesRolesEntityConfig : IEntityTypeConfiguration<PersonnesRoles>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PersonnesRoles> builder)
        {
            // Relation
            builder.HasKey(pr => new {pr.RoleId, pr.PersonneId});

            builder.HasOne(pr => pr.Personnes)
                .WithMany(p => p.Roles)
                .HasForeignKey(pr => pr.PersonneId);

            builder.HasOne(pr => pr.Roles)
                .WithMany(r => r.Personnes)
                .HasForeignKey(pr => pr.RoleId);
        }
    }
}
