using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class AppPermissionConfiguration : IEntityTypeConfiguration<AppPermission>
{
    public void Configure(EntityTypeBuilder<AppPermission> entity)
    {
        entity.ToTable(TableNames.AppPermission);

        entity.HasKey(e => e.Id).HasName("PKAppPermission");

        entity.Property(e => e.Id).HasColumnName("AppPermissionId");

        entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

        ////IEnumerable<AppPermission> permissions = Enum
        ////    .GetValues<Permission>()
        ////    .Select(p => new AppPermission
        ////    {
        ////        Id = (int)p,
        ////        Name = p.ToString()
        ////    });

        ////entity.HasData(permissions);
    }
}
