using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseAutoConfiguration : IEntityTypeConfiguration<CaseAuto>
{
    public void Configure(EntityTypeBuilder<CaseAuto> entity)
    {
        entity.ToTable(TableNames.CaseAuto);

        entity.HasIndex(e => e.AssignedCsrlid, "FKCaseAutoAssignedCSRLid");

        entity.HasIndex(e => e.ClientJobId, "FKCaseAutoClientJobId");

        entity.HasIndex(e => e.ClosedReasonLid, "FKCaseAutoClosedReasonLid");

        entity.HasIndex(e => e.CaseAutoStatusLid, "FKCaseAutoStatusLid");

        entity.HasIndex(e => e.VehicleStatusLid, "FKCaseAutoVehicleStatusLid");

        entity.Property(e => e.AssignedCsrlid).HasColumnName("AssignedCSRLid");

        entity.Property(e => e.GuaranteedAmount).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.InternalStockRefNum)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.Location)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.LpreferenceId)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("LPReferenceId");

        entity.Property(e => e.MmrestimatedValue)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("MMREstimatedValue");

        entity.Property(e => e.RetailValue).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.TitleTransferDate)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.VehicleMake)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.VehicleModel)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.VehicleTrim)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.VehicleVinNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.VehicleYear)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.HasOne(d => d.AssignedCsrl)
            .WithMany(p => p.CaseAutoAssignedCsrls)
            .HasForeignKey(d => d.AssignedCsrlid)
            .HasConstraintName("FKCaseAutoAssignedCSRLid");

        entity.HasOne(d => d.CaseAutoStatus)
            .WithMany(p => p.CaseAutoCaseAutoStatusLs)
            .HasForeignKey(d => d.CaseAutoStatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseAutoStatusLid");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseAutos)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseAutoClientJobId");

        entity.HasOne(d => d.ClosedReason)
            .WithMany(p => p.CaseAutoClosedReasonLs)
            .HasForeignKey(d => d.ClosedReasonLid)
            .HasConstraintName("FKCaseAutoClosedReasonLid");

        entity.HasOne(d => d.VehicleStatus)
            .WithMany(p => p.CaseAutoVehicleStatusLs)
            .HasForeignKey(d => d.VehicleStatusLid)
            .HasConstraintName("FKCaseAutoVehicleStatusLid");
    }
}
