using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ReportParameterConfiguration : IEntityTypeConfiguration<ReportParameter>
{
    public void Configure(EntityTypeBuilder<ReportParameter> entity)
    {
        entity.ToTable(TableNames.ReportParameter);

        entity.HasKey(e => e.Id).HasName("PKReportParameter");

        entity.Property(e => e.Id).HasColumnName("ReportParameterId");

        entity.HasIndex(e => e.ReportId, "FKReportParameterReportId");

        entity.Property(e => e.DefaultValue)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.Name)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.Token)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.ValueType)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('string')");

        entity.HasOne(d => d.Report)
            .WithMany(p => p.ReportParameters)
            .HasForeignKey(d => d.ReportId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKReportParameterReportId");
    }
}
