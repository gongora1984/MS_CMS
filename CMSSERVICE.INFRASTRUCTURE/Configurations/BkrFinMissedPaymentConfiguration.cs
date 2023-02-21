using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrFinMissedPaymentConfiguration : IEntityTypeConfiguration<BkrFinMissedPayment>
{
    public void Configure(EntityTypeBuilder<BkrFinMissedPayment> entity)
    {
        entity.ToTable(TableNames.BkrFinMissedPayment);

        entity.HasKey(e => e.Id).HasName("PKBkrFinMissedPayment");

        entity.Property(e => e.Id).HasColumnName("BkrFinMissedPaymentId");

        entity.HasIndex(e => e.CaseBkrId, "FKBKRFinMissedPaymentCaseBKRId");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.Mpescrow)
            .HasColumnType("decimal(18, 2)")
        .HasColumnName("MPEscrow");

        entity.Property(e => e.MpfromDate).HasColumnName("MPFromDate");

        entity.Property(e => e.MpnumberOfMissedPayments).HasColumnName("MPNumberOfMissedPayments");

        entity.Property(e => e.MppandI)
            .HasColumnType("decimal(18, 2)")
        .HasColumnName("MPPandI");

        entity.Property(e => e.MptoDate).HasColumnName("MPToDate");

        entity.Property(e => e.Mptotal)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("MPTotal");

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrFinMissedPayments)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRFinMissedPaymentCaseBKRId");
    }
}
