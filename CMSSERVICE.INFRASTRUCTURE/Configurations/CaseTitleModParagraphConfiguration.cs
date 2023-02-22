using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleModParagraphConfiguration : IEntityTypeConfiguration<CaseTitleModParagraph>
{
    public void Configure(EntityTypeBuilder<CaseTitleModParagraph> entity)
    {
        entity.ToTable(TableNames.CaseTitleModParagraph);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleModParagraph");

        entity.Property(e => e.Id).HasColumnName("CaseTitleModParagraphId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleModParagraphCaseTitleId");

        entity.Property(e => e.Book)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.Intrument)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.ModificationAmount).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.Page)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleModParagraphs)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleModParagraphCaseTitleId");
    }
}
