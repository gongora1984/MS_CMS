using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ZipCodeDictionaryConfiguration : IEntityTypeConfiguration<ZipCodeDictionary>
{
    public void Configure(EntityTypeBuilder<ZipCodeDictionary> entity)
    {
        entity.ToTable(TableNames.ZipCodeDictionary);

        entity.HasKey(e => e.Id).HasName("PKZipCodeDictionary");

        entity.Property(e => e.Id).HasColumnName("ZipCodeDictionaryId");

        entity.Property(e => e.Country)
            .HasMaxLength(255)
        .HasColumnName("country");

        entity.Property(e => e.County)
            .HasMaxLength(255)
        .HasColumnName("county");

        entity.Property(e => e.PrimaryCity)
            .HasMaxLength(255)
            .HasColumnName("primary_city");

        entity.Property(e => e.State)
            .HasMaxLength(255)
        .HasColumnName("state");

        entity.Property(e => e.Type)
            .HasMaxLength(255)
            .HasColumnName("type");

        entity.Property(e => e.Zip)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("zip");
    }
}
