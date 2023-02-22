using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseSaleConfiguration : IEntityTypeConfiguration<CaseSale>
{
    public void Configure(EntityTypeBuilder<CaseSale> entity)
    {
        entity.ToTable(TableNames.CaseSale);

        entity.HasKey(e => e.Id).HasName("PKCaseSale");

        entity.Property(e => e.Id).HasColumnName("CaseSaleId");

        entity.HasIndex(e => e.CancelReasonLid, "FKCaseSaleCancelReasonLid");

        entity.HasIndex(e => e.RescheduleReasonLid, "FKCaseSaleRescheduleReasonLid");

        entity.HasIndex(e => e.CaseSaleStatusLid, "FKCaseSaleStatusLid");

        entity.HasIndex(e => e.CaseFclid, "FK__CaseSale__CaseFCLId");

        entity.Property(e => e.Active).HasDefaultValueSql("((1))");

        entity.Property(e => e.BidAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.BidAssign)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.BidAssignAddr)
            .HasMaxLength(75)
        .IsUnicode(false);

        entity.Property(e => e.BidAssignCity)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.BidAssignState)
            .HasMaxLength(2)
        .IsUnicode(false);

        entity.Property(e => e.BidAssignZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.BidAssignedToId).HasColumnName("BidAssignedToID");

        entity.Property(e => e.Bidder)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CaseFclid).HasColumnName("CaseFCLId");

        entity.Property(e => e.Comments)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.IntegrationId1)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.IntegrationId2)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.PerDiem)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.PostSales3rdFunds).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PostSales3rdFundsRec).HasColumnType("date");

        entity.Property(e => e.PostSalesAmndCtrecorded)
            .HasColumnType("date")
            .HasColumnName("PostSalesAmndCTRecorded");

        entity.Property(e => e.PostSalesCertofSales).HasColumnType("date");

        entity.Property(e => e.PostSalesCertofTitle).HasColumnType("date");

        entity.Property(e => e.PostSalesCtrecorded)
            .HasColumnType("date")
            .HasColumnName("PostSalesCTRecorded");

        entity.Property(e => e.PostSalesObjection).HasColumnType("date");

        entity.Property(e => e.PreSaleDate).HasColumnType("date");

        entity.Property(e => e.PreSalePubRunDate1).HasColumnType("date");

        entity.Property(e => e.PreSalePubRunDate2).HasColumnType("date");

        entity.Property(e => e.PreSaleReqBidInst).HasColumnType("date");

        entity.Property(e => e.RescheduleDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.SaleAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.SaleDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.SaleHeldBidAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.SaleHeldBidInst)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.SaleHeldBidder)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.SaleHeldDate).HasColumnType("date");

        entity.Property(e => e.SuppJudgRecov).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.TotalCosts).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.TotalInterestDue)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.HasOne(d => d.CancelReason)
            .WithMany(p => p.CaseSaleCancelReasonLs)
            .HasForeignKey(d => d.CancelReasonLid)
            .HasConstraintName("FKCaseSaleCancelReasonLid");

        entity.HasOne(d => d.CaseFcl)
            .WithMany(p => p.CaseSales)
            .HasForeignKey(d => d.CaseFclid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__CaseSale__CaseFCLId");

        entity.HasOne(d => d.CaseSaleStatus)
            .WithMany(p => p.CaseSaleCaseSaleStatusLs)
            .HasForeignKey(d => d.CaseSaleStatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseSaleStatusLid");

        entity.HasOne(d => d.RescheduleReason)
            .WithMany(p => p.CaseSaleRescheduleReasonLs)
            .HasForeignKey(d => d.RescheduleReasonLid)
            .HasConstraintName("FKCaseSaleRescheduleReasonLid");
    }
}
