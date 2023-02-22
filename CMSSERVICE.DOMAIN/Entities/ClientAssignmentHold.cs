namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentHold : Entity, IAuditableEntity
    {
        public string? OpenNote { get; set; }
        public string? CloseNote { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public DateTime? DeniedOn { get; set; }
        public string? DeniedReason { get; set; }
        public DateTime? HoldStartDate { get; set; }
        public DateTime? HoldEndDate { get; set; }
        public int ClientAssignmentId { get; set; }
        public int HoldingAssignmentId { get; set; }
        public int ClientAssignmentParentId { get; set; }
        public int HoldTypeLid { get; set; }
        public int? AttachmentDocumentRepositoryId { get; set; }
        public int? ApprovedById { get; set; }
        public int? LawPracticeId { get; set; }
        public int? DeniedById { get; set; }

        public virtual LoginDetail? ApprovedBy { get; set; }
        public virtual DocumentRepository? AttachmentDocumentRepository { get; set; }
        public virtual ClientAssignment ClientAssignment { get; set; } = null!;
        public virtual ClientAssignment ClientAssignmentParent { get; set; } = null!;
        public virtual LoginDetail? DeniedBy { get; set; }
        public virtual ListItem HoldTypeL { get; set; } = null!;
        public virtual ClientAssignment HoldingAssignment { get; set; } = null!;
        public virtual LawPractice? LawPractice { get; set; }
    }
}
