namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleMortgWithAssignment : Entity, IAuditableEntity
    {
        public string? Priority { get; set; }
        public string? CurrHolder { get; set; }
        public string? OrigHolder { get; set; }
        public decimal? OrigPrincipalBal { get; set; }
        public DateTime? LienDate { get; set; }
        public DateTime? LienRecordDate { get; set; }
        public string? Volume { get; set; }
        public string? Page { get; set; }
        public bool? PendingTitleIssueInd { get; set; }
        public DateTime? ClaimFileDate { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public bool? ReplacementAom { get; set; }
        public bool? CorrectiveAom { get; set; }
        public string? Instrument { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
    }
}
