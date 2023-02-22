using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CientJobLogConfiguration : IEntityTypeConfiguration<CientJobLog>
{
    public void Configure(EntityTypeBuilder<CientJobLog> entity)
    {
        entity.ToTable(TableNames.CientJobLog);

        entity.HasKey(e => e.Id).HasName("PKCientJobLog");

        entity.Property(e => e.Id).HasColumnName("CientJobLogId");

        entity.HasIndex(e => e.ClientJobId, "FKCientJobLogClientJobId");

        entity.Property(e => e.LogDate).HasDefaultValueSql("(getdate())");

        entity.Property(e => e.LogText)
            .HasMaxLength(4000)
        .IsUnicode(false);

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CientJobLogs)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCientJobLogClientJobId");
    }
}
