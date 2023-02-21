using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleAssignment : Entity, IAuditableEntity
    {
        public CaseTitleAssignment()
        {
            CaseTitleAssignmentItems = new HashSet<CaseTitleAssignmentItem>();
        }

        public int CaseTitleAssignmentId { get; set; }
        public decimal? BillingFee { get; set; }
        public decimal? AssigmCost { get; set; }
        public string AssignedTo { get; set; } = null!;
        public DateTime AssignedOn { get; set; }
        public DateTime? RecievedOn { get; set; }
        public string? RecievedBy { get; set; }
        public DateTime DueOn { get; set; }
        public int? Priority { get; set; }
        public string? CompletedBy { get; set; }
        public DateTime? CompletedOn { get; set; }
        public string? StoppedBy { get; set; }
        public DateTime? StoppedOn { get; set; }
        public string? StoppedReason { get; set; }
        public string? Comment { get; set; }
        public int? AssignmentTypeCode { get; set; }
        public DateTime? AomexecutedOn { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
        public virtual ICollection<CaseTitleAssignmentItem> CaseTitleAssignmentItems { get; set; }
    }
}
