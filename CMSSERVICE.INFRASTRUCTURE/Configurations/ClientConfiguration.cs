using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> entity)
    {
        entity.ToTable(TableNames.Client);

        entity.HasKey(e => e.Id).HasName("PKClient");

        entity.Property(e => e.Id).HasColumnName("ClientId");

        entity.HasIndex(e => e.ClientTypeLid, "FKClientTypeId");

        entity.Property(e => e.ClientAddress1)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.ClientAddress2)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.ClientBillAddress1)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.ClientBillAddress2)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.ClientBillCity)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.ClientBillState)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.ClientBillZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.ClientCity)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.ClientFax)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.ClientLogoLocation)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.ClientMailAlertLogEmail)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.ClientMainContact)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.ClientName)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.ClientPhone)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.ClientState)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.ClientZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.GlobeClientCode)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.IsReverseClient).HasDefaultValueSql("((0))");

        entity.Property(e => e.ProvestClientCode)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.UseNativeTasksOnly).HasColumnName("useNativeTasksOnly");

        entity.HasOne(d => d.ClientTypeL)
            .WithMany(p => p.Clients)
            .HasForeignKey(d => d.ClientTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientTypeId");
    }
}
