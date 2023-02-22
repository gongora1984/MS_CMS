using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LogonDetailsAssignmentPoolConfiguration : IEntityTypeConfiguration<LogonDetailsAssignmentPool>
{
    public void Configure(EntityTypeBuilder<LogonDetailsAssignmentPool> entity)
    {
        entity.ToTable(TableNames.LogonDetailsAssignmentPool);

        entity.HasKey(e => e.Id).HasName("PKLogonDetailsAssignmentPool");

        entity.Property(e => e.Id).HasColumnName("LogonDetailsAssignmentPoolId");

        entity.HasIndex(e => e.ClientAssignmentTaskId, "FKLogonDetailsAssignmentPoolClientAssignmentTaskId");

        entity.HasIndex(e => e.LoginDetailId, "FKLogonDetailsAssignmentPoolLoginDetailId");

        entity.HasIndex(e => e.UseReportId, "FKLogonDetailsAssignmentPoolUseReportId");

        entity.Property(e => e.CpadditionalSql)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("CPAdditionalSql");

        entity.Property(e => e.IsAvailible)
            .IsRequired()
            .HasColumnName("isAvailible")
        .HasDefaultValueSql("((1))");

        entity.Property(e => e.IsQueueAdmin).HasColumnName("isQueueAdmin");

        entity.HasOne(d => d.ClientAssignmentTask)
            .WithMany(p => p.LogonDetailsAssignmentPools)
            .HasForeignKey(d => d.ClientAssignmentTaskId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLogonDetailsAssignmentPoolClientAssignmentTaskId");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.LogonDetailsAssignmentPools)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLogonDetailsAssignmentPoolLoginDetailId");

        entity.HasOne(d => d.UseReport)
            .WithMany(p => p.LogonDetailsAssignmentPools)
            .HasForeignKey(d => d.UseReportId)
            .HasConstraintName("FKLogonDetailsAssignmentPoolUseReportId");
    }
}
