using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class PassWordEntityConfig : IEntityTypeConfiguration<PassWord>
    {
        public void Configure(EntityTypeBuilder<PassWord> builder)
        {
            // nom de la table
            builder.ToTable("PassWord");

            // PRimary Key
            builder.HasKey(x => x.Id);
            // rendre la primary Key auto-incrémentable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.Mdp).IsRequired();
            //builder.Property(x => x.AppartientA).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(false);

            // près recquis
            builder.HasCheckConstraint("CheckMinMail", "LEN(Mdp)>=6");

            // relation ono to one with personne
            builder.HasOne(x => x.AppartientA)
                .WithOne(p => p.mdp)
                .HasForeignKey<Personne>(p => p.Id);
        }
    }
}
