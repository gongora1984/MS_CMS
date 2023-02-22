namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentReProHistory : Entity, IAuditableEntity
    {
        public DateTime ReprojectedOn { get; set; }
        public DateTime? NewTargetDate { get; set; }
        public DateTime? OldTargetDate { get; set; }
        public string? Reason { get; set; }
        public int SequenseNumber { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int ClientAssignmentId { get; set; }
        public int ReprojectedBy { get; set; }
        public int? ApprovedBy { get; set; }
        public int? DocumentRepositoryId { get; set; }

        public virtual LoginDetail? ApprovedByNavigation { get; set; }
        public virtual ClientAssignment ClientAssignment { get; set; } = null!;
        public virtual DocumentRepository? DocumentRepository { get; set; }
        public virtual LoginDetail ReprojectedByNavigation { get; set; } = null!;
    }
}
