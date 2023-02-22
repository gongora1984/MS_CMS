using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleAssignmentConfiguration : IEntityTypeConfiguration<CaseTitleAssignment>
{
    public void Configure(EntityTypeBuilder<CaseTitleAssignment> entity)
    {
        entity.ToTable(TableNames.CaseTitleAssignment);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleAssignment");

        entity.Property(e => e.Id).HasColumnName("CaseTitleAssignmentId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleAssignmentCaseTitleId");

        entity.Property(e => e.AomexecutedOn).HasColumnName("AOMExecutedOn");

        entity.Property(e => e.AssigmCost).HasColumnType("decimal(10, 2)");

        entity.Property(e => e.AssignedTo)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.BillingFee).HasColumnType("decimal(10, 2)");

        entity.Property(e => e.Comment).HasMaxLength(1000);

        entity.Property(e => e.CompletedBy)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.RecievedBy)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.StoppedBy)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.StoppedReason)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleAssignments)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleAssignmentCaseTitleId");
    }
}
