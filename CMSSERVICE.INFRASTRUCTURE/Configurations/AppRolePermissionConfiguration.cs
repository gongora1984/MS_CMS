using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Enums;
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

        entity.HasData(
            Create(AppRole.Admin, Permission.RegisterClient),
            Create(AppRole.Admin, Permission.RegisterLawPractice),
            Create(AppRole.Admin, Permission.RegisterLocalCounsel),
            Create(AppRole.Admin, Permission.RegisterAdmin));
    }

    private static AppRolePermission Create(
        AppRole role, Permission permission)
    {
        return new AppRolePermission
        {
            AppRoleId = role.Id,
            AppPermissionId = (int)permission
        };
    }
}
