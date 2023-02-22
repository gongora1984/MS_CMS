using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseSalePubDateConfiguration : IEntityTypeConfiguration<CaseSalePubDate>
{
    public void Configure(EntityTypeBuilder<CaseSalePubDate> entity)
    {
        entity.ToTable(TableNames.CaseSalePubDate);

        entity.HasKey(e => e.Id).HasName("PKCaseSalePubDate");

        entity.Property(e => e.Id).HasColumnName("CaseSalePubDateId");

        entity.HasIndex(e => e.CaseSaleId, "FK__CaseSalePubDates__CaseSaleId");

        entity.Property(e => e.PubDate).HasColumnType("date");

        entity.Property(e => e.PubCompany)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.HasOne(d => d.CaseSale)
            .WithMany(p => p.CaseSalePubDates)
            .HasForeignKey(d => d.CaseSaleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__CaseSalePubDates__CaseSaleId");
    }
}
