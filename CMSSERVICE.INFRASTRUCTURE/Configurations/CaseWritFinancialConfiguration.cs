using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseWritFinancialConfiguration : IEntityTypeConfiguration<CaseWritFinancial>
{
    public void Configure(EntityTypeBuilder<CaseWritFinancial> entity)
    {
        entity.ToTable(TableNames.CaseWritFinancial);

        entity.HasKey(e => e.Id).HasName("PKCaseWritFinancial");

        entity.Property(e => e.Id).HasColumnName("CaseWritFinancialId");

        entity.HasIndex(e => e.AcctStatusLid, "FKCaseWritFinancialAcctStatusLid");

        entity.HasIndex(e => e.AcctStylingLid, "FKCaseWritFinancialAcctStylingLid");

        entity.HasIndex(e => e.CaseWritId, "FKCaseWritFinancialCaseWritId");

        entity.Property(e => e.AcctHolderName)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.AcctLast4)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.AcctNotes)
            .HasMaxLength(4500)
        .IsUnicode(false);

        entity.Property(e => e.AmtOnHold).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.AmtinAcct).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.ExemptionAmount).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.FedBenefitsOverLookback).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.ProtectedAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.TotalAmtOnHold).HasColumnType("decimal(18, 2)");

        entity.HasOne(d => d.AcctStatus)
            .WithMany(p => p.CaseWritFinancialAcctStatusLs)
            .HasForeignKey(d => d.AcctStatusLid)
            .HasConstraintName("FKCaseWritFinancialAcctStatusLid");

        entity.HasOne(d => d.AcctStyling)
            .WithMany(p => p.CaseWritFinancialAcctStylingLs)
            .HasForeignKey(d => d.AcctStylingLid)
            .HasConstraintName("FKCaseWritFinancialAcctStylingLid");

        entity.HasOne(d => d.CaseWrit)
            .WithMany(p => p.CaseWritFinancials)
            .HasForeignKey(d => d.CaseWritId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseWritFinancialCaseWritId");
    }
}
