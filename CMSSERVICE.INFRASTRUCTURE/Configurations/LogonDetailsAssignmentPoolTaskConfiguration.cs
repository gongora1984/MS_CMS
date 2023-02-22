using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LogonDetailsAssignmentPoolTaskConfiguration : IEntityTypeConfiguration<LogonDetailsAssignmentPoolTask>
{
    public void Configure(EntityTypeBuilder<LogonDetailsAssignmentPoolTask> entity)
    {
        entity.ToTable(TableNames.LogonDetailsAssignmentPoolTask);

        entity.HasKey(e => e.Id).HasName("PKLogonDetailsAssignmentPoolTask");

        entity.Property(e => e.Id).HasColumnName("LogonDetailsAssignmentPoolTaskId");

        entity.HasIndex(e => e.ClientAssignmentTaskId, "FKLogonDetailsAssignmentPoolTaskClientAssignmentTaskId");

        entity.HasIndex(e => e.LogonDetailsAssignmentPoolId, "FKLogonDetailsAssignmentPoolTaskLogonDetailsAssignmentPoolId");

        entity.HasOne(d => d.ClientAssignmentTask)
            .WithMany(p => p.LogonDetailsAssignmentPoolTasks)
            .HasForeignKey(d => d.ClientAssignmentTaskId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLogonDetailsAssignmentPoolTaskClientAssignmentTaskId");

        entity.HasOne(d => d.LogonDetailsAssignmentPool)
            .WithMany(p => p.LogonDetailsAssignmentPoolTasks)
            .HasForeignKey(d => d.LogonDetailsAssignmentPoolId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLogonDetailsAssignmentPoolTaskLogonDetailsAssignmentPoolId");
    }
}
