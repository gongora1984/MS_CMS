using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class GarnisheeConfiguration : IEntityTypeConfiguration<Garnishee>
{
    public void Configure(EntityTypeBuilder<Garnishee> entity)
    {
        entity.ToTable(TableNames.Garnishee);

        entity.HasKey(e => e.Id).HasName("PKGarnishee");

        entity.Property(e => e.Id).HasColumnName("GarnisheeId");

        entity.HasIndex(e => e.ClientId, "FKGarnisheeClientId");

        entity.Property(e => e.GarnisheeAddress1)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.GarnisheeAddress2)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.GarnisheeCity)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.GarnisheeFax)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.GarnisheeName)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.GarnisheePhone)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.GarnisheeState)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.GarnisheeZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.Client)
            .WithMany(p => p.Garnishees)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKGarnisheeClientId");
    }
}
