using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientJobActivityConfiguration : IEntityTypeConfiguration<ClientJobActivity>
{
    public void Configure(EntityTypeBuilder<ClientJobActivity> entity)
    {
        entity.ToTable(TableNames.ClientJobActivity);

        entity.HasKey(e => e.Id).HasName("PKClientJobActivity");

        entity.Property(e => e.Id).HasColumnName("ClientJobActivityId");

        entity.HasIndex(e => e.ActionClientAssignmentId, "FKClientJobActivityActionClientAssignmentId");

        entity.HasIndex(e => e.ClientJobId, "FKClientJobActivityClientJobId");

        entity.Property(e => e.ActionNote)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.HasOne(d => d.ActionClientAssignment)
            .WithMany(p => p.ClientJobActivities)
            .HasForeignKey(d => d.ActionClientAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientJobActivityActionClientAssignmentId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.ClientJobActivities)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientJobActivityClientJobId");
    }
}
