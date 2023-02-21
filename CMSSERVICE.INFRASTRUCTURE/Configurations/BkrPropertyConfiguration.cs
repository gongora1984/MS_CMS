using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class BkrPropertyConfiguration : IEntityTypeConfiguration<BkrProperty>
{
    public void Configure(EntityTypeBuilder<BkrProperty> entity)
    {
        entity.ToTable(TableNames.BkrProperty);

        entity.HasIndex(e => e.CaseBkrId, "FKBKRPropertyCaseBKRId");

        entity.Property(e => e.Id).HasColumnName("BKRPropertyId");

        entity.Property(e => e.Address1)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(75)
        .IsUnicode(false);

        entity.Property(e => e.BkyClientPaymentAddress1)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.BkyClientPaymentAddress2)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.BkyClientPaymentCity)
            .HasMaxLength(60)
            .IsUnicode(false);

        entity.Property(e => e.BkyClientPaymentEmail)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.BkyClientPaymentPhone)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.Property(e => e.BkyClientPaymentState)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.BkyClientPaymentZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.BkycourtAddress1)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasColumnName("BKYCourtAddress1");

        entity.Property(e => e.BkycourtAddress2)
            .HasMaxLength(75)
            .IsUnicode(false)
            .HasColumnName("BKYCourtAddress2");

        entity.Property(e => e.BkycourtCity)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("BKYCourtCity");

        entity.Property(e => e.BkycourtEmail)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("BKYCourtEmail");

        entity.Property(e => e.BkycourtPhone)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasColumnName("BKYCourtPhone");

        entity.Property(e => e.BkycourtState)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("BKYCourtState");

        entity.Property(e => e.BkycourtZip)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasColumnName("BKYCourtZip");

        entity.Property(e => e.CaseBkrId).HasColumnName("CaseBKRId");

        entity.Property(e => e.City)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.PropertyName)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.State)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseBkr)
            .WithMany(p => p.BkrProperties)
            .HasForeignKey(d => d.CaseBkrId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKBKRPropertyCaseBKRId");
    }
}
