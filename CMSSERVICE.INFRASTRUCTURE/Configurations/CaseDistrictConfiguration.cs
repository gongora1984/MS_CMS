using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseDistrictConfiguration : IEntityTypeConfiguration<CaseDistrict>
{
    public void Configure(EntityTypeBuilder<CaseDistrict> entity)
    {
        entity.ToTable(TableNames.CaseDistrict);

        entity.HasKey(e => e.Id).HasName("PKCaseDistrict");

        entity.Property(e => e.Id).HasColumnName("CaseDistrictId");

        entity.HasIndex(e => e.CaseStateId, "FKCaseDistrictCaseStateId");

        entity.Property(e => e.DistrictName)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.HasOne(d => d.CaseState)
            .WithMany(p => p.CaseDistricts)
            .HasForeignKey(d => d.CaseStateId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseDistrictCaseStateId");
    }
}
