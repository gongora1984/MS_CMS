using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentTaskCheckListVrConfiguration : IEntityTypeConfiguration<ClientAssignmentTaskCheckListVr>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentTaskCheckListVr> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentTaskCheckListVr);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentTaskCheckListVr");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentTaskCheckListVrId");

        entity.HasIndex(e => e.ClientAssignmentTaskCheckListId, "FKClientAssignmentTaskCheckListVRClientAssignmentTaskCheckListId");

        entity.Property(e => e.CompareValue)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.RunCommandOnMatch)
            .HasMaxLength(2000)
        .IsUnicode(false);

        entity.Property(e => e.RunCommandOnNoMatch)
            .HasMaxLength(2000)
        .IsUnicode(false);

        entity.Property(e => e.StartAssigmnmentOnMatch)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.StartAssigmnmentOnNoMatch)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.HasOne(d => d.ClientAssignmentTaskCheckList)
            .WithMany(p => p.ClientAssignmentTaskCheckListVrs)
            .HasForeignKey(d => d.ClientAssignmentTaskCheckListId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentTaskCheckListVRClientAssignmentTaskCheckListId");
    }
}
