using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleSpecialCountTemplateConfiguration : IEntityTypeConfiguration<CaseTitleSpecialCountTemplate>
{
    public void Configure(EntityTypeBuilder<CaseTitleSpecialCountTemplate> entity)
    {
        entity.ToTable(TableNames.CaseTitleSpecialCountTemplate);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleSpecialCountTemplate");

        entity.Property(e => e.Id).HasColumnName("CaseTitleSpecialCountTemplateId");

        entity.HasIndex(e => e.CountTypeLid, "FKCaseTitleSpecialCountTemplateCountTypeLid");

        entity.Property(e => e.Other).HasMaxLength(4000);

        entity.Property(e => e.StateId)
            .HasMaxLength(10)
        .IsUnicode(false);

        entity.Property(e => e.TitleSctmergeParagraphFj)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("TitleSCTMergeParagraphFJ");

        entity.Property(e => e.TitleSctmergeParagraphMsj)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("TitleSCTMergeParagraphMSJ");

        entity.Property(e => e.TitleSpecialCountTemplateName)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.TitleSpecialCountTemplateText)
            .HasMaxLength(4000)
        .IsUnicode(false);

        entity.Property(e => e.TitleSpecialCountTemplateTitle)
            .HasMaxLength(2000)
        .IsUnicode(false);

        entity.HasOne(d => d.CountType)
            .WithMany(p => p.CaseTitleSpecialCountTemplates)
            .HasForeignKey(d => d.CountTypeLid)
            .HasConstraintName("FKCaseTitleSpecialCountTemplateCountTypeLid");
    }
}
