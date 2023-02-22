using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class MergeDocumentConfiguration : IEntityTypeConfiguration<MergeDocument>
{
    public void Configure(EntityTypeBuilder<MergeDocument> entity)
    {
        entity.ToTable(TableNames.MergeDocument);

        entity.HasKey(e => e.Id).HasName("PKMergeDocument");

        entity.Property(e => e.Id).HasColumnName("MergeDocumentId");

        entity.Property(e => e.BitNoValue)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.BitYesValue)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.BlankDataValue)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.Category1)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.Category2)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.CodePageLocation)
            .HasMaxLength(400)
            .IsUnicode(false);

        entity.Property(e => e.CommonName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.JobTypeId).HasColumnName("jobTypeId");

        entity.Property(e => e.MergeDocumentName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.MergeThesePartyTypes)
            .HasMaxLength(400)
            .IsUnicode(false);

        entity.Property(e => e.OutFormat)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasDefaultValueSql("('docx')");

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.TemplateLocation)
            .HasMaxLength(400)
            .IsUnicode(false);
    }
}
