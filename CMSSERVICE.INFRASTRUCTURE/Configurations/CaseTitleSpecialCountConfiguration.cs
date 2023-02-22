using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleSpecialCountConfiguration : IEntityTypeConfiguration<CaseTitleSpecialCount>
{
    public void Configure(EntityTypeBuilder<CaseTitleSpecialCount> entity)
    {
        entity.ToTable(TableNames.CaseTitleSpecialCount);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleSpecialCount");

        entity.Property(e => e.Id).HasColumnName("CaseTitleSpecialCountId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleSpecialCountCaseTitleId");

        entity.HasIndex(e => e.CaseTitleSpecialCountTemplateId, "FKCaseTitleSpecialCountCaseTitleSpecialCountTemplateId");

        entity.Property(e => e.Book)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.ByVirtueOf)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.Grantees)
            .HasMaxLength(1000)
        .IsUnicode(false);

        entity.Property(e => e.Grantors)
            .HasMaxLength(1000)
        .IsUnicode(false);

        entity.Property(e => e.Page)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.TitleSpecialCountText).IsUnicode(false);

        entity.Property(e => e.TitleSpecialCountTitle)
            .HasMaxLength(2000)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleSpecialCounts)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleSpecialCountCaseTitleId");

        entity.HasOne(d => d.CaseTitleSpecialCountTemplate)
            .WithMany(p => p.CaseTitleSpecialCounts)
            .HasForeignKey(d => d.CaseTitleSpecialCountTemplateId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleSpecialCountCaseTitleSpecialCountTemplateId");
    }
}
