using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentReProHistoryConfiguration : IEntityTypeConfiguration<ClientAssignmentReProHistory>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentReProHistory> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentReProHistory);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentReProHistory");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentReProHistoryId");

        entity.HasIndex(e => e.ApprovedBy, "FKClientAssignmentReProHistoryApprovedBy");

        entity.HasIndex(e => e.ClientAssignmentId, "FKClientAssignmentReProHistoryClientAssignmentId");

        entity.HasIndex(e => e.DocumentRepositoryId, "FKClientAssignmentReProHistoryDocumentRespositoryId");

        entity.HasIndex(e => e.ReprojectedBy, "FKClientAssignmentReProHistoryReprojectedBy");

        entity.Property(e => e.NewTargetDate).HasColumnType("date");

        entity.Property(e => e.Reason)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.HasOne(d => d.ApprovedByNavigation)
            .WithMany(p => p.ClientAssignmentReProHistoryApprovedByNavigations)
            .HasForeignKey(d => d.ApprovedBy)
            .HasConstraintName("FKClientAssignmentReProHistoryApprovedBy");

        entity.HasOne(d => d.ClientAssignment)
            .WithMany(p => p.ClientAssignmentReProHistories)
            .HasForeignKey(d => d.ClientAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentReProHistoryClientAssignmentId");

        entity.HasOne(d => d.DocumentRepository)
            .WithMany(p => p.ClientAssignmentReProHistories)
            .HasForeignKey(d => d.DocumentRepositoryId)
            .HasConstraintName("FKClientAssignmentReProHistoryDocumentRespositoryId");

        entity.HasOne(d => d.ReprojectedByNavigation)
            .WithMany(p => p.ClientAssignmentReProHistoryReprojectedByNavigations)
            .HasForeignKey(d => d.ReprojectedBy)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentReProHistoryReprojectedBy");
    }
}
