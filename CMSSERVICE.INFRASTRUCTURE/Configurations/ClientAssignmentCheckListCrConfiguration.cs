using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentCheckListCrConfiguration : IEntityTypeConfiguration<ClientAssignmentCheckListCr>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentCheckListCr> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentCheckListCr);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentCheckListCr");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentCheckListCrId");

        entity.HasIndex(e => e.ClientAssignmentTaskCheckListId, "FKClientAssignmentCheckListCRClientAssignmentTaskCheckListId");

        entity.HasIndex(e => e.ClientAssignmentTaskCheckListCrid, "FKClientAssignmentTaskCheckListCRId");

        entity.Property(e => e.ClientAssignmentTaskCheckListCrid).HasColumnName("ClientAssignmentTaskCheckListCRId");

        entity.Property(e => e.Value)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.HasOne(d => d.ClientAssignmentTaskCheckListCr)
            .WithMany(p => p.ClientAssignmentCheckListCrs)
            .HasForeignKey(d => d.ClientAssignmentTaskCheckListCrid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentTaskCheckListCRId");

        entity.HasOne(d => d.ClientAssignmentTaskCheckList)
            .WithMany(p => p.ClientAssignmentCheckListCrs)
            .HasForeignKey(d => d.ClientAssignmentTaskCheckListId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentCheckListCRClientAssignmentTaskCheckListId");
    }
}
