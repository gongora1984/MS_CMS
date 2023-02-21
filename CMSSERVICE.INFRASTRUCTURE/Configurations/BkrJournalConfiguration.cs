using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrJournalConfiguration : IEntityTypeConfiguration<BkrJournal>
{
    public void Configure(EntityTypeBuilder<BkrJournal> entity)
    {
        entity.ToTable(TableNames.BkrJournal);

        entity.HasKey(e => e.Id).HasName("PKBkrJournal");

        entity.Property(e => e.Id).HasColumnName("BkrJournalId");

        entity.HasIndex(e => e.CaseBkrId, "FKBKRJournalCaseBKRId");

        entity.Property(e => e.Id).HasColumnName("BKRJourneyId");

        entity.Property(e => e.Action)
            .HasMaxLength(3000)
        .IsUnicode(false);

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.OtherKey)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrJournals)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRJournalCaseBKRId");
    }
}
