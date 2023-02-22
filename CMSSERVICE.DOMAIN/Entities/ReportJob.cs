namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ReportJob : Entity, IAuditableEntity
    {
        public ReportJob()
        {
            ReportJobParameters = new HashSet<ReportJobParameter>();
        }

        public string? ServerName { get; set; }
        public string? DatabaseName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? SheduleDays { get; set; }
        public string? SheduleTimeOnly { get; set; }
        public int? SheduleEveryMinutes { get; set; }
        public string? SheduleBetweenHoursSt { get; set; }
        public string? SheduleBetweenHoursEn { get; set; }
        public bool? Enabled { get; set; }
        public string? LastRun { get; set; }
        public string? LastResult { get; set; }
        public string NextRun { get; set; } = null!;
        public bool InProgress { get; set; }
        public string Action { get; set; } = null!;
        public string? Destination { get; set; }
        public int ReportId { get; set; }

        public virtual Report Report { get; set; } = null!;
        public virtual ICollection<ReportJobParameter> ReportJobParameters { get; set; }
    }
}
