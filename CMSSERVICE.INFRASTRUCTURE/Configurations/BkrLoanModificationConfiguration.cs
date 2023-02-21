using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrLoanModificationConfiguration : IEntityTypeConfiguration<BkrLoanModification>
{
    public void Configure(EntityTypeBuilder<BkrLoanModification> entity)
    {
        entity.ToTable(TableNames.BkrLoanModification);

        entity.HasIndex(e => e.CaseBkrId, "FKBKRLoanModificationCaseBKRId");

        entity.Property(e => e.Id).HasColumnName("BKRLoanModificationId");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.ModifiedInterestRate).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.NewUnpaidPrincipalBal).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PrincipalAndInterest).HasColumnType("decimal(18, 2)");

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrLoanModifications)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRLoanModificationCaseBKRId");
    }
}
