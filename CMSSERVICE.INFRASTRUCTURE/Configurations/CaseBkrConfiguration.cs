using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseBkrConfiguration : IEntityTypeConfiguration<CaseBkr>
{
    public void Configure(EntityTypeBuilder<CaseBkr> entity)
    {
        entity.ToTable(TableNames.CaseBkr);

        entity.HasKey(e => e.Id).HasName("PKCaseBkr");

        entity.Property(e => e.Id).HasColumnName("CaseBkrId");

        entity.HasIndex(e => e.BkrSolLid, "FKBKRSOLLid");

        entity.HasIndex(e => e.BkrdistrictId, "FKCaseBKRBKRDistrictId");

        entity.HasIndex(e => e.CaseBkrclientInvestorLid, "FKCaseBKRClientInvestorLid");

        entity.HasIndex(e => e.CaseBkrclientInvestorTypeLid, "FKCaseBKRClientInvestorTypeLid");

        entity.HasIndex(e => e.ClientJobId, "FKCaseBKRClientJobId");

        entity.HasIndex(e => e.CaseBkrstatusLid, "FKCaseBKRStatusLid");

        entity.HasIndex(e => e.CaseBkrtypeLid, "FKCaseBKRTypeLid");

        entity.HasIndex(e => e.BkrcircuitLid, "FKCircuitLid");

        entity.HasIndex(e => e.ClosedReasonLid, "FKClosedReasonLid");

        entity.Property(e => e.ApocfiledDate).HasColumnName("APOCFiledDate");

        entity.Property(e => e.AttyAssignedTo)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.BkrcaseNumber)
            .HasMaxLength(75)
            .IsUnicode(false)
            .HasColumnName("BKRCaseNumber");

        entity.Property(e => e.BkrcircuitLid).HasColumnName("BKRCircuitLid");

        entity.Property(e => e.BkrdistrictId).HasColumnName("BKRDistrictId");

        entity.Property(e => e.BkrinvestorNumber)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("BKRInvestorNumber");

        entity.Property(e => e.BkrloanNumber)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("BKRLoanNumber");

        entity.Property(e => e.BkropenDate).HasColumnName("BKROpenDate");

        entity.Property(e => e.BkrSolLid).HasColumnName("BKRSOLLid");

        entity.Property(e => e.BkypocbarDate).HasColumnName("BKYPOCBarDate");

        entity.Property(e => e.CaseBkrclientInvestorLid).HasColumnName("CaseBKRClientInvestorLid");

        entity.Property(e => e.CaseBkrclientInvestorTypeLid).HasColumnName("CaseBKRClientInvestorTypeLid");

        entity.Property(e => e.CaseBkrstatusLid).HasColumnName("CaseBKRStatusLid");

        entity.Property(e => e.CaseBkrtypeLid).HasColumnName("CaseBKRTypeLid");

        entity.Property(e => e.CfmhearingDate).HasColumnName("CFMHearingDate");

        entity.Property(e => e.ClientReferranceNumber)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.CountyId).HasColumnName("CountyID");

        entity.Property(e => e.CustomerFullName1)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.CustomerFullName2)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.Debtor1Addr1)
            .HasMaxLength(75)
            .IsUnicode(false);

        entity.Property(e => e.Debtor1Addr2)
            .HasMaxLength(75)
            .IsUnicode(false);

        entity.Property(e => e.Debtor1City)
            .HasMaxLength(60)
            .IsUnicode(false);

        entity.Property(e => e.Debtor1Email)
            .HasMaxLength(60)
            .IsUnicode(false);

        entity.Property(e => e.Debtor1Name)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.Debtor1Phone)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.Debtor1State)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.Debtor1Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Debtor2Addr1)
            .HasMaxLength(75)
            .IsUnicode(false);

        entity.Property(e => e.Debtor2Addr2)
            .HasMaxLength(75)
            .IsUnicode(false);

        entity.Property(e => e.Debtor2City)
            .HasMaxLength(60)
            .IsUnicode(false);

        entity.Property(e => e.Debtor2Email)
            .HasMaxLength(60)
            .IsUnicode(false);

        entity.Property(e => e.Debtor2Name)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.Debtor2Phone)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.Debtor2State)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.Debtor2Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.DefendantCap)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.Ecfapocid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ECFAPOCID");

        entity.Property(e => e.Ecfpocid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ECFPOCID");

        entity.Property(e => e.LitigationType)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.LpreferanceId)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasColumnName("LPReferanceId");

        entity.Property(e => e.PlaintiffCap)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.PocfiledDate).HasColumnName("POCFiledDate");

        entity.Property(e => e.PrincipalBalance).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.PropertyAddr1)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PropertyAddr2)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PropertyCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.PropertyState)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.PropertyZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.SocfiledDate).HasColumnName("SOCFiledDate");

        entity.Property(e => e.Soldate).HasColumnName("SOLDate");

        entity.Property(e => e.TrusteeAddr1)
            .HasMaxLength(75)
            .IsUnicode(false);

        entity.Property(e => e.TrusteeAddr2)
            .HasMaxLength(75)
            .IsUnicode(false);

        entity.Property(e => e.TrusteeCity)
            .HasMaxLength(60)
            .IsUnicode(false);

        entity.Property(e => e.TrusteeEmail)
            .HasMaxLength(60)
            .IsUnicode(false);

        entity.Property(e => e.TrusteeName)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.TrusteePhone)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.TrusteeState)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.TrusteeZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.WocfiledDate).HasColumnName("WOCFiledDate");

        entity.HasOne(d => d.BkrCircuit)
            .WithMany(p => p.CaseBkrBkrcircuitLs)
            .HasForeignKey(d => d.BkrcircuitLid)
            .HasConstraintName("FKCircuitLid");

        entity.HasOne(d => d.BkrDistrict)
            .WithMany(p => p.CaseBkrs)
            .HasForeignKey(d => d.BkrdistrictId)
            .HasConstraintName("FKCaseBKRBKRDistrictId");

        entity.HasOne(d => d.BkrSol)
            .WithMany(p => p.CaseBkrBkrsolls)
            .HasForeignKey(d => d.BkrSolLid)
            .HasConstraintName("FKBKRSOLLid");

        entity.HasOne(d => d.CaseBkrclientInvestor)
            .WithMany(p => p.CaseBkrCaseBkrclientInvestorLs)
            .HasForeignKey(d => d.CaseBkrclientInvestorLid)
            .HasConstraintName("FKCaseBKRClientInvestorLid");

        entity.HasOne(d => d.CaseBkrclientInvestorType)
            .WithMany(p => p.CaseBkrCaseBkrclientInvestorTypeLs)
            .HasForeignKey(d => d.CaseBkrclientInvestorTypeLid)
            .HasConstraintName("FKCaseBKRClientInvestorTypeLid");

        entity.HasOne(d => d.CaseBkrstatus)
            .WithMany(p => p.CaseBkrCaseBkrstatusLs)
            .HasForeignKey(d => d.CaseBkrstatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseBKRStatusLid");

        entity.HasOne(d => d.CaseBkrtype)
            .WithMany(p => p.CaseBkrCaseBkrtypeLs)
            .HasForeignKey(d => d.CaseBkrtypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseBKRTypeLid");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseBkrs)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseBKRClientJobId");

        entity.HasOne(d => d.ClosedReason)
            .WithMany(p => p.CaseBkrClosedReasonLs)
            .HasForeignKey(d => d.ClosedReasonLid)
            .HasConstraintName("FKClosedReasonLid");
    }
}
