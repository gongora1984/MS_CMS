using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseStateConfiguration : IEntityTypeConfiguration<CaseState>
{
    public void Configure(EntityTypeBuilder<CaseState> entity)
    {
        entity.ToTable(TableNames.CaseState);

        entity.HasKey(e => e.Id).HasName("PKCaseState");

        entity.Property(e => e.Id).HasColumnName("CaseStateId");

        entity.Property(e => e.StateAbbrev)
            .HasMaxLength(2)
        .IsUnicode(false);

        entity.Property(e => e.StateName)
            .HasMaxLength(100)
            .IsUnicode(false);
    }
}
