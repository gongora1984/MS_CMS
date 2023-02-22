namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseEviction : Entity, IAuditableEntity
    {
        public CaseEviction()
        {
            CaseEvictionJournals = new HashSet<CaseEvictionJournal>();
        }

        public string FileNumber { get; set; } = null!;
        public DateTime? FirstLegalActionDt { get; set; }
        public DateTime? OptionLetterSentDt { get; set; }
        public DateTime? CfkofferDt { get; set; }
        public DateTime? ExpectedVacateDt { get; set; }
        public DateTime? ActualVacateDt { get; set; }
        public string? ExpectedAmt { get; set; }
        public DateTime? CfkfallthroughDt { get; set; }
        public DateTime? EvcreffRcvdAttrDt { get; set; }
        public DateTime? WritPossesionEntrdDt { get; set; }
        public DateTime? WritPossesionPostedDt { get; set; }
        public DateTime? LockoutDt { get; set; }
        public DateTime? LockoutCmptDt { get; set; }
        public DateTime? CloseAndBillDt { get; set; }
        public DateTime? EvictionOpenDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string? Evcattorney { get; set; }
        public string? LoanNumber { get; set; }
        public string? CourtCaseNumber { get; set; }
        public string? PropAddr1 { get; set; }
        public string? PropAddr2 { get; set; }
        public string? PropCity { get; set; }
        public string? PropState { get; set; }
        public string? PropZip { get; set; }
        public string? PropertyName { get; set; }
        public DateTime? TenentLeaseDate { get; set; }
        public int? TenentLeaseDuration { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? OrigPlaintiff { get; set; }
        public string? PlaintiffCap { get; set; }
        public string? OridDefendant { get; set; }
        public string? DefendantCap { get; set; }
        public int ClientJobId { get; set; }
        public int EvictionTypeLid { get; set; }
        public int EvictionStatusLid { get; set; }
        public int? CaseJudgeId { get; set; }
        public int? CaseCountyId { get; set; }
        public int? CaseDistrictId { get; set; }
        public int? DivisionLid { get; set; }
        public int? CircuitLid { get; set; }
        public int? ClosedReasonLid { get; set; }

        public virtual CaseCounty? CaseCounty { get; set; }
        public virtual CaseDistrict? CaseDistrict { get; set; }
        public virtual CaseJudge? CaseJudge { get; set; }
        public virtual ListItem? Circuit { get; set; }
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ListItem? ClosedReason { get; set; }
        public virtual ListItem? Division { get; set; }
        public virtual ListItem EvictionStatus { get; set; } = null!;
        public virtual ListItem EvictionType { get; set; } = null!;
        public virtual ICollection<CaseEvictionJournal> CaseEvictionJournals { get; set; }
    }
}
