using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrFinOtherCostConfiguration : IEntityTypeConfiguration<BkrFinOtherCost>
{
    public void Configure(EntityTypeBuilder<BkrFinOtherCost> entity)
    {
        entity.ToTable(TableNames.BkrFinOtherCost);

        entity.HasKey(e => e.Id).HasName("PKBkrFinOtherCost");

        entity.Property(e => e.Id).HasColumnName("BkrFinOtherCostId");

        entity.HasIndex(e => e.CaseBkrId, "FKBKRFinOtherCostCaseBKRId");

        entity.HasIndex(e => e.CostDecriptionLid, "FKBKRFinOtherCostCostDecriptionLid");

        entity.Property(e => e.Id).HasColumnName("BKROtherCostId");

        entity.Property(e => e.ActionNeededNote)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.CostAmount).HasColumnType("decimal(16, 2)");

        entity.Property(e => e.CostName)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.DateIncurred)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.Lpapproved).HasColumnName("LPApproved");

        entity.Property(e => e.OtherDescription)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.WriteOffNote)
            .HasMaxLength(400)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrFinOtherCosts)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRFinOtherCostCaseBKRId");

        entity.HasOne(d => d.CostDecription)
            .WithMany(p => p.BkrfinOtherCosts)
            .HasForeignKey(d => d.CostDecriptionLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRFinOtherCostCostDecriptionLid");
    }
}
