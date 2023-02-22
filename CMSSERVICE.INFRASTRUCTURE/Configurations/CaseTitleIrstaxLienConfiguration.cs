using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleIrstaxLienConfiguration : IEntityTypeConfiguration<CaseTitleIrstaxLien>
{
    public void Configure(EntityTypeBuilder<CaseTitleIrstaxLien> entity)
    {
        entity.ToTable(TableNames.CaseTitleIrstaxLien);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleIrstaxLien");

        entity.Property(e => e.Id).HasColumnName("CaseTitleIrstaxLienId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleIRSTaxLienCaseTitleId");

        entity.Property(e => e.FileAgainst)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.FileBy)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.IrsformNo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("IRSFormNo");

        entity.Property(e => e.LienAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.Page)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.Priority)
            .HasMaxLength(10)
        .IsUnicode(false);

        entity.Property(e => e.SsntaxId)
            .HasMaxLength(11)
            .IsUnicode(false)
            .HasColumnName("SSNTaxID");

        entity.Property(e => e.Volume)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleIrstaxLiens)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleIRSTaxLienCaseTitleId");
    }
}
