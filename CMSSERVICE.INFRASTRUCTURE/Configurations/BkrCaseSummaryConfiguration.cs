using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrCaseSummaryConfiguration : IEntityTypeConfiguration<BkrCaseSummary>
{
    public void Configure(EntityTypeBuilder<BkrCaseSummary> entity)
    {
        entity.ToTable(TableNames.BkrCaseSummary);

        entity.HasIndex(e => e.CaseBkrId, "FKBKRCaseSummaryCaseBKRId");

        entity.Property(e => e.Id).HasColumnName("BKRCaseSummaryID");

        entity.Property(e => e.ArrearageCured)
            .HasMaxLength(5)
        .IsUnicode(false);

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.DischargeOder)
            .HasMaxLength(5)
        .IsUnicode(false);

        entity.Property(e => e.ExemptPursuant)
            .HasMaxLength(5)
        .IsUnicode(false);

        entity.Property(e => e.FinalJdgmntForeClosure)
            .HasMaxLength(5)
        .IsUnicode(false);

        entity.Property(e => e.ObtainedOed)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasColumnName("ObtainedOED");

        entity.Property(e => e.Oedentered)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasColumnName("OEDEntered");

        entity.Property(e => e.PlanConfirmed)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.PropNotListed)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.PropPaidDirectly)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.PropSurrendered)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.PropertyProvidedPlan)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.ProvidedPursuant)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.ResidenceorHomestead)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.SurrenderedPursuant)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.TrusteeAbandonProp)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.ValuedorStripped)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrCaseSummaries)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRCaseSummaryCaseBKRId");
    }
}
