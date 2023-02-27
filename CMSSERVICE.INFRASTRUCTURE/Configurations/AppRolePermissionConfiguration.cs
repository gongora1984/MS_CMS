using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class AppRolePermissionConfiguration : IEntityTypeConfiguration<AppRolePermission>
{
    public void Configure(EntityTypeBuilder<AppRolePermission> entity)
    {
        entity.ToTable(TableNames.AppRolePermission);

        entity.HasKey(e => e.Id).HasName("PKAppRolePermission");

        entity.Property(e => e.Id).HasColumnName("AppRolePermissionId");

        entity.HasIndex(e => e.AppPermissionId, "FKAppPermissionAppRolePermission");

        entity.HasIndex(e => e.AppRoleId, "FKAppRoleAppRolePermission");

        entity.HasIndex(e => new { e.AppPermissionId, e.AppRoleId }, "UXAppPermisionRole")
            .IsUnique();

        entity.HasOne(d => d.AppPermission)
                    .WithMany(p => p.AppRolePermissions)
                    .HasForeignKey(d => d.AppPermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKAppPermissionAppRolePermission");

        entity.HasOne(d => d.AppRole)
            .WithMany(p => p.AppRolePermissions)
            .HasForeignKey(d => d.AppRoleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKAppRoleAppRolePermission");

        ////int i = 1;
        ////entity.HasData(
        ////    Create(i++, AppRole.Admin, Permission.RegisterClient),
        ////    Create(i++, AppRole.Admin, Permission.RegisterLawPractice),
        ////    Create(i++, AppRole.Admin, Permission.RegisterLocalCounsel),
        ////    Create(i++, AppRole.Admin, Permission.RegisterAdmin));
    }

    ////private static AppRolePermission Create(
    ////    int id, AppRole role, Permission permission)
    ////{
    ////    return new AppRolePermission
    ////    {
    ////        Id = id,
    ////        AppRoleId = role.Id,
    ////        AppPermissionId = (int)permission
    ////    };
    ////}
}
