using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrDistrictConfiguration : IEntityTypeConfiguration<BkrDistrict>
{
    public void Configure(EntityTypeBuilder<BkrDistrict> entity)
    {
        entity.ToTable(TableNames.BkrDistrict);

        entity.HasKey(x => x.Id).HasName("PKBkrDistrict");

        entity.Property(e => e.Id).HasColumnName("BkrDistrictId");

        entity.Property(e => e.ClientBkcourtJurisdiction)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ClientBKCourtJurisdiction");

        entity.Property(e => e.DistrictName)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.ListOrder).HasDefaultValueSql("((1))");

        entity.Property(e => e.StateId)
            .HasMaxLength(15)
            .IsUnicode(false);
    }
}
