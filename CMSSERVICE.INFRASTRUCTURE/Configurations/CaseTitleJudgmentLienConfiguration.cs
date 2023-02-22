using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleJudgmentLienConfiguration : IEntityTypeConfiguration<CaseTitleJudgmentLien>
{
    public void Configure(EntityTypeBuilder<CaseTitleJudgmentLien> entity)
    {
        entity.ToTable(TableNames.CaseTitleJudgmentLien);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleJudgmentLien");

        entity.Property(e => e.Id).HasColumnName("CaseTitleJudgmentLienId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleJudgmentLienCaseTitleId");

        entity.Property(e => e.AttachmentAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.AttachmentPage)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.AttachmentVolume)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.FileBy)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.JudgmentCostAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.JudgmentDamageAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.Page)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.Priority)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.Property(e => e.Volume)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleJudgmentLiens)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleJudgmentLienCaseTitleId");
    }
}
