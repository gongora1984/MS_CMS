using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ReportJobParameterConfiguration : IEntityTypeConfiguration<ReportJobParameter>
{
    public void Configure(EntityTypeBuilder<ReportJobParameter> entity)
    {
        entity.ToTable(TableNames.ReportJobParameter);

        entity.HasKey(e => e.Id).HasName("PKReportJobParameter");

        entity.Property(e => e.Id).HasColumnName("ReportJobParameterId");

        entity.HasIndex(e => e.ReportJobId, "FKReportJobParameterReportJobId");

        entity.HasIndex(e => e.ReportParameterId, "FKReportJobParameterReportParameterId");

        entity.Property(e => e.Value)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.HasOne(d => d.ReportJob)
            .WithMany(p => p.ReportJobParameters)
            .HasForeignKey(d => d.ReportJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKReportJobParameterReportJobId");

        entity.HasOne(d => d.ReportParameter)
            .WithMany(p => p.ReportJobParameters)
            .HasForeignKey(d => d.ReportParameterId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKReportJobParameterReportParameterId");
    }
}
