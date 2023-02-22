using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseEvictionJournalConfiguration : IEntityTypeConfiguration<CaseEvictionJournal>
{
    public void Configure(EntityTypeBuilder<CaseEvictionJournal> entity)
    {
        entity.ToTable(TableNames.CaseEvictionJournal);

        entity.HasKey(e => e.Id).HasName("PKCaseEvictionJournal");

        entity.Property(e => e.Id).HasColumnName("CaseEvictionJournalId");

        entity.HasIndex(e => e.CaseEvictionId, "FKCaseEvictionJournalCaseEvictionId");

        entity.HasIndex(e => e.LoginDetailId, "FKCaseEvictionJournalLoginDetailId");

        entity.Property(e => e.Action)
            .HasMaxLength(3000)
        .IsUnicode(false);

        entity.Property(e => e.OtherKey)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.HasOne(d => d.CaseEviction)
            .WithMany(p => p.CaseEvictionJournals)
            .HasForeignKey(d => d.CaseEvictionId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseEvictionJournalCaseEvictionId");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.CaseEvictionJournals)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseEvictionJournalLoginDetailId");
    }
}
