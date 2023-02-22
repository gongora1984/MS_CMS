using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ThirdPartyConvertionConfiguration : IEntityTypeConfiguration<ThirdPartyConvertion>
{
    public void Configure(EntityTypeBuilder<ThirdPartyConvertion> entity)
    {
        entity.ToTable(TableNames.ThirdPartyConvertion);

        entity.HasKey(e => e.Id).HasName("PKThirdPartyConvertion");

        entity.Property(e => e.Id).HasColumnName("ThirdPartyConvertionId");

        entity.Property(e => e.ConvertionKey)
                    .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.ConvertionTag)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.ConvertionValue)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.ConvertionValue2)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.ConvertionValue3)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.LawPracticeId).HasDefaultValueSql("((1))");

        entity.Property(e => e.ThirdPartyName)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}
