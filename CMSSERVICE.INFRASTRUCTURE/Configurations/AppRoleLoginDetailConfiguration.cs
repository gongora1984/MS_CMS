using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class AppRoleLoginDetailConfiguration : IEntityTypeConfiguration<AppRoleLoginDetail>
{
    public void Configure(EntityTypeBuilder<AppRoleLoginDetail> entity)
    {
        entity.ToTable(TableNames.AppRoleLoginDetail);

        entity.HasKey(e => e.Id).HasName("PKAppRoleLoginDetail");

        entity.Property(e => e.Id).HasColumnName("AppRoleLoginDetailId");

        entity.HasIndex(e => e.AppRoleId, "FKAppRoleAppRoleLoginDetail");

        entity.HasIndex(e => e.LoginDetailId, "FKLoginDetailAppRoleLoginDetail");

        entity.HasIndex(e => new { e.AppRoleId, e.LoginDetailId }, "UXAppRoleLoginDetail")
        .IsUnique();

        entity.HasOne(d => d.AppRole)
            .WithMany(p => p.AppRoleLoginDetails)
            .HasForeignKey(d => d.AppRoleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKAppRoleAppRoleLoginDetail");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.AppRoleLoginDetails)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLoginDetailAppRoleLoginDetail");
    }
}
