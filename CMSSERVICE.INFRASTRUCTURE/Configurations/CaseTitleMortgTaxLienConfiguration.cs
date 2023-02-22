using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal class CaseTitleMortgTaxLienConfiguration : IEntityTypeConfiguration<CaseTitleMortgTaxLien>
{
    public void Configure(EntityTypeBuilder<CaseTitleMortgTaxLien> entity)
    {
        entity.ToTable(TableNames.CaseTitleMortgTaxLien);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleMortgTaxLien");

        entity.Property(e => e.Id).HasColumnName("CaseTitleMortgTaxLienId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleMortgTaxLienCaseTitleId");

        entity.HasIndex(e => e.LienTypeLid, "FKCaseTitleMortgTaxLienLienTypeLid");

        entity.Property(e => e.FileBy)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.LienAmt).HasColumnType("decimal(18, 2)");

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
            .WithMany(p => p.CaseTitleMortgTaxLiens)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleMortgTaxLienCaseTitleId");

        entity.HasOne(d => d.LienType)
            .WithMany(p => p.CaseTitleMortgTaxLiens)
            .HasForeignKey(d => d.LienTypeLid)
            .HasConstraintName("FKCaseTitleMortgTaxLienLienTypeLid");
    }
}
