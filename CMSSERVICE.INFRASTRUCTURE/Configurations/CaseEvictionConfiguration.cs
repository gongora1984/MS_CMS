using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseEvictionConfiguration : IEntityTypeConfiguration<CaseEviction>
{
    public void Configure(EntityTypeBuilder<CaseEviction> entity)
    {
        entity.ToTable(TableNames.CaseEviction);

        entity.HasKey(e => e.Id).HasName("PKCaseEviction");

        entity.Property(e => e.Id).HasColumnName("CaseEvictionId");

        entity.HasIndex(e => e.CaseCountyId, "FKCaseEvictionCaseCountyId");

        entity.HasIndex(e => e.CaseDistrictId, "FKCaseEvictionCaseDistrictId");

        entity.HasIndex(e => e.CaseJudgeId, "FKCaseEvictionCaseJudgeId");

        entity.HasIndex(e => e.CircuitLid, "FKCaseEvictionCircuitLid");

        entity.HasIndex(e => e.ClientJobId, "FKCaseEvictionClientJobId");

        entity.HasIndex(e => e.ClosedReasonLid, "FKCaseEvictionClosedReasonLid");

        entity.HasIndex(e => e.DivisionLid, "FKCaseEvictionDivisionLid");

        entity.HasIndex(e => e.EvictionStatusLid, "FKCaseEvictionEvictionStatusLid");

        entity.HasIndex(e => e.EvictionTypeLid, "FKCaseEvictionEvictionTypeLid");

        entity.Property(e => e.CfkfallthroughDt).HasColumnName("CFKFallthroughDt");

        entity.Property(e => e.CfkofferDt).HasColumnName("CFKOfferDt");

        entity.Property(e => e.CourtCaseNumber)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.DefendantCap)
            .HasMaxLength(4000)
        .IsUnicode(false);

        entity.Property(e => e.Evcattorney)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("EVCAttorney");

        entity.Property(e => e.EvcreffRcvdAttrDt).HasColumnName("EVCReffRcvdAttrDt");

        entity.Property(e => e.ExpectedAmt)
            .HasMaxLength(10)
        .IsUnicode(false);

        entity.Property(e => e.FileNumber)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.LoanNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.OridDefendant)
            .HasMaxLength(3000)
            .IsUnicode(false);

        entity.Property(e => e.OrigPlaintiff)
            .HasMaxLength(1550)
            .IsUnicode(false);

        entity.Property(e => e.PlaintiffCap)
            .HasMaxLength(4000)
            .IsUnicode(false);

        entity.Property(e => e.PropAddr1)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PropAddr2)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PropCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.PropState)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.PropZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.PropertyName)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseCounty)
            .WithMany(p => p.CaseEvictions)
            .HasForeignKey(d => d.CaseCountyId)
            .HasConstraintName("FKCaseEvictionCaseCountyId");

        entity.HasOne(d => d.CaseDistrict)
            .WithMany(p => p.CaseEvictions)
            .HasForeignKey(d => d.CaseDistrictId)
            .HasConstraintName("FKCaseEvictionCaseDistrictId");

        entity.HasOne(d => d.CaseJudge)
            .WithMany(p => p.CaseEvictions)
            .HasForeignKey(d => d.CaseJudgeId)
            .HasConstraintName("FKCaseEvictionCaseJudgeId");

        entity.HasOne(d => d.Circuit)
            .WithMany(p => p.CaseEvictionCircuitLs)
            .HasForeignKey(d => d.CircuitLid)
            .HasConstraintName("FKCaseEvictionCircuitLid");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseEvictions)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseEvictionClientJobId");

        entity.HasOne(d => d.ClosedReason)
            .WithMany(p => p.CaseEvictionClosedReasonLs)
            .HasForeignKey(d => d.ClosedReasonLid)
            .HasConstraintName("FKCaseEvictionClosedReasonLid");

        entity.HasOne(d => d.Division)
            .WithMany(p => p.CaseEvictionDivisionLs)
            .HasForeignKey(d => d.DivisionLid)
            .HasConstraintName("FKCaseEvictionDivisionLid");

        entity.HasOne(d => d.EvictionStatus)
            .WithMany(p => p.CaseEvictionEvictionStatusLs)
            .HasForeignKey(d => d.EvictionStatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseEvictionEvictionStatusLid");

        entity.HasOne(d => d.EvictionType)
            .WithMany(p => p.CaseEvictionEvictionTypeLs)
            .HasForeignKey(d => d.EvictionTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseEvictionEvictionTypeLid");
    }
}
