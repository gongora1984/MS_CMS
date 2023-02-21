using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrMfrConfiguration : IEntityTypeConfiguration<BkrMfr>
{
    public void Configure(EntityTypeBuilder<BkrMfr> entity)
    {
        entity.HasKey(e => e.Id)
                    .HasName("PKBkrMfrId");

        entity.ToTable(TableNames.BkrMfr);

        entity.HasIndex(e => e.CaseBkrId, "FKBKRMFRCaseBKRId");

        entity.Property(e => e.Id).HasColumnName("BkrMfrId");

        entity.Property(e => e.Apoentered)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasColumnName("APOEntered");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.FinalJudgment)
            .HasMaxLength(5)
        .IsUnicode(false);

        entity.Property(e => e.MotionGranted)
            .HasMaxLength(5)
        .IsUnicode(false);

        entity.Property(e => e.NegativeNotice)
            .HasMaxLength(5)
        .IsUnicode(false);

        entity.Property(e => e.ReliefByPlan)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.StatementOfIntention)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.TermsOfApo)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("TermsOfAPO");

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrMfrs)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRMFRCaseBKRId");
    }
}
