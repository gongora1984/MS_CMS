using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentCheckListVrConfiguration : IEntityTypeConfiguration<ClientAssignmentCheckListVr>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentCheckListVr> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentCheckListVr);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentCheckListVr");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentCheckListVrId");

        entity.HasIndex(e => e.ClientAssignmentId, "FKClientAssignmentCheckListVRClientAssignmentId");

        entity.HasIndex(e => e.ClientAssignmentTaskCheckListId, "FKClientAssignmentCheckListVRClientAssignmentTaskCheckListId");

        entity.Property(e => e.Value)
            .HasMaxLength(1000)
        .IsUnicode(false);

        entity.Property(e => e.ValueDisplay)
            .HasMaxLength(1000)
        .IsUnicode(false);

        entity.HasOne(d => d.ClientAssignment)
            .WithMany(p => p.ClientAssignmentCheckListVrs)
            .HasForeignKey(d => d.ClientAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentCheckListVRClientAssignmentId");

        entity.HasOne(d => d.ClientAssignmentTaskCheckList)
            .WithMany(p => p.ClientAssignmentCheckListVrs)
            .HasForeignKey(d => d.ClientAssignmentTaskCheckListId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentCheckListVRClientAssignmentTaskCheckListId");
    }
}
