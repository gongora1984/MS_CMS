using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentConfiguration : IEntityTypeConfiguration<ClientAssignment>
{
    public void Configure(EntityTypeBuilder<ClientAssignment> entity)
    {
        entity.ToTable(TableNames.ClientAssignment);

        entity.HasKey(e => e.Id).HasName("PKClientAssignment");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentId");

        entity.HasIndex(e => e.AssignedTo, "FKClientAssignmentAssignedTo");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKClientAssignmentCaseJobDefendantId");

        entity.HasIndex(e => e.ChainCompletedBy, "FKClientAssignmentChainCompletedBy");

        entity.HasIndex(e => e.ClientAssignmentTaskId, "FKClientAssignmentClientAssignmentTaskId");

        entity.HasIndex(e => e.ClientJobId, "FKClientAssignmentClientJobId");

        entity.HasIndex(e => e.CompleteDocumentRepositoryId, "FKClientAssignmentCompleteDocumentRepositoryId");

        entity.HasIndex(e => e.CompletedBy, "FKClientAssignmentCompletedBy");

        entity.HasIndex(e => e.CreatedBy, "FKClientAssignmentCreatedBy");

        entity.HasIndex(e => e.LastAccessBy, "FKClientAssignmentLastAccessBy");

        entity.HasIndex(e => e.ReprojectedBy, "FKClientAssignmentReprojectedBy");

        entity.HasIndex(e => e.StartedDocumentRepositoryId, "FKClientAssignmentStartedDocumentRepositoryId");

        entity.HasIndex(e => e.UpdatedBy, "FKClientAssignmentUpdatedBy");

        entity.HasIndex(e => e.VoidedBy, "FKClientAssignmentVoidedBy");

        entity.HasIndex(e => e.ParentAssignmentId, "Ref81194");

        entity.HasIndex(e => e.ChainCompletedAssignmentId, "Ref81208");

        entity.HasIndex(e => e.StartedByAssignmentId, "Ref81210");

        entity.Property(e => e.AssociatedMileStones)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.AttyCompleteCode)
            .HasMaxLength(10)
        .IsUnicode(false);

        entity.Property(e => e.AttyCompleteCodeEnc)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.AutomationId1)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.AutomationId2)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CompleteNotes)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.CreatedNote)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.EventAmount).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.EventType)
            .HasMaxLength(1)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.IntegrationId)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.IntegrationKey)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.IntegrationOther)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.IsVoided).HasColumnName("isVoided");

        entity.Property(e => e.ProgressNotes)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.StartTasksOnComplete)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.HasOne(d => d.AssignedToNavigation)
            .WithMany(p => p.ClientAssignmentAssignedToNavigations)
            .HasForeignKey(d => d.AssignedTo)
            .HasConstraintName("FKClientAssignmentAssignedTo");

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.ClientAssignments)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .HasConstraintName("FKClientAssignmentCaseJobDefendantId");

        entity.HasOne(d => d.ChainCompletedAssignment)
            .WithMany(p => p.InverseChainCompletedAssignment)
            .HasForeignKey(d => d.ChainCompletedAssignmentId)
            .HasConstraintName("RefClientAssignment208");

        entity.HasOne(d => d.ChainCompletedByNavigation)
            .WithMany(p => p.ClientAssignmentChainCompletedByNavigations)
            .HasForeignKey(d => d.ChainCompletedBy)
            .HasConstraintName("FKClientAssignmentChainCompletedBy");

        entity.HasOne(d => d.ClientAssignmentTask)
            .WithMany(p => p.ClientAssignments)
            .HasForeignKey(d => d.ClientAssignmentTaskId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentClientAssignmentTaskId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.ClientAssignments)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentClientJobId");

        entity.HasOne(d => d.CompleteDocumentRepository)
            .WithMany(p => p.ClientAssignmentCompleteDocumentRepositories)
            .HasForeignKey(d => d.CompleteDocumentRepositoryId)
            .HasConstraintName("FKClientAssignmentCompleteDocumentRepositoryId");

        entity.HasOne(d => d.CompletedByNavigation)
            .WithMany(p => p.ClientAssignmentCompletedByNavigations)
            .HasForeignKey(d => d.CompletedBy)
            .HasConstraintName("FKClientAssignmentCompletedBy");

        entity.HasOne(d => d.CreatedByNavigation)
            .WithMany(p => p.ClientAssignmentCreatedByNavigations)
            .HasForeignKey(d => d.CreatedBy)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentCreatedBy");

        entity.HasOne(d => d.LastAccessByNavigation)
            .WithMany(p => p.ClientAssignmentLastAccessByNavigations)
            .HasForeignKey(d => d.LastAccessBy)
            .HasConstraintName("FKClientAssignmentLastAccessBy");

        entity.HasOne(d => d.ParentAssignment)
            .WithMany(p => p.InverseParentAssignment)
            .HasForeignKey(d => d.ParentAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("RefClientAssignment194");

        entity.HasOne(d => d.ReprojectedByNavigation)
            .WithMany(p => p.ClientAssignmentReprojectedByNavigations)
            .HasForeignKey(d => d.ReprojectedBy)
            .HasConstraintName("FKClientAssignmentReprojectedBy");

        entity.HasOne(d => d.StartedByAssignment)
            .WithMany(p => p.InverseStartedByAssignment)
            .HasForeignKey(d => d.StartedByAssignmentId)
            .HasConstraintName("RefClientAssignment210");

        entity.HasOne(d => d.StartedDocumentRepository)
            .WithMany(p => p.ClientAssignmentStartedDocumentRepositories)
            .HasForeignKey(d => d.StartedDocumentRepositoryId)
            .HasConstraintName("FKClientAssignmentStartedDocumentRepositoryId");

        entity.HasOne(d => d.UpdatedByNavigation)
            .WithMany(p => p.ClientAssignmentUpdatedByNavigations)
            .HasForeignKey(d => d.UpdatedBy)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentUpdatedBy");

        entity.HasOne(d => d.VoidedByNavigation)
            .WithMany(p => p.ClientAssignmentVoidedByNavigations)
            .HasForeignKey(d => d.VoidedBy)
            .HasConstraintName("FKClientAssignmentVoidedBy");
    }
}
