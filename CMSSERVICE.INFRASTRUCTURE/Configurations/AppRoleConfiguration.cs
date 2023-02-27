using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
{
    public void Configure(EntityTypeBuilder<AppRole> entity)
    {
        entity.ToTable(TableNames.AppRole);

        entity.HasKey(e => e.Id).HasName("PKAppRole");

        entity.Property(e => e.Id).HasColumnName("AppRoleId");

        entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

        entity.HasData(new AppRole
        {
            Id = 1,
            Name = "Admin"
        });
    }
}
