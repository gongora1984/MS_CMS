using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ReportConfiguration : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> entity)
    {
        entity.ToTable(TableNames.Report);

        entity.HasKey(e => e.Id).HasName("PKReport");

        entity.Property(e => e.Id).HasColumnName("ReportId");

        entity.HasIndex(e => e.ClientId, "FKReportClientId");

        entity.Property(e => e.Enabled)
            .IsRequired()
        .HasDefaultValueSql("((1))");

        entity.Property(e => e.MasterSql)
            .HasMaxLength(4000)
            .IsUnicode(false)
        .HasColumnName("MasterSQL");

        entity.Property(e => e.OutputFormat)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasDefaultValueSql("('xlsx')");

        entity.Property(e => e.ReportName)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.HasOne(d => d.Client)
            .WithMany(p => p.Reports)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKReportClientId");
    }
}
