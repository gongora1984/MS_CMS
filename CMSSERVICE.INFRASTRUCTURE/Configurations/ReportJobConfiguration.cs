using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ReportJobConfiguration : IEntityTypeConfiguration<ReportJob>
{
    public void Configure(EntityTypeBuilder<ReportJob> entity)
    {
        entity.ToTable(TableNames.ReportJob);

        entity.HasKey(e => e.Id).HasName("PKReportJob");

        entity.Property(e => e.Id).HasColumnName("ReportJobId");

        entity.HasIndex(e => e.ReportId, "FKReportJobReportId");

        entity.Property(e => e.Action)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('email')");

        entity.Property(e => e.DatabaseName)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.Destination)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.Enabled)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.InProgress).HasColumnName("inProgress");

        entity.Property(e => e.LastResult)
            .HasMaxLength(4000)
        .IsUnicode(false);

        entity.Property(e => e.LastRun)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.NextRun)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("(getdate())")
            .IsFixedLength();

        entity.Property(e => e.Password)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.ServerName)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.SheduleBetweenHoursEn)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("SheduleBetweenHoursEN");

        entity.Property(e => e.SheduleBetweenHoursSt)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("SheduleBetweenHoursST");

        entity.Property(e => e.SheduleDays)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.SheduleTimeOnly)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.UserName)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.HasOne(d => d.Report)
            .WithMany(p => p.ReportJobs)
            .HasForeignKey(d => d.ReportId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKReportJobReportId");
    }
}
