using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LogonDetailSubordinateConfiguration : IEntityTypeConfiguration<LogonDetailSubordinate>
{
    public void Configure(EntityTypeBuilder<LogonDetailSubordinate> entity)
    {
        entity.ToTable(TableNames.LogonDetailSubordinate);

        entity.HasKey(e => e.Id).HasName("PKLogonDetailSubordinate");

        entity.Property(e => e.Id).HasColumnName("LogonDetailSubordinateId");

        entity.HasIndex(e => e.LoginDetailId, "FKLogonDetailSubordinateLoginDetailId");

        entity.HasIndex(e => e.SubordinateLoginDetailsId, "FKLogonDetailSubordinateSubordinateLoginDetailsId");

        entity.Property(e => e.CanTakeAnyAssignment).HasColumnName("canTakeAnyAssignment");

        entity.Property(e => e.IsAvailible)
            .IsRequired()
            .HasColumnName("isAvailible")
        .HasDefaultValueSql("((1))");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.LogonDetailSubordinateLoginDetails)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLogonDetailSubordinateLoginDetailId");

        entity.HasOne(d => d.SubordinateLoginDetails)
            .WithMany(p => p.LogonDetailSubordinateSubordinateLoginDetails)
            .HasForeignKey(d => d.SubordinateLoginDetailsId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLogonDetailSubordinateSubordinateLoginDetailsId");
    }
}
