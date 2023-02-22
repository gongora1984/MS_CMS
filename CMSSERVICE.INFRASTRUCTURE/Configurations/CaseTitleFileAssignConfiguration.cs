using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleFileAssignConfiguration : IEntityTypeConfiguration<CaseTitleFileAssign>
{
    public void Configure(EntityTypeBuilder<CaseTitleFileAssign> entity)
    {
        entity.ToTable(TableNames.CaseTitleFileAssign);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleFileAssign");

        entity.Property(e => e.Id).HasColumnName("CaseTitleFileAssignId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleFileAssignCaseTitleId");

        entity.Property(e => e.AssignFrom)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.AssignTo)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.Book)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.InstrumentNum)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.Page)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleFileAssigns)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleFileAssignCaseTitleId");
    }
}
