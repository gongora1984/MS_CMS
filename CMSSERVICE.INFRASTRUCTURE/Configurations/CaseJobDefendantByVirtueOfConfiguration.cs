using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseJobDefendantByVirtueOfConfiguration : IEntityTypeConfiguration<CaseJobDefendantByVirtueOf>
{
    public void Configure(EntityTypeBuilder<CaseJobDefendantByVirtueOf> entity)
    {
        entity.ToTable(TableNames.CaseJobDefendantByVirtueOf);

        entity.HasKey(e => e.Id).HasName("PKCaseJobDefendantByVirtueOf");

        entity.Property(e => e.Id).HasColumnName("CaseJobDefendantByVirtueOfId");

        entity.HasIndex(e => e.ByVirtueOfLid, "FKCaseJobDefendantByVirtueOfByVirtueOfLid");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKCaseJobDefendantByVirtueOfCaseJobDefendantId");

        entity.Property(e => e.Book)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.Instrument)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.Page)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.HasOne(d => d.ByVirtueOf)
            .WithMany(p => p.CaseJobDefendantByVirtueOfs)
            .HasForeignKey(d => d.ByVirtueOfLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantByVirtueOfByVirtueOfLid");

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.CaseJobDefendantByVirtueOfs)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantByVirtueOfCaseJobDefendantId");
    }
}
