using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientStateLocationConfiguration : IEntityTypeConfiguration<ClientStateLocation>
{
    public void Configure(EntityTypeBuilder<ClientStateLocation> entity)
    {
        entity.ToTable(TableNames.ClientStateLocation);

        entity.HasKey(e => e.Id).HasName("PKClientStateLocation");

        entity.Property(e => e.Id).HasColumnName("ClientStateLocationId");

        entity.HasIndex(e => e.ClientId, "FKClientStateLocationClientId");

        entity.Property(e => e.Address1)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.DivisionName)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.Email)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.EntityName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.Fax)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasColumnName("fax");

        entity.Property(e => e.PaymentAdd1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.PaymentAdd2)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.PaymentCity)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PaymentEmail)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.PaymentFax)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.PaymentName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PaymentPhone)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.PaymentState)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.PaymentZip)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.Phone)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasColumnName("phone");

        entity.Property(e => e.StateId)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.WitnessBar)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.WitnessName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasColumnName("zip");

        entity.HasOne(d => d.Client)
            .WithMany(p => p.ClientStateLocations)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientStateLocationClientId");
    }
}
