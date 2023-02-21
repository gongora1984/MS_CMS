using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseReplevin : Entity, IAuditableEntity
    {
        public int CaseReplevinId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string LoanNumber { get; set; } = null!;
        public decimal? VehicleValue { get; set; }
        public string? VehicleMake { get; set; }
        public string? VehicleModel { get; set; }
        public string? VehicleYear { get; set; }
        public decimal? TotalAmountDue { get; set; }
        public decimal? Upb { get; set; }
        public string? Aitno { get; set; }
        public DateTime? DefaultDate { get; set; }
        public string? PropAddr1 { get; set; }
        public string? PropAddr2 { get; set; }
        public string? PropCity { get; set; }
        public string? PropState { get; set; }
        public string? PropZip { get; set; }
        public DateTime ReplevinOpenDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? CourtCaseNumber { get; set; }
        public string? InvestorLoanNum { get; set; }
        public string? InvestorName { get; set; }
        public decimal? EstimatedCollateralValue { get; set; }
        public string? EstimatedCollateralDate { get; set; }
        public string? DaysDeliquentofLoan { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public string? RateofInterest { get; set; }
        public string? VinNumber { get; set; }
        public string? CoDebtorLocation { get; set; }
        public string? CoDebtorName { get; set; }
        public string? CurrentLender { get; set; }
        public string? OriginalLender { get; set; }
        public string? DebtorName { get; set; }
        public string? DebtorAddress1 { get; set; }
        public string? DebtorAddress2 { get; set; }
        public string? DebtorCity { get; set; }
        public string? DebtorState { get; set; }
        public string? DebtorZip { get; set; }
        public int? DebtorCountyId { get; set; }
        public string? TitleCompany { get; set; }
        public decimal? JudgmentAmount { get; set; }
        public string? JudgmentBook { get; set; }
        public DateTime? JudgmentDate { get; set; }
        public string? JudgmentPage { get; set; }
        public decimal? TaxesDue { get; set; }
        public string? WhoSignedtheNote { get; set; }
        public string? LpreferanceId { get; set; }
        public string? PlaintiffCaption { get; set; }
        public string? DefendantCaption { get; set; }
        public string? BillingMatterNum { get; set; }
        public string? LocalCounselRefId { get; set; }
        public int ClientJobId { get; set; }
        public int CaseReplevinStatusLid { get; set; }
        public int CaseReplevinTypeLid { get; set; }
        public int? StateFiled { get; set; }
        public int? CountyFiledId { get; set; }
        public int? DefaultReasonLid { get; set; }
        public int? AssignedLocalCounsel { get; set; }
        public int? ClosedReasonLid { get; set; }
        public int? DivisionId { get; set; }
        public int? OccupancyStatusLid { get; set; }
        public int? InvestorTypeLid { get; set; }
        public int? AssignedAtty { get; set; }
        public int? AssignedPara { get; set; }
        public int? AssignedRep { get; set; }

        public virtual LawPracticeUser? AssignedAttyNavigation { get; set; }
        public virtual LocalCounsel? AssignedLocalCounselNavigation { get; set; }
        public virtual LawPracticeUser? AssignedParaNavigation { get; set; }
        public virtual LoginDetail? AssignedRepNavigation { get; set; }
        public virtual ListItem CaseReplevinStatusL { get; set; } = null!;
        public virtual ListItem CaseReplevinTypeL { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ListItem? ClosedReasonL { get; set; }
        public virtual CaseCounty? CountyFiled { get; set; }
        public virtual CaseCounty? DebtorCounty { get; set; }
        public virtual ListItem? DefaultReasonL { get; set; }
        public virtual CaseDistrict? Division { get; set; }
        public virtual ListItem? InvestorTypeL { get; set; }
        public virtual ListItem? OccupancyStatusL { get; set; }
        public virtual CaseState? StateFiledNavigation { get; set; }
    }
}
