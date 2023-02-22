using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientFacilityConfiguration : IEntityTypeConfiguration<ClientFacility>
{
    public void Configure(EntityTypeBuilder<ClientFacility> entity)
    {
        entity.ToTable(TableNames.ClientFacility);

        entity.HasKey(e => e.Id).HasName("PKClientFacility");

        entity.Property(e => e.Id).HasColumnName("ClientFacilityId");

        entity.HasIndex(e => e.ClientId, "FKClientFacilityClientId");

        entity.HasIndex(e => e.FacilityTypeLid, "FKClientFacilityFacilityTypeLid");

        entity.Property(e => e.Address1)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.Email)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.FacilityState)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.Fax)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Phone)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.Client)
            .WithMany(p => p.ClientFacilities)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientFacilityClientId");

        entity.HasOne(d => d.FacilityType)
            .WithMany(p => p.ClientFacilities)
            .HasForeignKey(d => d.FacilityTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientFacilityFacilityTypeLid");
    }
}
