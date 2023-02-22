using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LoginDetailsAccessRoleConfiguration : IEntityTypeConfiguration<LoginDetailsAccessRole>
{
    public void Configure(EntityTypeBuilder<LoginDetailsAccessRole> entity)
    {
        entity.ToTable(TableNames.LoginDetailsAccessRole);

        entity.HasKey(e => e.Id).HasName("PKLoginDetailsAccessRole");

        entity.Property(e => e.Id).HasColumnName("LoginDetailsAccessRoleId");

        entity.HasIndex(e => e.AccessFieldLid, "FKLoginDetailsAccessRoleAccessFieldLid");

        entity.HasIndex(e => e.LoginDetailId, "FKLoginDetailsAccessRoleLoginDetailId");

        entity.Property(e => e.AccessFieldClass)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.AccessFieldName)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.AccessFieldValue)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.HasOne(d => d.AccessField)
            .WithMany(p => p.LoginDetailsAccessRoles)
            .HasForeignKey(d => d.AccessFieldLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLoginDetailsAccessRoleAccessFieldLid");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.LoginDetailsAccessRoles)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLoginDetailsAccessRoleLoginDetailId");
    }
}
