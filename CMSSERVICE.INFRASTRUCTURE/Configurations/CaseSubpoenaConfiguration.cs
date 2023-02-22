using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseSubpoenaConfiguration : IEntityTypeConfiguration<CaseSubpoena>
{
    public void Configure(EntityTypeBuilder<CaseSubpoena> entity)
    {
        entity.ToTable(TableNames.CaseSubpoena);

        entity.HasKey(e => e.Id).HasName("PKCaseSubpoena");

        entity.Property(e => e.Id).HasColumnName("CaseSubpoenaId");

        entity.HasIndex(e => e.ClientJobId, "FKCaseSubpoenaClientJobId");

        entity.HasIndex(e => e.CaseSubpoenaClosedReasonLid, "FKCaseSubpoenaClosedReasonLid");

        entity.HasIndex(e => e.CaseSubpoenaDocTransmissionMethodLid, "FKCaseSubpoenaDocTransmissionMethodLid");

        entity.HasIndex(e => e.LawPracticeId, "FKCaseSubpoenaLawPracticeId");

        entity.HasIndex(e => e.CaseSubpoenaPcidataIncludedLid, "FKCaseSubpoenaPCIDataIncludedLid");

        entity.HasIndex(e => e.CaseSubpoenaStatusLid, "FKCaseSubpoenaStatusLid");

        entity.HasIndex(e => e.CaseSubpoenaSubTypeLid, "FKCaseSubpoenaSubTypeLid");

        entity.HasIndex(e => e.CaseSubpoenaTypeLid, "FKCaseSubpoenaTypeLid");

        entity.HasIndex(e => e.TriageMsrspecialistId, "FKLoginDetailJobListingCaseSubpoena");

        entity.HasIndex(e => e.CertificationMsrspecialistId, "FKLoginDetailJobListingCertificationMSRSpecialistId");

        entity.HasIndex(e => e.ServicingMsrspecialistId, "FKLoginDetailJobListingServicingMSRSpecialistId");

        entity.Property(e => e.CaseSubpoenaPcidataIncludedLid).HasColumnName("CaseSubpoenaPCIDataIncludedLid");

        entity.Property(e => e.CertificationMsrspecialistId).HasColumnName("CertificationMSRSpecialistId");

        entity.Property(e => e.CourtCaseNumber)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.HoldReasons)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.LpreferenceId)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("LPReferenceId");

        entity.Property(e => e.OpenedDate)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.ServicingMsrspecialistId).HasColumnName("ServicingMSRSpecialistId");

        entity.Property(e => e.State)
            .HasMaxLength(2)
        .IsUnicode(false);

        entity.Property(e => e.SubpoenaFormNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.TriageMsrspecialistId).HasColumnName("TriageMSRSpecialistId");

        entity.HasOne(d => d.CaseSubpoenaClosedReason)
            .WithMany(p => p.CaseSubpoenaCaseSubpoenaClosedReasonLs)
            .HasForeignKey(d => d.CaseSubpoenaClosedReasonLid)
            .HasConstraintName("FKCaseSubpoenaClosedReasonLid");

        entity.HasOne(d => d.CaseSubpoenaDocTransmissionMethod)
            .WithMany(p => p.CaseSubpoenaCaseSubpoenaDocTransmissionMethodLs)
            .HasForeignKey(d => d.CaseSubpoenaDocTransmissionMethodLid)
            .HasConstraintName("FKCaseSubpoenaDocTransmissionMethodLid");

        entity.HasOne(d => d.CaseSubpoenaPcidataIncluded)
            .WithMany(p => p.CaseSubpoenaCaseSubpoenaPcidataIncludedLs)
            .HasForeignKey(d => d.CaseSubpoenaPcidataIncludedLid)
            .HasConstraintName("FKCaseSubpoenaPCIDataIncludedLid");

        entity.HasOne(d => d.CaseSubpoenaStatus)
            .WithMany(p => p.CaseSubpoenaCaseSubpoenaStatusLs)
            .HasForeignKey(d => d.CaseSubpoenaStatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseSubpoenaStatusLid");

        entity.HasOne(d => d.CaseSubpoenaSubType)
            .WithMany(p => p.CaseSubpoenaCaseSubpoenaSubTypeLs)
            .HasForeignKey(d => d.CaseSubpoenaSubTypeLid)
            .HasConstraintName("FKCaseSubpoenaSubTypeLid");

        entity.HasOne(d => d.CaseSubpoenaType)
            .WithMany(p => p.CaseSubpoenaCaseSubpoenaTypeLs)
            .HasForeignKey(d => d.CaseSubpoenaTypeLid)
            .HasConstraintName("FKCaseSubpoenaTypeLid");

        entity.HasOne(d => d.CertificationMsrspecialist)
            .WithMany(p => p.CaseSubpoenaCertificationMsrspecialists)
            .HasForeignKey(d => d.CertificationMsrspecialistId)
            .HasConstraintName("FKLoginDetailJobListingCertificationMSRSpecialistId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseSubpoenas)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseSubpoenaClientJobId");

        entity.HasOne(d => d.LawPractice)
            .WithMany(p => p.CaseSubpoenas)
            .HasForeignKey(d => d.LawPracticeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseSubpoenaLawPracticeId");

        entity.HasOne(d => d.ServicingMsrspecialist)
            .WithMany(p => p.CaseSubpoenaServicingMsrspecialists)
            .HasForeignKey(d => d.ServicingMsrspecialistId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLoginDetailJobListingServicingMSRSpecialistId");

        entity.HasOne(d => d.TriageMsrspecialist)
            .WithMany(p => p.CaseSubpoenaTriageMsrspecialists)
            .HasForeignKey(d => d.TriageMsrspecialistId)
            .HasConstraintName("FKLoginDetailJobListingCaseSubpoena");
    }
}
