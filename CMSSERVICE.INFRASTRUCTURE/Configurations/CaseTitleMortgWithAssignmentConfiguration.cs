using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleMortgWithAssignmentConfiguration : IEntityTypeConfiguration<CaseTitleMortgWithAssignment>
{
    public void Configure(EntityTypeBuilder<CaseTitleMortgWithAssignment> entity)
    {
        entity.ToTable(TableNames.CaseTitleMortgWithAssignment);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleMortgWithAssignment");

        entity.Property(e => e.Id).HasColumnName("CaseTitleMortgWithAssignmentId");

        entity.HasIndex(e => e.CaseTitleId, "FKCaseTitleMortgWithAssignmentCaseTitleId");

        entity.Property(e => e.CorrectiveAom).HasColumnName("CorrectiveAOM");

        entity.Property(e => e.CurrHolder)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.Instrument)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.OrigHolder)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.OrigPrincipalBal).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.Page)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.Priority)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.Property(e => e.ReplacementAom).HasColumnName("ReplacementAOM");

        entity.Property(e => e.Volume)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseTitle)
            .WithMany(p => p.CaseTitleMortgWithAssignments)
            .HasForeignKey(d => d.CaseTitleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleMortgWithAssignmentCaseTitleId");
    }
}
