using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseReplevinConfiguration : IEntityTypeConfiguration<CaseReplevin>
{
    public void Configure(EntityTypeBuilder<CaseReplevin> entity)
    {
        entity.ToTable(TableNames.CaseReplevin);

        entity.HasKey(e => e.Id).HasName("PKCaseReplevin");

        entity.Property(e => e.Id).HasColumnName("CaseReplevinId");

        entity.HasIndex(e => e.AssignedAtty, "FKCaseReplevinAssignedAtty");

        entity.HasIndex(e => e.AssignedLocalCounsel, "FKCaseReplevinAssignedLocalCounsel");

        entity.HasIndex(e => e.AssignedPara, "FKCaseReplevinAssignedPara");

        entity.HasIndex(e => e.AssignedRep, "FKCaseReplevinAssignedRep");

        entity.HasIndex(e => e.ClientJobId, "FKCaseReplevinClientJobId");

        entity.HasIndex(e => e.ClosedReasonLid, "FKCaseReplevinClosedReasonLid");

        entity.HasIndex(e => e.CountyFiledId, "FKCaseReplevinCountyFiledId");

        entity.HasIndex(e => e.DebtorCountyId, "FKCaseReplevinDebtorCountyId");

        entity.HasIndex(e => e.DefaultReasonLid, "FKCaseReplevinDefaultReasonLid");

        entity.HasIndex(e => e.DivisionId, "FKCaseReplevinDivisionId");

        entity.HasIndex(e => e.InvestorTypeLid, "FKCaseReplevinInvestorTypeLid");

        entity.HasIndex(e => e.OccupancyStatusLid, "FKCaseReplevinOccupancyStatusLid");

        entity.HasIndex(e => e.StateFiled, "FKCaseReplevinStateFiled");

        entity.HasIndex(e => e.CaseReplevinStatusLid, "FKCaseReplevinStatusLid");

        entity.HasIndex(e => e.CaseReplevinTypeLid, "FKCaseReplevinTypeLid");

        entity.Property(e => e.AccountNumber)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.Aitno)
            .HasMaxLength(200)
            .IsUnicode(false)
        .HasColumnName("AITNO");

        entity.Property(e => e.BillingMatterNum)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.CoDebtorLocation)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.CoDebtorName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CourtCaseNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CurrentLender)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.DaysDeliquentofLoan)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.DebtorAddress1)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.DebtorAddress2)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.DebtorCity)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.DebtorName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.DebtorState)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.DebtorZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.DefendantCaption)
            .HasMaxLength(2000)
            .IsUnicode(false);

        entity.Property(e => e.EstimatedCollateralDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.EstimatedCollateralValue).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.InvestorLoanNum)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.InvestorName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.JudgmentAmount).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.JudgmentBook)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.JudgmentPage)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.LoanNumber)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.LocalCounselRefId)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.LpreferanceId)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasColumnName("LPReferanceId");

        entity.Property(e => e.MonthlyPayment).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.OriginalLender)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PlaintiffCaption)
            .HasMaxLength(2000)
            .IsUnicode(false);

        entity.Property(e => e.PropAddr1)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.PropAddr2)
            .HasMaxLength(100)
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

        entity.Property(e => e.RateofInterest)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.Property(e => e.TaxesDue).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.TitleCompany)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.TotalAmountDue).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.Upb)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("UPB");

        entity.Property(e => e.VehicleMake)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.VehicleModel)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.VehicleValue).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.VehicleYear)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.Property(e => e.VinNumber)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.WhoSignedtheNote)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.HasOne(d => d.AssignedAttyNavigation)
            .WithMany(p => p.CaseReplevinAssignedAttyNavigations)
            .HasForeignKey(d => d.AssignedAtty)
            .HasConstraintName("FKCaseReplevinAssignedAtty");

        entity.HasOne(d => d.AssignedLocalCounselNavigation)
            .WithMany(p => p.CaseReplevins)
            .HasForeignKey(d => d.AssignedLocalCounsel)
            .HasConstraintName("FKCaseReplevinAssignedLocalCounsel");

        entity.HasOne(d => d.AssignedParaNavigation)
            .WithMany(p => p.CaseReplevinAssignedParaNavigations)
            .HasForeignKey(d => d.AssignedPara)
            .HasConstraintName("FKCaseReplevinAssignedPara");

        entity.HasOne(d => d.AssignedRepNavigation)
            .WithMany(p => p.CaseReplevins)
            .HasForeignKey(d => d.AssignedRep)
            .HasConstraintName("FKCaseReplevinAssignedRep");

        entity.HasOne(d => d.CaseReplevinStatus)
            .WithMany(p => p.CaseReplevinCaseReplevinStatusLs)
            .HasForeignKey(d => d.CaseReplevinStatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseReplevinStatusLid");

        entity.HasOne(d => d.CaseReplevinType)
            .WithMany(p => p.CaseReplevinCaseReplevinTypeLs)
            .HasForeignKey(d => d.CaseReplevinTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseReplevinTypeLid");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseReplevins)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseReplevinClientJobId");

        entity.HasOne(d => d.ClosedReason)
            .WithMany(p => p.CaseReplevinClosedReasonLs)
            .HasForeignKey(d => d.ClosedReasonLid)
            .HasConstraintName("FKCaseReplevinClosedReasonLid");

        entity.HasOne(d => d.CountyFiled)
            .WithMany(p => p.CaseReplevinCountyFileds)
            .HasForeignKey(d => d.CountyFiledId)
            .HasConstraintName("FKCaseReplevinCountyFiledId");

        entity.HasOne(d => d.DebtorCounty)
            .WithMany(p => p.CaseReplevinDebtorCounties)
            .HasForeignKey(d => d.DebtorCountyId)
            .HasConstraintName("FKCaseReplevinDebtorCountyId");

        entity.HasOne(d => d.DefaultReason)
            .WithMany(p => p.CaseReplevinDefaultReasonLs)
            .HasForeignKey(d => d.DefaultReasonLid)
            .HasConstraintName("FKCaseReplevinDefaultReasonLid");

        entity.HasOne(d => d.Division)
            .WithMany(p => p.CaseReplevins)
            .HasForeignKey(d => d.DivisionId)
            .HasConstraintName("FKCaseReplevinDivisionId");

        entity.HasOne(d => d.InvestorType)
            .WithMany(p => p.CaseReplevinInvestorTypeLs)
            .HasForeignKey(d => d.InvestorTypeLid)
            .HasConstraintName("FKCaseReplevinInvestorTypeLid");

        entity.HasOne(d => d.OccupancyStatus)
            .WithMany(p => p.CaseReplevinOccupancyStatusLs)
            .HasForeignKey(d => d.OccupancyStatusLid)
            .HasConstraintName("FKCaseReplevinOccupancyStatusLid");

        entity.HasOne(d => d.StateFiledNavigation)
            .WithMany(p => p.CaseReplevins)
            .HasForeignKey(d => d.StateFiled)
            .HasConstraintName("FKCaseReplevinStateFiled");
    }
}
