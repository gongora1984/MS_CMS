namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseFcl : Entity, IAuditableEntity
    {
        public CaseFcl()
        {
            CaseSales = new HashSet<CaseSale>();
            CaseTitles = new HashSet<CaseTitle>();
        }

        public string FclloanNumber { get; set; } = null!;
        public string FclclientReferanceNumber { get; set; } = null!;
        public string? FclcourtCaseNumber { get; set; }
        public string? InversterLoanNumber { get; set; }
        public string? IndexNumber { get; set; }
        public string? FclfullPlaintiff { get; set; }
        public string? FclfullDefendant { get; set; }
        public string? FcloridMortgagor { get; set; }
        public string? PropertyOwner { get; set; }
        public string? PrimaryBorrowerName { get; set; }
        public string? PropertyMortgagor { get; set; }
        public string? PropertyMortgagee { get; set; }
        public string PropertyAddress1 { get; set; } = null!;
        public string? PropertyAddress2 { get; set; }
        public string PropertyCity { get; set; } = null!;
        public string PropertyState { get; set; } = null!;
        public string PropertyZip { get; set; } = null!;
        public DateTime FclopenDate { get; set; }
        public DateTime? CaseFiledDate { get; set; }
        public DateTime? CaseFclclosedDate { get; set; }
        public DateTime? FclreferralRecievedDate { get; set; }
        public DateTime? FclmortgageDate { get; set; }
        public DateTime? FclmortgageDefaultDate { get; set; }
        public decimal? FclballanceAtDefault { get; set; }
        public decimal? FclintrestRate { get; set; }
        public bool? FclintrestIsAdjustable { get; set; }
        public decimal? FclcurrentBallance { get; set; }
        public decimal? FclmortgageAmount { get; set; }
        public string? ReferralNote { get; set; }
        public bool IsReferred { get; set; }
        public DateTime? ReferredOn { get; set; }
        public string? OccStatus { get; set; }
        public string? AttorneyName { get; set; }
        public DateTime? MortgageReceived { get; set; }
        public DateTime? Soldate { get; set; }
        public DateTime? RecordedOn { get; set; }
        public string? RecordedBook { get; set; }
        public string? RecordedPage { get; set; }
        public string? RecordedInst { get; set; }
        public decimal? FclmonthlyPayment { get; set; }
        public string? FclhomePhoneNumber { get; set; }
        public string? MobileHomeManufacturedYear { get; set; }
        public string? MobileHomeTradeModelName { get; set; }
        public string? MobileHomeSerialVinnumber { get; set; }
        public string? MobileHomeHudconstructionCodeLabels { get; set; }
        public string? MobileHomeHudconstruction { get; set; }
        public string? MobileHomeRealEstateTaxId { get; set; }
        public DateTime? DeedInfoRecordingDate { get; set; }
        public string? DeedInfoRecordingInstrumentNum { get; set; }
        public string? DeedInfoRecordingBookNum { get; set; }
        public string? DeedInfoRecordingPageNum { get; set; }
        public string? DeedInfoFinalVestingInfo { get; set; }
        public int ClientJobId { get; set; }
        public int CaseFclstatusLid { get; set; }
        public int? CaseFclclientInvestorTypeLid { get; set; }
        public int? CaseFclpropertyTypeLid { get; set; }
        public int? CaseFclclosedReasonLid { get; set; }
        public int? CaseFclcaseTypeLid { get; set; }
        public int? CaseJudgeId { get; set; }
        public int? CountyFiled { get; set; }
        public int? StateFiled { get; set; }

        public virtual ListItem? CaseFclcaseType { get; set; }
        public virtual ListItem? CaseFclclientInvestorType { get; set; }
        public virtual ListItem? CaseFclclosedReason { get; set; }
        public virtual ListItem? CaseFclpropertyType { get; set; }
        public virtual ListItem CaseFclstatus { get; set; } = null!;
        public virtual CaseJudge? CaseJudge { get; set; }
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual CaseCounty? CountyFiledNavigation { get; set; }
        public virtual CaseState? StateFiledNavigation { get; set; }
        public virtual ICollection<CaseSale> CaseSales { get; set; }
        public virtual ICollection<CaseTitle> CaseTitles { get; set; }
    }
}
