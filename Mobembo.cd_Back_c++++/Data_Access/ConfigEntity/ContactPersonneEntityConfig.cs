using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class ContactPersonneEntityConfig : IEntityTypeConfiguration<ContactPersonne>
    {
        public void Configure(EntityTypeBuilder<ContactPersonne> builder)
        {
            // nom de la table
            builder.ToTable("ContactPersonne");

            // Primary Key
            builder.HasKey(x => x.Id);
            // Rendre la primary key auto-incrémantable
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // gestion des null
            builder.Property(x => x.Email).IsRequired();
            //builder.Property(x => x.AppartientA).IsRequired();
            // pas de recquis pour le téléphone

            // prés recquis
            builder.HasCheckConstraint("CheckMinMail", "LEN(Email)>=6");
            builder.Property(x => x.Email).HasMaxLength(320);
            builder.HasIndex(x => x.Email).IsUnique();

            // relation one to one with personne
            builder.HasOne<Personne>(x => x.AppartientA)
                .WithOne(p => p.Contact)
                .HasForeignKey<Personne>(p => p.Id).HasConstraintName("FK_Contact_Personne");
        }
    }
}
