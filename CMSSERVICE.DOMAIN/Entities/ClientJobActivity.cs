namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientJobActivity : Entity, IAuditableEntity
    {
        public string ActionNote { get; set; } = null!;
        public DateTime ActionStartDate { get; set; }
        public DateTime? ActionEndDate { get; set; }
        public DateTime ActionTargetDate { get; set; }
        public int ClientJobId { get; set; }
        public int ActionClientAssignmentId { get; set; }

        public virtual ClientAssignment ActionClientAssignment { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
    }
}
