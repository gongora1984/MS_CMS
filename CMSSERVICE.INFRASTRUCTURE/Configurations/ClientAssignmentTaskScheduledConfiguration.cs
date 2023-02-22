using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentTaskScheduledConfiguration : IEntityTypeConfiguration<ClientAssignmentTaskScheduled>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentTaskScheduled> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentTaskScheduled);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentTaskScheduled");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentTaskScheduledId");

        entity.HasIndex(e => e.ClientAssignmentTaskId, "FKClientAssignmentTaskScheduledClientAssignmentTaskId");

        entity.HasIndex(e => e.StartClientAssignmentTaskId, "FKClientAssignmentTaskStartClientAssignmentTaskId");

        entity.Property(e => e.AlertWhenStarted)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.LaunchTime)
            .HasMaxLength(8)
        .IsUnicode(false);

        entity.Property(e => e.RunScheduledOnStartNewAssign).HasDefaultValueSql("((0))");

        entity.HasOne(d => d.ClientAssignmentTask)
            .WithMany(p => p.ClientAssignmentTaskScheduledClientAssignmentTasks)
            .HasForeignKey(d => d.ClientAssignmentTaskId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentTaskScheduledClientAssignmentTaskId");

        entity.HasOne(d => d.StartClientAssignmentTask)
            .WithMany(p => p.ClientAssignmentTaskScheduledStartClientAssignmentTasks)
            .HasForeignKey(d => d.StartClientAssignmentTaskId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("RefClientAssignmentTask221");
    }
}
