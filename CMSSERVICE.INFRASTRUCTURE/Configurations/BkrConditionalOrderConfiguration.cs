using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrConditionalOrderConfiguration : IEntityTypeConfiguration<BkrConditionalOrder>
{
    public void Configure(EntityTypeBuilder<BkrConditionalOrder> entity)
    {
        entity.HasKey(e => e.Id)
                    .HasName("PK_FileBankruptcyConditionalOrder");

        entity.ToTable(TableNames.BkrConditionalOrder);

        entity.HasIndex(e => e.CaseBkrId, "FKBKRConditionalOrderCaseBKRId");

        entity.Property(e => e.AttysFeesAndCosts).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.MnthlyPymntAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PaymentsDueAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PaymentsDueTotal).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.TotalDelinquency).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.TotalDueDiv6Months).HasColumnType("decimal(18, 2)");

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrConditionalOrders)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRConditionalOrderCaseBKRId");
    }
}
