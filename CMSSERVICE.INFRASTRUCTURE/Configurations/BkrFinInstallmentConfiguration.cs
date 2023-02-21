using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrFinInstallmentConfiguration : IEntityTypeConfiguration<BkrFinInstallment>
{
    public void Configure(EntityTypeBuilder<BkrFinInstallment> entity)
    {
        entity.HasKey(e => e.Id)
                    .HasName("PK_FileBankruptcyFinInstallment");

        entity.ToTable(TableNames.BkrFinInstallment);

        entity.HasIndex(e => e.CaseBkrId, "FKBKRFinInstallmentCaseBKRId");

        entity.Property(e => e.Id).HasColumnName("BKRFinInstallmentsId");

        entity.Property(e => e.AmountofInstallments).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.DateofInstallment)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.TotalInstallmentAmount).HasColumnType("decimal(18, 2)");

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrFinInstallments)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRFinInstallmentCaseBKRId");
    }
}
