using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseCountyConfiguration : IEntityTypeConfiguration<CaseCounty>
{
    public void Configure(EntityTypeBuilder<CaseCounty> entity)
    {
        entity.ToTable(TableNames.CaseCounty);

        entity.HasKey(e => e.Id).HasName("PKCaseCounty");

        entity.Property(e => e.Id).HasColumnName("CaseCountyId");

        entity.HasIndex(e => e.CaseStateId, "FKCaseCountyCaseStateId");

        entity.Property(e => e.County)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.HasOne(d => d.CaseState)
            .WithMany(p => p.CaseCounties)
            .HasForeignKey(d => d.CaseStateId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCountyCaseStateId");
    }
}
