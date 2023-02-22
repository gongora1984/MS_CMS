using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class JobTypeConfiguration : IEntityTypeConfiguration<JobType>
{
    public void Configure(EntityTypeBuilder<JobType> entity)
    {
        entity.ToTable(TableNames.JobType);

        entity.HasKey(e => e.Id).HasName("PKJobType");

        entity.Property(e => e.Id).HasColumnName("JobTypeId");

        entity.Property(e => e.CanCreateNewCase)
            .IsRequired()
            .HasColumnName("canCreateNewCase")
        .HasDefaultValueSql("((1))");

        entity.Property(e => e.CanHaveMultiple).HasDefaultValueSql("((0))");

        entity.Property(e => e.IsClientStart)
            .IsRequired()
            .HasColumnName("isCLientStart")
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.IsLawPracticeStart)
            .IsRequired()
            .HasColumnName("isLawPracticeStart")
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.IsLocalCounselStart)
            .HasColumnName("isLocalCounselStart")
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.IsMasterJob)
            .IsRequired()
            .HasColumnName("isMasterJob")
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.JobClientRefField)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('PKID')");

        entity.Property(e => e.JobDataTable)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.JobDepartmentId).HasDefaultValueSql("((1))");

        entity.Property(e => e.JobIconLocation)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.JobName)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.JobPkfield)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("JobPKField");

        entity.Property(e => e.JobState)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.JobSysCode)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasDefaultValueSql("('sysfcl')");

        entity.Property(e => e.JobTemplateLocation)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValueSql("(' ')");
    }
}
