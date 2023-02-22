using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ReportJobScheduleConfiguration : IEntityTypeConfiguration<ReportJobSchedule>
{
    public void Configure(EntityTypeBuilder<ReportJobSchedule> entity)
    {
        entity.ToTable(TableNames.ReportJobSchedule);

        entity.HasKey(e => e.Id).HasName("PKReportJobSchedule");

        entity.Property(e => e.Id).HasColumnName("ReportJobScheduleId");

        entity.HasIndex(e => e.ReportId, "FKReportJobScheduleReportId");

        entity.Property(e => e.Message)
            .HasMaxLength(2000)
        .IsUnicode(false);

        entity.Property(e => e.ProcessEnd)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.ProcessStart)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.ScheduleDate)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.HasOne(d => d.Report)
            .WithMany(p => p.ReportJobSchedules)
            .HasForeignKey(d => d.ReportId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKReportJobScheduleReportId");
    }
}
