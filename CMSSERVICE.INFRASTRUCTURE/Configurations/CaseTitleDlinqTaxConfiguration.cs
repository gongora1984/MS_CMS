using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleDlinqTaxConfiguration : IEntityTypeConfiguration<CaseTitleDlinqTax>
{
    public void Configure(EntityTypeBuilder<CaseTitleDlinqTax> entity)
    {
        entity.ToTable(TableNames.CaseTitleDlinqTax);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleDlinqTax");

        entity.Property(e => e.Id).HasColumnName("CaseTitleDlinqTaxId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleDlinqTaxCaseTitleId");

        entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.TaxId)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleDlinqTaxes)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleDlinqTaxCaseTitleId");
    }
}
