using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleReRecordedConfiguration : IEntityTypeConfiguration<CaseTitleReRecorded>
{
    public void Configure(EntityTypeBuilder<CaseTitleReRecorded> entity)
    {
        entity.ToTable(TableNames.CaseTitleReRecorded);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleReRecorded");

        entity.Property(e => e.Id).HasColumnName("CaseTitleReRecordedId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleReRecordedCaseTitleId");

        entity.Property(e => e.Book)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.Instrument)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.Page)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleReRecordeds)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleReRecordedCaseTitleId");
    }
}
