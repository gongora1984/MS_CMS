namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleMortgTaxLien : Entity, IAuditableEntity
    {
        public string? Priority { get; set; }
        public string? FileBy { get; set; }
        public decimal? LienAmt { get; set; }
        public DateTime? LienDate { get; set; }
        public DateTime? LienRecordDate { get; set; }
        public string? Volume { get; set; }
        public string? Page { get; set; }
        public bool? PendingTitleIssueInd { get; set; }
        public DateTime? ClaimFileDate { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public int? LienTypeLid { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
        public virtual ListItem? LienType { get; set; }
    }
}
