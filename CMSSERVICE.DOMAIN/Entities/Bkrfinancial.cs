namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrFinancial : Entity, IAuditableEntity
    {
        public DateTime? LastBreakDownRequest { get; set; }
        public DateTime? LastBreakDownReceived { get; set; }
        public decimal? UnpaidPrincipal { get; set; }
        public decimal? Interest { get; set; }
        public decimal? InsuranceAdvances { get; set; }
        public decimal? OtherFees { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public int? NumInstallmentsDue { get; set; }
        public decimal? PreTotalAttyfees { get; set; }
        public decimal? PreForcedInsurance { get; set; }
        public decimal? PreTotalPetitionAmt { get; set; }
        public decimal? PostTotalAttyFees { get; set; }
        public decimal? PostAttyFeeBilled { get; set; }
        public decimal? PostFilingFee { get; set; }
        public decimal? PostInspectionfees { get; set; }
        public decimal? PostAppraisalPrice { get; set; }
        public decimal? PostForcedInsurance { get; set; }
        public decimal? PosttotalPetitionAmt { get; set; }
        public decimal? UnappliedFunds { get; set; }
        public decimal? PreMonthlyPymntAmt { get; set; }
        public decimal? PreNextPymntDue { get; set; }
        public DateTime? PrePayOffDate { get; set; }
        public decimal? PrePayOffAmount { get; set; }
        public decimal? PreCountyPropertyAppraisal { get; set; }
        public decimal? PostAtTimeOfBkyfiling { get; set; }
        public decimal? PostCurrentPayment { get; set; }
        public decimal? PrePetitionUnappliedFunds { get; set; }
        public decimal? PrePetitionRefund { get; set; }
        public DateTime? LastMonetaryDate { get; set; }
        public int CaseBkrId { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
