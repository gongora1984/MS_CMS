using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LoginDetailJobListingConfiguration : IEntityTypeConfiguration<LoginDetailJobListing>
{
    public void Configure(EntityTypeBuilder<LoginDetailJobListing> entity)
    {
        entity.ToTable(TableNames.LoginDetailJobListing);

        entity.HasKey(e => e.Id).HasName("PKLoginDetailJobListing");

        entity.Property(e => e.Id).HasColumnName("LoginDetailJobListingId");

        entity.HasIndex(e => e.JobTypeId, "FKLoginDetailJobListingJobTypeId");

        entity.HasIndex(e => e.LoginDetailId, "FKLoginDetailJobListingLoginDetailId");

        entity.HasOne(d => d.JobType)
            .WithMany(p => p.LoginDetailJobListings)
            .HasForeignKey(d => d.JobTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLoginDetailJobListingJobTypeId");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.LoginDetailJobListings)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLoginDetailJobListingLoginDetailId");
    }
}
