using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LawPracticeJobConfiguration : IEntityTypeConfiguration<LawPracticeJob>
{
    public void Configure(EntityTypeBuilder<LawPracticeJob> entity)
    {
        entity.ToTable(TableNames.LawPracticeJob);

        entity.HasKey(e => e.Id).HasName("PKLawPracticeJob");

        entity.Property(e => e.Id).HasColumnName("LawPracticeJobId");

        entity.HasIndex(e => e.JobTypeId, "FKLawPracticeJobJobTypeId");

        entity.HasIndex(e => e.LawPracticeId, "FKLawPracticeJobLawPracticeId");

        entity.Property(e => e.ContectMemberId).HasDefaultValueSql("((-1))");

        entity.Property(e => e.Enabled)
            .IsRequired()
        .HasDefaultValueSql("((1))");

        entity.Property(e => e.LpfileNumber)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("LPFileNumber");

        entity.Property(e => e.Lpkey1)
            .HasMaxLength(50)
            .IsUnicode(false)
        .HasColumnName("LPKey1");

        entity.HasOne(d => d.JobType)
            .WithMany(p => p.LawPracticeJobs)
            .HasForeignKey(d => d.JobTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLawPracticeJobJobTypeId");

        entity.HasOne(d => d.LawPractice)
            .WithMany(p => p.LawPracticeJobs)
            .HasForeignKey(d => d.LawPracticeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLawPracticeJobLawPracticeId");
    }
}
