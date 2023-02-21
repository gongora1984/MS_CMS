using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrFinancialConfiguration : IEntityTypeConfiguration<BkrFinancial>
{
    public void Configure(EntityTypeBuilder<BkrFinancial> entity)
    {
        entity.ToTable(TableNames.BkrFinancial);

        entity.HasKey(x => x.Id).HasName("PKBkrFinancial");

        entity.Property(e => e.Id).HasColumnName("BkrFinancialId");

        entity.HasIndex(e => e.CaseBkrId, "FKBKRFinancialCaseBKRId");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.InsuranceAdvances).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.Interest).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.OtherFees).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PostAppraisalPrice).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PostAtTimeOfBkyfiling)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("PostAtTimeOfBKYFiling");

        entity.Property(e => e.PostAttyFeeBilled).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PostCurrentPayment).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PostFilingFee).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PostForcedInsurance).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PostInspectionfees).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PostTotalAttyFees).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PosttotalPetitionAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PreCountyPropertyAppraisal).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PreForcedInsurance).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PreMonthlyPymntAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PreNextPymntDue).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PrePayOffAmount).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PrePetitionRefund).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PrePetitionUnappliedFunds).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PreTotalAttyfees).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PreTotalPetitionAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.UnappliedFunds).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.UnpaidPrincipal).HasColumnType("decimal(18, 2)");

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrFinancials)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRFinancialCaseBKRId");
    }
}
