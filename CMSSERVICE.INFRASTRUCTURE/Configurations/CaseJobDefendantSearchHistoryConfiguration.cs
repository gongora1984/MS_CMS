using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseJobDefendantSearchHistoryConfiguration : IEntityTypeConfiguration<CaseJobDefendantSearchHistory>
{
    public void Configure(EntityTypeBuilder<CaseJobDefendantSearchHistory> entity)
    {
        entity.ToTable(TableNames.CaseJobDefendantSearchHistory);

        entity.HasKey(e => e.Id).HasName("PKCaseJobDefendantSearchHistory");

        entity.Property(e => e.Id).HasColumnName("CaseJobDefendantSearchHistoryId");

        entity.HasIndex(e => e.CameFromAssignmentId, "FKCaseJobDefendantSearchHistoryCameFromAssignmentId");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKCaseJobDefendantSearchHistoryCaseJobDefendantId");

        entity.HasIndex(e => e.CaseJobDefendantSearchTypeLid, "FKCaseJobDefendantSearchHistoryCaseJobDefendantSearchTypeLid");

        entity.Property(e => e.CameFrom)
            .HasMaxLength(300)
        .IsUnicode(false);

        entity.Property(e => e.ResponseReceived).HasColumnType("xml");

        entity.Property(e => e.SendOutRequest).HasColumnType("xml");

        entity.Property(e => e.SentOutDate).HasDefaultValueSql("(getdate())");

        entity.HasOne(d => d.CameFromAssignment)
            .WithMany(p => p.CaseJobDefendantSearchHistories)
            .HasForeignKey(d => d.CameFromAssignmentId)
            .HasConstraintName("FKCaseJobDefendantSearchHistoryCameFromAssignmentId");

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.CaseJobDefendantSearchHistories)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantSearchHistoryCaseJobDefendantId");

        entity.HasOne(d => d.CaseJobDefendantSearchType)
            .WithMany(p => p.CaseJobDefendantSearchHistories)
            .HasForeignKey(d => d.CaseJobDefendantSearchTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantSearchHistoryCaseJobDefendantSearchTypeLid");
    }
}
