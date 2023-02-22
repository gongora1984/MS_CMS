using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseFclConfiguration : IEntityTypeConfiguration<CaseFcl>
{
    public void Configure(EntityTypeBuilder<CaseFcl> entity)
    {
        entity.ToTable(TableNames.CaseFcl);

        entity.HasKey(e => e.Id).HasName("PKCaseFcl");

        entity.Property(e => e.Id).HasColumnName("CaseFclId");

        entity.HasIndex(e => e.CaseJudgeId, "FKCaseFCLCaseJudgeId");

        entity.HasIndex(e => e.CaseFclcaseTypeLid, "FKCaseFCLCaseTypeLid");

        entity.HasIndex(e => e.CaseFclclientInvestorTypeLid, "FKCaseFCLClientInvestorTypeLid");

        entity.HasIndex(e => e.ClientJobId, "FKCaseFCLClientJobId");

        entity.HasIndex(e => e.CaseFclclosedReasonLid, "FKCaseFCLClosedReasonLid");

        entity.HasIndex(e => e.CountyFiled, "FKCaseFCLCountyFiled");

        entity.HasIndex(e => e.CaseFclpropertyTypeLid, "FKCaseFCLPropertyTypeLid");

        entity.HasIndex(e => e.StateFiled, "FKCaseFCLStateFiled");

        entity.HasIndex(e => e.CaseFclstatusLid, "FKCaseFCLStatusLid");

        entity.Property(e => e.AttorneyName)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.CaseFclcaseTypeLid).HasColumnName("CaseFCLCaseTypeLid");

        entity.Property(e => e.CaseFclclientInvestorTypeLid).HasColumnName("CaseFCLClientInvestorTypeLid");

        entity.Property(e => e.CaseFclclosedDate).HasColumnName("CaseFCLClosedDate");

        entity.Property(e => e.CaseFclclosedReasonLid).HasColumnName("CaseFCLClosedReasonLid");

        entity.Property(e => e.CaseFclpropertyTypeLid).HasColumnName("CaseFCLPropertyTypeLid");

        entity.Property(e => e.CaseFclstatusLid).HasColumnName("CaseFCLStatusLid");

        entity.Property(e => e.DeedInfoFinalVestingInfo)
            .HasMaxLength(4000)
        .IsUnicode(false);

        entity.Property(e => e.DeedInfoRecordingBookNum)
            .HasMaxLength(20)
        .IsUnicode(false);

        entity.Property(e => e.DeedInfoRecordingInstrumentNum)
            .HasMaxLength(20)
        .IsUnicode(false);

        entity.Property(e => e.DeedInfoRecordingPageNum)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.FclballanceAtDefault)
            .HasColumnType("money")
            .HasColumnName("FCLBallanceAtDefault");

        entity.Property(e => e.FclclientReferanceNumber)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("FCLClientReferanceNumber");

        entity.Property(e => e.FclcourtCaseNumber)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasColumnName("FCLCourtCaseNumber");

        entity.Property(e => e.FclcurrentBallance)
            .HasColumnType("money")
            .HasColumnName("FCLCurrentBallance")
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.FclfullDefendant)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("FCLFullDefendant");

        entity.Property(e => e.FclfullPlaintiff)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("FCLFullPlaintiff");

        entity.Property(e => e.FclhomePhoneNumber)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasColumnName("FCLHomePhoneNumber");

        entity.Property(e => e.FclintrestIsAdjustable).HasColumnName("FCLIntrestIsAdjustable");

        entity.Property(e => e.FclintrestRate)
            .HasColumnType("decimal(6, 2)")
            .HasColumnName("FCLIntrestRate");

        entity.Property(e => e.FclloanNumber)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("FCLLoanNumber");

        entity.Property(e => e.FclmonthlyPayment)
            .HasColumnType("money")
            .HasColumnName("FCLMonthlyPayment")
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.FclmortgageAmount)
            .HasColumnType("money")
            .HasColumnName("FCLMortgageAmount")
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.FclmortgageDate).HasColumnName("FCLMortgageDate");

        entity.Property(e => e.FclmortgageDefaultDate).HasColumnName("FCLMortgageDefaultDate");

        entity.Property(e => e.FclopenDate).HasColumnName("FCLOpenDate");

        entity.Property(e => e.FcloridMortgagor)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("FCLOridMortgagor");

        entity.Property(e => e.FclreferralRecievedDate).HasColumnName("FCLReferralRecievedDate");

        entity.Property(e => e.IndexNumber)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.InversterLoanNumber)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.IsReferred).HasColumnName("isReferred");

        entity.Property(e => e.MobileHomeHudconstruction)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("MobileHomeHUDConstruction");

        entity.Property(e => e.MobileHomeHudconstructionCodeLabels)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("MobileHomeHUDConstructionCodeLabels");

        entity.Property(e => e.MobileHomeManufacturedYear)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.MobileHomeRealEstateTaxId)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("MobileHomeRealEstateTaxID");

        entity.Property(e => e.MobileHomeSerialVinnumber)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("MobileHomeSerialVINNumber");

        entity.Property(e => e.MobileHomeTradeModelName)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.OccStatus)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.PrimaryBorrowerName)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.PropertyAddress1)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.PropertyAddress2)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.PropertyCity)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PropertyMortgagee)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.PropertyMortgagor)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.PropertyOwner)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.PropertyState)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.PropertyZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.RecordedBook)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.RecordedInst)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.RecordedPage)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.ReferralNote)
            .HasMaxLength(400)
            .IsUnicode(false);

        entity.Property(e => e.Soldate).HasColumnName("SOLDate");

        entity.HasOne(d => d.CaseFclcaseType)
            .WithMany(p => p.CaseFclCaseFclcaseTypeLs)
            .HasForeignKey(d => d.CaseFclcaseTypeLid)
            .HasConstraintName("FKCaseFCLCaseTypeLid");

        entity.HasOne(d => d.CaseFclclientInvestorType)
            .WithMany(p => p.CaseFclCaseFclclientInvestorTypeLs)
            .HasForeignKey(d => d.CaseFclclientInvestorTypeLid)
            .HasConstraintName("FKCaseFCLClientInvestorTypeLid");

        entity.HasOne(d => d.CaseFclclosedReason)
            .WithMany(p => p.CaseFclCaseFclclosedReasonLs)
            .HasForeignKey(d => d.CaseFclclosedReasonLid)
            .HasConstraintName("FKCaseFCLClosedReasonLid");

        entity.HasOne(d => d.CaseFclpropertyType)
            .WithMany(p => p.CaseFclCaseFclpropertyTypeLs)
            .HasForeignKey(d => d.CaseFclpropertyTypeLid)
            .HasConstraintName("FKCaseFCLPropertyTypeLid");

        entity.HasOne(d => d.CaseFclstatus)
            .WithMany(p => p.CaseFclCaseFclstatusLs)
            .HasForeignKey(d => d.CaseFclstatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseFCLStatusLid");

        entity.HasOne(d => d.CaseJudge)
            .WithMany(p => p.CaseFcls)
            .HasForeignKey(d => d.CaseJudgeId)
            .HasConstraintName("FKCaseFCLCaseJudgeId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseFcls)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseFCLClientJobId");

        entity.HasOne(d => d.CountyFiledNavigation)
            .WithMany(p => p.CaseFcls)
            .HasForeignKey(d => d.CountyFiled)
            .HasConstraintName("FKCaseFCLCountyFiled");

        entity.HasOne(d => d.StateFiledNavigation)
            .WithMany(p => p.CaseFcls)
            .HasForeignKey(d => d.StateFiled)
            .HasConstraintName("FKCaseFCLStateFiled");
    }
}
