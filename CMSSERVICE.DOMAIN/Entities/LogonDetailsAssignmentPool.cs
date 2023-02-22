namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LogonDetailsAssignmentPool : Entity, IAuditableEntity
    {
        public LogonDetailsAssignmentPool()
        {
            LogonDetailsAssignmentPoolTasks = new HashSet<LogonDetailsAssignmentPoolTask>();
        }

        public bool IsQueueAdmin { get; set; }
        public int MaxQueueQuota { get; set; }
        public bool? IsAvailible { get; set; }
        public bool NotifyOnNewTasks { get; set; }
        public string? CpadditionalSql { get; set; }
        public int LoginDetailId { get; set; }
        public int ClientAssignmentTaskId { get; set; }
        public int? UseReportId { get; set; }

        public virtual ClientAssignmentTask ClientAssignmentTask { get; set; } = null!;
        public virtual LoginDetail LoginDetail { get; set; } = null!;
        public virtual Report? UseReport { get; set; }
        public virtual ICollection<LogonDetailsAssignmentPoolTask> LogonDetailsAssignmentPoolTasks { get; set; }
    }
}
