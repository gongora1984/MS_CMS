using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentScheduled : Entity, IAuditableEntity
    {
        public int ClientAssignmentScheduledId { get; set; }
        public DateTime StartOnDate { get; set; }
        public bool Processed { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public int? ProcessTries { get; set; }
        public bool? Aborted { get; set; }
        public int ClientAssignmentTaskScheduledId { get; set; }
        public int ClientJobId { get; set; }
        public int FromClientAssignmentId { get; set; }
        public int? ClientAssignmentId { get; set; }
        public int? ProcessedBy { get; set; }

        public virtual ClientAssignment? ClientAssignment { get; set; }
        public virtual ClientAssignmentTaskScheduled ClientAssignmentTaskScheduled { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ClientAssignment FromClientAssignment { get; set; } = null!;
        public virtual LoginDetail? ProcessedByNavigation { get; set; }
    }
}
