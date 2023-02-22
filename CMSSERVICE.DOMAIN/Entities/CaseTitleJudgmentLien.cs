namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleJudgmentLien : Entity, IAuditableEntity
    {
        public string? Priority { get; set; }
        public string? FileBy { get; set; }
        public decimal? AttachmentAmt { get; set; }
        public DateTime? AttachmentRecordDate { get; set; }
        public string? AttachmentVolume { get; set; }
        public string? AttachmentPage { get; set; }
        public DateTime? LienDate { get; set; }
        public DateTime? JudgmentDate { get; set; }
        public decimal? JudgmentDamageAmt { get; set; }
        public decimal? JudgmentCostAmt { get; set; }
        public DateTime? LienRecordDate { get; set; }
        public string? Volume { get; set; }
        public string? Page { get; set; }
        public bool? PendingTitleIssueInd { get; set; }
        public DateTime? ClaimFileDate { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
    }
}
