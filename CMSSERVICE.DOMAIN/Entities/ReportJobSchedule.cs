namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ReportJobSchedule : Entity, IAuditableEntity
    {
        public string ScheduleDate { get; set; } = null!;
        public string? ProcessStart { get; set; }
        public string? ProcessEnd { get; set; }
        public string? Message { get; set; }
        public int ReportId { get; set; }

        public virtual Report Report { get; set; } = null!;
    }
}
