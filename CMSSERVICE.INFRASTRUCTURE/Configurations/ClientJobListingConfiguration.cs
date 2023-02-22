using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientJobListingConfiguration : IEntityTypeConfiguration<ClientJobListing>
{
    public void Configure(EntityTypeBuilder<ClientJobListing> entity)
    {
        entity.ToTable(TableNames.ClientJobListing);

        entity.HasKey(e => e.Id).HasName("PKClientJobListing");

        entity.Property(e => e.Id).HasColumnName("ClientJobListingId");

        entity.HasIndex(e => e.ClientId, "FKClientJobListingClientId");

        entity.HasIndex(e => e.JobTypeId, "FKClientJobListingJobTypeId");

        entity.Property(e => e.StartAssignmentsOnReferral)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.HasOne(d => d.Client)
            .WithMany(p => p.ClientJobListings)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientJobListingClientId");

        entity.HasOne(d => d.JobType)
            .WithMany(p => p.ClientJobListings)
            .HasForeignKey(d => d.JobTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientJobListingJobTypeId");
    }
}
