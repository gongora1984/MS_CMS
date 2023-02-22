using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentHoldConfiguration : IEntityTypeConfiguration<ClientAssignmentHold>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentHold> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentHold);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentHold");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentHoldId");

        entity.HasIndex(e => e.AttachmentDocumentRepositoryId, "FKAttachmentDocumentRepositoryId");

        entity.HasIndex(e => e.ApprovedById, "FKClientAssignmentHoldApprovedById");

        entity.HasIndex(e => e.ClientAssignmentId, "FKClientAssignmentHoldClientAssignmentId");

        entity.HasIndex(e => e.DeniedById, "FKClientAssignmentHoldDeniedById");

        entity.HasIndex(e => e.HoldTypeLid, "FKClientAssignmentHoldHoldTypeLid");

        entity.HasIndex(e => e.LawPracticeId, "FKClientAssignmentHoldLawPracticeId");

        entity.HasIndex(e => e.ClientAssignmentParentId, "Ref81170");

        entity.HasIndex(e => e.HoldingAssignmentId, "Ref81171");

        entity.Property(e => e.CloseNote)
            .HasMaxLength(300)
        .IsUnicode(false);

        entity.Property(e => e.DeniedReason)
            .HasMaxLength(300)
        .IsUnicode(false);

        entity.Property(e => e.OpenNote)
            .HasMaxLength(300)
        .IsUnicode(false);

        entity.HasOne(d => d.ApprovedBy)
            .WithMany(p => p.ClientAssignmentHoldApprovedBies)
            .HasForeignKey(d => d.ApprovedById)
            .HasConstraintName("FKClientAssignmentHoldApprovedById");

        entity.HasOne(d => d.AttachmentDocumentRepository)
            .WithMany(p => p.ClientAssignmentHolds)
            .HasForeignKey(d => d.AttachmentDocumentRepositoryId)
            .HasConstraintName("FKAttachmentDocumentRepositoryId");

        entity.HasOne(d => d.ClientAssignment)
            .WithMany(p => p.ClientAssignmentHoldClientAssignments)
            .HasForeignKey(d => d.ClientAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentHoldClientAssignmentId");

        entity.HasOne(d => d.ClientAssignmentParent)
            .WithMany(p => p.ClientAssignmentHoldClientAssignmentParents)
            .HasForeignKey(d => d.ClientAssignmentParentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("RefClientAssignment170");

        entity.HasOne(d => d.DeniedBy)
            .WithMany(p => p.ClientAssignmentHoldDeniedBies)
            .HasForeignKey(d => d.DeniedById)
            .HasConstraintName("FKClientAssignmentHoldDeniedById");

        entity.HasOne(d => d.HoldTypeL)
            .WithMany(p => p.ClientAssignmentHolds)
            .HasForeignKey(d => d.HoldTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentHoldHoldTypeLid");

        entity.HasOne(d => d.HoldingAssignment)
            .WithMany(p => p.ClientAssignmentHoldHoldingAssignments)
            .HasForeignKey(d => d.HoldingAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("RefClientAssignment171");

        entity.HasOne(d => d.LawPractice)
            .WithMany(p => p.ClientAssignmentHolds)
            .HasForeignKey(d => d.LawPracticeId)
            .HasConstraintName("FKClientAssignmentHoldLawPracticeId");
    }
}
