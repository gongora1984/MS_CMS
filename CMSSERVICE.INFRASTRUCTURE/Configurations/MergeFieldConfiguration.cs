using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class MergeFieldConfiguration : IEntityTypeConfiguration<MergeField>
{
    public void Configure(EntityTypeBuilder<MergeField> entity)
    {
        entity.ToTable(TableNames.MergeField);

        entity.HasKey(e => e.Id).HasName("PKMergeField");

        entity.Property(e => e.Id).HasColumnName("MergeFieldId");

        entity.Property(e => e.MergeFieldName)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.MergeToken)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.MissingValueQuestion)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.TableName)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.UpdateValueSql)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("UpdateValueSQL");
    }
}
