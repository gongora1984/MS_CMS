using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleUnderWriterConfiguration : IEntityTypeConfiguration<CaseTitleUnderWriter>
{
    public void Configure(EntityTypeBuilder<CaseTitleUnderWriter> entity)
    {
        entity.ToTable(TableNames.CaseTitleUnderWriter);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleUnderWriter");

        entity.Property(e => e.Id).HasColumnName("CaseTitleUnderWriterId");

        entity.Property(e => e.SendEmail)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.SendUps).HasColumnName("SendUPS");

        entity.Property(e => e.UnderWriterAddress1)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.UnderWriterAddress2)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.UnderWriterAttentionTo)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.UnderWriterCity)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.UnderWriterName)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.UnderWriterSendVia)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("UnderWriterSendVIA");

        entity.Property(e => e.UnderWriterState)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.UnderWriterZip)
            .HasMaxLength(15)
            .IsUnicode(false);
    }
}
