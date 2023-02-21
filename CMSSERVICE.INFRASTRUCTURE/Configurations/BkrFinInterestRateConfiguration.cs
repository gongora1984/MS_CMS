using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrFinInterestRateConfiguration : IEntityTypeConfiguration<BkrFinInterestRate>
{
    public void Configure(EntityTypeBuilder<BkrFinInterestRate> entity)
    {
        entity.ToTable(TableNames.BkrFinInterestRate);

        entity.HasIndex(e => e.CaseBkrId, "FKBKRFinInterestRateCaseBKRId");

        entity.Property(e => e.Id).HasColumnName("BKRFinInterestRateId");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.InterestRate).HasColumnType("decimal(18, 3)");

        entity.Property(e => e.IrfromDate).HasColumnName("IRFromDate");

        entity.Property(e => e.Irtotal)
            .HasColumnType("decimal(18, 2)")
        .HasColumnName("IRTotal");

        entity.Property(e => e.IttoDate).HasColumnName("ITToDate");

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrFinInterestRates)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRFinInterestRateCaseBKRId");
    }
}
