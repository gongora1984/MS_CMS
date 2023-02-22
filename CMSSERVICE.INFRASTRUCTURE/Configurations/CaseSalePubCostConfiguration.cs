using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseSalePubCostConfiguration : IEntityTypeConfiguration<CaseSalePubCost>
{
    public void Configure(EntityTypeBuilder<CaseSalePubCost> entity)
    {
        entity.ToTable(TableNames.CaseSalePubCost);

        entity.HasKey(e => e.Id).HasName("PKCaseSalePubCost");

        entity.Property(e => e.Id).HasColumnName("CaseSalePubCostId");

        entity.HasIndex(e => e.CaseSaleId, "FK__CaseSalePubCosts__CaseSaleId");

        entity.Property(e => e.PubCost).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PubDate).HasColumnType("date");

        entity.HasOne(d => d.CaseSale)
            .WithMany(p => p.CaseSalePubCosts)
            .HasForeignKey(d => d.CaseSaleId)
            .HasConstraintName("FK__CaseSalePubCosts__CaseSaleId");
    }
}
