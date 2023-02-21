using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleIrstaxLien : Entity, IAuditableEntity
    {
        public int CaseTitleIrstaxLienId { get; set; }
        public string? Priority { get; set; }
        public string? FileBy { get; set; }
        public string? FileAgainst { get; set; }
        public decimal? LienAmt { get; set; }
        public DateTime? LienDate { get; set; }
        public DateTime? LienRecordDate { get; set; }
        public string? Volume { get; set; }
        public string? Page { get; set; }
        public string? SsntaxId { get; set; }
        public string? IrsformNo { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public DateTime? AssessmentEndDate { get; set; }
        public bool? PendingTitleIssueInd { get; set; }
        public DateTime? ClaimFileDate { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
    }
}
