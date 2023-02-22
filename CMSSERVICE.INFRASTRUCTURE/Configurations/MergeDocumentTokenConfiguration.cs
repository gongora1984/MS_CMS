using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class MergeDocumentTokenConfiguration : IEntityTypeConfiguration<MergeDocumentToken>
{
    public void Configure(EntityTypeBuilder<MergeDocumentToken> entity)
    {
        entity.ToTable(TableNames.MergeDocumentToken);

        entity.HasKey(e => e.Id).HasName("PKMergeDocumentToken");

        entity.Property(e => e.Id).HasColumnName("MergeDocumentTokenId");

        entity.Property(e => e.MergeDocumentPath)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.MergeToken)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.SelectValueSql)
            .HasMaxLength(500)
            .IsUnicode(false);
    }
}
