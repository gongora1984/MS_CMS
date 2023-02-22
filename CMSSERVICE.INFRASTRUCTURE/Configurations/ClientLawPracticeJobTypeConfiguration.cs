using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientLawPracticeJobTypeConfiguration : IEntityTypeConfiguration<ClientLawPracticeJobType>
{
    public void Configure(EntityTypeBuilder<ClientLawPracticeJobType> entity)
    {
        entity.ToTable(TableNames.ClientLawPracticeJobType);

        entity.HasKey(e => e.Id).HasName("PKClientLawPracticeJobType");

        entity.Property(e => e.Id).HasColumnName("ClientLawPracticeJobTypeId");

        entity.HasIndex(e => e.JobTypeId, "FKClientLawPracticeJobTypeJobTypeId");

        entity.Property(e => e.AlertReferralAddress)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.HasOne(d => d.JobType)
            .WithMany(p => p.ClientLawPracticeJobTypes)
            .HasForeignKey(d => d.JobTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientLawPracticeJobTypeJobTypeId");
    }
}
