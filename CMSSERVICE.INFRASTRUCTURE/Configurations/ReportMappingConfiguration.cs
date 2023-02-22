using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ReportMappingConfiguration : IEntityTypeConfiguration<ReportMapping>
{
    public void Configure(EntityTypeBuilder<ReportMapping> entity)
    {
        entity.ToTable(TableNames.ReportMapping);

        entity.HasKey(e => e.Id).HasName("PKReportMapping");

        entity.Property(e => e.Id).HasColumnName("ReportMappingId");

        entity.HasIndex(e => e.ClientId, "FKReportMappingClientId");

        entity.HasIndex(e => e.LawPracticeId, "FKReportMappingLawPracticeId");

        entity.HasIndex(e => e.LocalCounselId, "FKReportMappingLocalCounselId");

        entity.HasIndex(e => e.ReportId, "FKReportMappingReportId");

        entity.HasOne(d => d.Client)
            .WithMany(p => p.ReportMappings)
            .HasForeignKey(d => d.ClientId)
            .HasConstraintName("FKReportMappingClientId");

        entity.HasOne(d => d.LawPractice)
            .WithMany(p => p.ReportMappings)
            .HasForeignKey(d => d.LawPracticeId)
            .HasConstraintName("FKReportMappingLawPracticeId");

        entity.HasOne(d => d.LocalCounsel)
            .WithMany(p => p.ReportMappings)
            .HasForeignKey(d => d.LocalCounselId)
            .HasConstraintName("FKReportMappingLocalCounselId");

        entity.HasOne(d => d.Report)
            .WithMany(p => p.ReportMappings)
            .HasForeignKey(d => d.ReportId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKReportMappingReportId");
    }
}
