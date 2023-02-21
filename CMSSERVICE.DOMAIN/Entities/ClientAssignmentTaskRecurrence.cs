using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentTaskRecurrence : Entity, IAuditableEntity
    {
        public int ClientAssignmentTaskRecurrenceId { get; set; }
        public int ClientAssignmentTaskScheduledId { get; set; }
        public string RecurrenceType { get; set; } = null!;
        public int? EveryNumberType { get; set; }
        public bool? EveryWeekday { get; set; }
        public bool? Monday { get; set; }
        public bool? Tuesday { get; set; }
        public bool? Wednesday { get; set; }
        public bool? Thursday { get; set; }
        public bool? Friday { get; set; }
        public int? DayOrder { get; set; }
        public int? TheOrder { get; set; }
        public string? Day { get; set; }
        public string CreatedDate { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public string UpdateDate { get; set; } = null!;
        public string UpdateBy { get; set; } = null!;
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }

        public virtual ClientAssignmentTaskScheduled ClientAssignmentTaskScheduled { get; set; } = null!;
    }
}
