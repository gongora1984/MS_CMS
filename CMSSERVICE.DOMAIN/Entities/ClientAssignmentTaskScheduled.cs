namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentTaskScheduled : Entity, IAuditableEntity
    {
        public ClientAssignmentTaskScheduled()
        {
            ClientAssignmentScheduleds = new HashSet<ClientAssignmentScheduled>();
            ClientAssignmentTaskRecurrences = new HashSet<ClientAssignmentTaskRecurrence>();
        }

        public int DaysFromTargetDate { get; set; }
        public string? AlertWhenStarted { get; set; }
        public bool Enabled { get; set; }
        public bool? RunScheduledOnStartNewAssign { get; set; }
        public bool? CalendarDay { get; set; }
        public string? LaunchTime { get; set; }
        public bool? UseSaleDate { get; set; }
        public int ClientAssignmentTaskId { get; set; }
        public int StartClientAssignmentTaskId { get; set; }

        public virtual ClientAssignmentTask ClientAssignmentTask { get; set; } = null!;
        public virtual ClientAssignmentTask StartClientAssignmentTask { get; set; } = null!;
        public virtual ICollection<ClientAssignmentScheduled> ClientAssignmentScheduleds { get; set; }
        public virtual ICollection<ClientAssignmentTaskRecurrence> ClientAssignmentTaskRecurrences { get; set; }
    }
}
