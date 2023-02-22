using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentScheduledConfiguration : IEntityTypeConfiguration<ClientAssignmentScheduled>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentScheduled> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentScheduled);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentScheduled");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentScheduledId");

        entity.HasIndex(e => e.ClientAssignmentTaskScheduledId, "FKClientAssignmentScheduledClientAssignmentTaskScheduledId");

        entity.HasIndex(e => e.ClientJobId, "FKClientAssignmentScheduledClientJobId");

        entity.HasIndex(e => e.FromClientAssignmentId, "FKClientAssignmentScheduledFromClientAssignmentId");

        entity.HasIndex(e => e.ClientAssignmentId, "FKClientAssignmentScheduledNewClientAssignmentId");

        entity.HasIndex(e => e.ProcessedBy, "FKClientAssignmentScheduledProcessedBy");

        entity.HasOne(d => d.ClientAssignment)
            .WithMany(p => p.ClientAssignmentScheduledClientAssignments)
            .HasForeignKey(d => d.ClientAssignmentId)
            .HasConstraintName("FKClientAssignmentScheduledNewClientAssignmentId");

        entity.HasOne(d => d.ClientAssignmentTaskScheduled)
            .WithMany(p => p.ClientAssignmentScheduleds)
            .HasForeignKey(d => d.ClientAssignmentTaskScheduledId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentScheduledClientAssignmentTaskScheduledId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.ClientAssignmentScheduleds)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentScheduledClientJobId");

        entity.HasOne(d => d.FromClientAssignment)
            .WithMany(p => p.ClientAssignmentScheduledFromClientAssignments)
            .HasForeignKey(d => d.FromClientAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentScheduledFromClientAssignmentId");

        entity.HasOne(d => d.ProcessedByNavigation)
            .WithMany(p => p.ClientAssignmentScheduleds)
            .HasForeignKey(d => d.ProcessedBy)
            .HasConstraintName("FKClientAssignmentScheduledProcessedBy");
    }
}
