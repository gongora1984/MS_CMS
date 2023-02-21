namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseBkr : Entity, IAuditableEntity
    {
        public CaseBkr()
        {
            BkrCaseSummaries = new HashSet<BkrCaseSummary>();
            BkrConditionalOrders = new HashSet<BkrConditionalOrder>();
            BkrFinInstallments = new HashSet<BkrFinInstallment>();
            BkrFinInterestRates = new HashSet<BkrFinInterestRate>();
            BkrFinMissedPayments = new HashSet<BkrFinMissedPayment>();
            BkrFinOtherCosts = new HashSet<BkrFinOtherCost>();
            BkrFinancials = new HashSet<BkrFinancial>();
            BkrJournals = new HashSet<BkrJournal>();
            BkrLoanModifications = new HashSet<BkrLoanModification>();
            BkrMfrs = new HashSet<BkrMfr>();
            BkrPaymentChanges = new HashSet<BkrPaymentChange>();
            BkrProperties = new HashSet<BkrProperty>();
        }

        public DateTime BkropenDate { get; set; }
        public string? BkrcaseNumber { get; set; }
        public DateTime FiledDate { get; set; }
        public string? ClientReferranceNumber { get; set; }
        public string? BkrloanNumber { get; set; }
        public string? BkrinvestorNumber { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? AttyAssignedTo { get; set; }
        public DateTime? AttyAssignedOn { get; set; }
        public string? PlaintiffCap { get; set; }
        public string? DefendantCap { get; set; }
        public DateTime? DefaultDate { get; set; }
        public DateTime? BkypocbarDate { get; set; }
        public DateTime? CfmhearingDate { get; set; }
        public string? Debtor1Name { get; set; }
        public string? Debtor1Phone { get; set; }
        public string? Debtor1Email { get; set; }
        public string? Debtor1Addr1 { get; set; }
        public string? Debtor1Addr2 { get; set; }
        public string? Debtor1City { get; set; }
        public string? Debtor1State { get; set; }
        public string? Debtor1Zip { get; set; }
        public string? Debtor2Name { get; set; }
        public string? Debtor2Phone { get; set; }
        public string? Debtor2Email { get; set; }
        public string? Debtor2Addr1 { get; set; }
        public string? Debtor2Addr2 { get; set; }
        public string? Debtor2City { get; set; }
        public string? Debtor2State { get; set; }
        public string? Debtor2Zip { get; set; }
        public string? TrusteeName { get; set; }
        public string? TrusteePhone { get; set; }
        public string? TrusteeEmail { get; set; }
        public string? TrusteeAddr1 { get; set; }
        public string? TrusteeAddr2 { get; set; }
        public string? TrusteeCity { get; set; }
        public string? TrusteeState { get; set; }
        public string? TrusteeZip { get; set; }
        public string? PropertyAddr1 { get; set; }
        public string? PropertyAddr2 { get; set; }
        public string? PropertyCity { get; set; }
        public string? PropertyState { get; set; }
        public string? PropertyZip { get; set; }
        public int? CountyId { get; set; }
        public string? LpreferanceId { get; set; }
        public decimal? PrincipalBalance { get; set; }
        public DateTime? ChargeOffDate { get; set; }
        public DateTime? BarDate { get; set; }
        public string? Ecfpocid { get; set; }
        public DateTime? PocfiledDate { get; set; }
        public DateTime? ApocfiledDate { get; set; }
        public DateTime? Soldate { get; set; }
        public string? LitigationType { get; set; }
        public DateTime? WocfiledDate { get; set; }
        public DateTime? SocfiledDate { get; set; }
        public string? CustomerFullName1 { get; set; }
        public string? CustomerFullName2 { get; set; }
        public string? Ecfapocid { get; set; }
        public int ClientJobId { get; set; }
        public int CaseBkrstatusLid { get; set; }
        public int CaseBkrtypeLid { get; set; }
        public int? CaseBkrclientInvestorTypeLid { get; set; }
        public int? CaseBkrclientInvestorLid { get; set; }
        public int? BkrdistrictId { get; set; }
        public int? BkrcircuitLid { get; set; }
        public int? ClosedReasonLid { get; set; }
        public int? BkrSolLid { get; set; }

        public virtual ListItem? BkrCircuit { get; set; }
        public virtual BkrDistrict? BkrDistrict { get; set; }
        public virtual ListItem? BkrSol { get; set; }
        public virtual ListItem? CaseBkrclientInvestor { get; set; }
        public virtual ListItem? CaseBkrclientInvestorType { get; set; }
        public virtual ListItem CaseBkrstatus { get; set; } = null!;
        public virtual ListItem CaseBkrtype { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ListItem? ClosedReason { get; set; }
        public virtual ICollection<BkrCaseSummary> BkrCaseSummaries { get; set; }
        public virtual ICollection<BkrConditionalOrder> BkrConditionalOrders { get; set; }
        public virtual ICollection<BkrFinInstallment> BkrFinInstallments { get; set; }
        public virtual ICollection<BkrFinInterestRate> BkrFinInterestRates { get; set; }
        public virtual ICollection<BkrFinMissedPayment> BkrFinMissedPayments { get; set; }
        public virtual ICollection<BkrFinOtherCost> BkrFinOtherCosts { get; set; }
        public virtual ICollection<BkrFinancial> BkrFinancials { get; set; }
        public virtual ICollection<BkrJournal> BkrJournals { get; set; }
        public virtual ICollection<BkrLoanModification> BkrLoanModifications { get; set; }
        public virtual ICollection<BkrMfr> BkrMfrs { get; set; }
        public virtual ICollection<BkrPaymentChange> BkrPaymentChanges { get; set; }
        public virtual ICollection<BkrProperty> BkrProperties { get; set; }
    }
}
