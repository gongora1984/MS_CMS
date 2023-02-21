using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrPaymentChangeConfiguration : IEntityTypeConfiguration<BkrPaymentChange>
{
    public void Configure(EntityTypeBuilder<BkrPaymentChange> entity)
    {
        entity.ToTable(TableNames.BkrPaymentChange);

        entity.HasKey(e => e.Id).HasName("PKBkrPaymentChange");

        entity.Property(e => e.Id).HasColumnName("BKRPaymentChangeId");

        entity.HasIndex(e => e.CaseBkrId, "FKBKRPaymentChangeCaseBKRId");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.CurrentEscrowPayment).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.CurrentInterestRate).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.CurrentMrtgPmnt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.CurrentPrincipalAndInterestRate).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.NewEscrowPayment).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.NewInterestRate).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.NewMrtgPmnt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.NewPrincipalAndInterestRate).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.NewTotalPayment).HasColumnType("decimal(18, 2)");

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrPaymentChanges)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRPaymentChangeCaseBKRId");
    }
}
