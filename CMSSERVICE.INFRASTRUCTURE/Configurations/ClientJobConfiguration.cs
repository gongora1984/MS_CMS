using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientJobConfiguration : IEntityTypeConfiguration<ClientJob>
{
    public void Configure(EntityTypeBuilder<ClientJob> entity)
    {
        entity.ToTable(TableNames.ClientJob);

        entity.HasKey(e => e.Id).HasName("PKClientJob");

        entity.Property(e => e.Id).HasColumnName("ClientJobId");

        entity.HasIndex(e => e.CaseId, "FKClientJobCaseId");

        entity.HasIndex(e => e.JobTypeId, "FKClientJobJobTypeId");

        entity.HasIndex(e => e.LawPracticeId, "FKClientJobLawPracticeId");

        entity.HasIndex(e => e.LocalCounselId, "FKClientJobLocalCounselId");

        entity.Property(e => e.ClientJobStatus)
            .HasMaxLength(1)
            .HasDefaultValueSql("(N'O')")
        .IsFixedLength();

        entity.Property(e => e.ClosedDate)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.JobDataKeyId).HasComment("This column represents the module id( casebkyid, casewritid)");

        entity.Property(e => e.LpreferranceNumber)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasColumnName("LPReferranceNumber");

        entity.Property(e => e.ReferralAcknolagedDate)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.HasOne(d => d.Case)
            .WithMany(p => p.ClientJobs)
            .HasForeignKey(d => d.CaseId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientJobCaseId");

        entity.HasOne(d => d.JobType)
            .WithMany(p => p.ClientJobs)
            .HasForeignKey(d => d.JobTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientJobJobTypeId");

        entity.HasOne(d => d.LawPractice)
            .WithMany(p => p.ClientJobs)
            .HasForeignKey(d => d.LawPracticeId)
            .HasConstraintName("FKClientJobLawPracticeId");

        entity.HasOne(d => d.LocalCounsel)
            .WithMany(p => p.ClientJobs)
            .HasForeignKey(d => d.LocalCounselId)
            .HasConstraintName("FKClientJobLocalCounselId");
    }
}
