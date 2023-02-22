using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentTaskRecurrenceConfiguration : IEntityTypeConfiguration<ClientAssignmentTaskRecurrence>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentTaskRecurrence> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentTaskRecurrence);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentTaskRecurrence");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentTaskRecurrenceId");

        entity.HasIndex(e => e.ClientAssignmentTaskScheduledId, "FK_ClientAssignmentTaskRecurrence_ClientAssignmentTaskScheduled");

        entity.Property(e => e.CreatedBy)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.CreatedDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("(getdate())")
        .IsFixedLength();

        entity.Property(e => e.Day)
            .HasMaxLength(10)
        .IsUnicode(false);

        entity.Property(e => e.EndDate)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.Friday).HasDefaultValueSql("((0))");

        entity.Property(e => e.Monday).HasDefaultValueSql("((0))");

        entity.Property(e => e.RecurrenceType)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.Property(e => e.StartDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.Thursday).HasDefaultValueSql("((0))");

        entity.Property(e => e.Tuesday).HasDefaultValueSql("((0))");

        entity.Property(e => e.UpdateBy)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.UpdateDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("(getdate())")
            .IsFixedLength();

        entity.Property(e => e.Wednesday).HasDefaultValueSql("((0))");

        entity.HasOne(d => d.ClientAssignmentTaskScheduled)
            .WithMany(p => p.ClientAssignmentTaskRecurrences)
            .HasForeignKey(d => d.ClientAssignmentTaskScheduledId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ClientAssignmentTaskRecurrence_ClientAssignmentTaskScheduled");
    }
}
