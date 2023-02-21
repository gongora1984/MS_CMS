using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseBkr : Entity, IAuditableEntity
    {
        public CaseBkr()
        {
            BkrcaseSummaries = new HashSet<BkrcaseSummary>();
            BkrconditionalOrders = new HashSet<BkrconditionalOrder>();
            BkrfinInstallments = new HashSet<BkrfinInstallment>();
            BkrfinInterestRates = new HashSet<BkrfinInterestRate>();
            BkrfinMissedPayments = new HashSet<BkrfinMissedPayment>();
            BkrfinOtherCosts = new HashSet<BkrfinOtherCost>();
            Bkrfinancials = new HashSet<Bkrfinancial>();
            Bkrjournals = new HashSet<Bkrjournal>();
            BkrloanModifications = new HashSet<BkrloanModification>();
            Bkrmfrs = new HashSet<Bkrmfr>();
            BkrpaymentChanges = new HashSet<BkrpaymentChange>();
            Bkrproperties = new HashSet<Bkrproperty>();
        }

        public int CaseBkrid { get; set; }
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
        public int? Bkrsollid { get; set; }

        public virtual ListItem? BkrcircuitL { get; set; }
        public virtual Bkrdistrict? Bkrdistrict { get; set; }
        public virtual ListItem? Bkrsoll { get; set; }
        public virtual ListItem? CaseBkrclientInvestorL { get; set; }
        public virtual ListItem? CaseBkrclientInvestorTypeL { get; set; }
        public virtual ListItem CaseBkrstatusL { get; set; } = null!;
        public virtual ListItem CaseBkrtypeL { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ListItem? ClosedReasonL { get; set; }
        public virtual ICollection<BkrcaseSummary> BkrcaseSummaries { get; set; }
        public virtual ICollection<BkrconditionalOrder> BkrconditionalOrders { get; set; }
        public virtual ICollection<BkrfinInstallment> BkrfinInstallments { get; set; }
        public virtual ICollection<BkrfinInterestRate> BkrfinInterestRates { get; set; }
        public virtual ICollection<BkrfinMissedPayment> BkrfinMissedPayments { get; set; }
        public virtual ICollection<BkrfinOtherCost> BkrfinOtherCosts { get; set; }
        public virtual ICollection<Bkrfinancial> Bkrfinancials { get; set; }
        public virtual ICollection<Bkrjournal> Bkrjournals { get; set; }
        public virtual ICollection<BkrloanModification> BkrloanModifications { get; set; }
        public virtual ICollection<Bkrmfr> Bkrmfrs { get; set; }
        public virtual ICollection<BkrpaymentChange> BkrpaymentChanges { get; set; }
        public virtual ICollection<Bkrproperty> Bkrproperties { get; set; }
    }
}
