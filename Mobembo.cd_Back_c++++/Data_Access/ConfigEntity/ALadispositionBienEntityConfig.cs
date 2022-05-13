using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Data_Access.ConfigEntity
{
    public class ALadispositionBienEntityConfig : IEntityTypeConfiguration<ALaDispositionBien>
    {
        public void Configure(EntityTypeBuilder<ALaDispositionBien> builder)
        {
            // Relation
            builder.HasKey(ab => new { ab.BienId, ab.ALaDispositionId });

            builder.HasOne(ab => ab.ALaDispositions)
                .WithMany(a => a.Bien)
                .HasForeignKey(ab => ab.ALaDispositionId);

            builder.HasOne(ab => ab.Biens)
                .WithMany(b => b.AlaDisposition)
                .HasForeignKey(ab => ab.BienId);
        }
    }
}
