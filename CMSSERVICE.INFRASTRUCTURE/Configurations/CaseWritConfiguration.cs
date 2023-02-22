using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseWritConfiguration : IEntityTypeConfiguration<CaseWrit>
{
    public void Configure(EntityTypeBuilder<CaseWrit> entity)
    {
        entity.ToTable(TableNames.CaseWrit);

        entity.HasKey(e => e.Id).HasName("PKCaseWrit");

        entity.Property(e => e.Id).HasColumnName("CaseWritId");

        entity.HasIndex(e => e.AdditionalDocumentationLid, "FKCaseWritAdditionalDocumentationLid");

        entity.HasIndex(e => e.CaseDetailLid, "FKCaseWritCaseDetailLid");

        entity.HasIndex(e => e.CaseTypeLid, "FKCaseWritCaseTypeLid");

        entity.HasIndex(e => e.ClientJobId, "FKCaseWritClientJobId");

        entity.HasIndex(e => e.ClosedReasonLid, "FKCaseWritClosedReasonLid");

        entity.HasIndex(e => e.CountyId, "FKCaseWritCountyId");

        entity.HasIndex(e => e.CourtTypeId, "FKCaseWritCourtTypeId");

        entity.HasIndex(e => e.GarnisheeId, "FKCaseWritGarnisheeId");

        entity.HasIndex(e => e.RtgLid, "FKCaseWritRtgLid");

        entity.HasIndex(e => e.CaseWritStatusLid, "FKCaseWritStatusLid");

        entity.Property(e => e.AccountNumber)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.CheckIssuedAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.CourtCaseNum)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.EwlcaseNumber)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasColumnName("EWLCaseNumber");

        entity.Property(e => e.EwlcreationDate).HasColumnName("EWLCreationDate");

        entity.Property(e => e.GarnishmentDebtAmt).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.Garnishor)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.LpreferenceId)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasColumnName("LPReferenceId");

        entity.Property(e => e.State)
            .HasMaxLength(2)
        .IsUnicode(false);

        entity.HasOne(d => d.AdditionalDocumentation)
            .WithMany(p => p.CaseWritAdditionalDocumentationLs)
            .HasForeignKey(d => d.AdditionalDocumentationLid)
            .HasConstraintName("FKCaseWritAdditionalDocumentationLid");

        entity.HasOne(d => d.CaseDetail)
            .WithMany(p => p.CaseWritCaseDetailLs)
            .HasForeignKey(d => d.CaseDetailLid)
            .HasConstraintName("FKCaseWritCaseDetailLid");

        entity.HasOne(d => d.CaseType)
            .WithMany(p => p.CaseWritCaseTypeLs)
            .HasForeignKey(d => d.CaseTypeLid)
            .HasConstraintName("FKCaseWritCaseTypeLid");

        entity.HasOne(d => d.CaseWritStatus)
            .WithMany(p => p.CaseWritCaseWritStatusLs)
            .HasForeignKey(d => d.CaseWritStatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseWritStatusLid");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseWrits)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseWritClientJobId");

        entity.HasOne(d => d.ClosedReason)
            .WithMany(p => p.CaseWritClosedReasonLs)
            .HasForeignKey(d => d.ClosedReasonLid)
            .HasConstraintName("FKCaseWritClosedReasonLid");

        entity.HasOne(d => d.County)
            .WithMany(p => p.CaseWrits)
            .HasForeignKey(d => d.CountyId)
            .HasConstraintName("FKCaseWritCountyId");

        entity.HasOne(d => d.CourtType)
            .WithMany(p => p.CaseWrits)
            .HasForeignKey(d => d.CourtTypeId)
            .HasConstraintName("FKCaseWritCourtTypeId");

        entity.HasOne(d => d.Garnishee)
            .WithMany(p => p.CaseWrits)
            .HasForeignKey(d => d.GarnisheeId)
            .HasConstraintName("FKCaseWritGarnisheeId");

        entity.HasOne(d => d.Rtg)
            .WithMany(p => p.CaseWritRtgLs)
            .HasForeignKey(d => d.RtgLid)
            .HasConstraintName("FKCaseWritRtgLid");
    }
}
