using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class MergeDocumentCustomConfiguration : IEntityTypeConfiguration<MergeDocumentCustom>
{
    public void Configure(EntityTypeBuilder<MergeDocumentCustom> entity)
    {
        entity.ToTable(TableNames.MergeDocumentCustom);

        entity.HasKey(e => e.Id).HasName("PKMergeDocumentCustom");

        entity.Property(e => e.Id).HasColumnName("MergeDocumentCustomId");

        entity.HasIndex(e => e.MergeDocumentId, "FKMergeDocumentCustomMergeDocumentId");

        entity.Property(e => e.BitNoValue)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.BitYesValue)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.BlankDataValue)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.CodePageLocation)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.TemplateLocation)
            .HasMaxLength(400)
            .IsUnicode(false);

        entity.HasOne(d => d.MergeDocument)
            .WithMany(p => p.MergeDocumentCustoms)
            .HasForeignKey(d => d.MergeDocumentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKMergeDocumentCustomMergeDocumentId");
    }
}
