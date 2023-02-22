namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class Report : Entity, IAuditableEntity
    {
        public Report()
        {
            LogonDetailsAssignmentPools = new HashSet<LogonDetailsAssignmentPool>();
            ReportJobSchedules = new HashSet<ReportJobSchedule>();
            ReportJobs = new HashSet<ReportJob>();
            ReportMappings = new HashSet<ReportMapping>();
            ReportParameters = new HashSet<ReportParameter>();
        }

        public string ReportName { get; set; } = null!;
        public string MasterSql { get; set; } = null!;
        public bool? Enabled { get; set; }
        public string OutputFormat { get; set; } = null!;
        public int ClientId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<LogonDetailsAssignmentPool> LogonDetailsAssignmentPools { get; set; }
        public virtual ICollection<ReportJobSchedule> ReportJobSchedules { get; set; }
        public virtual ICollection<ReportJob> ReportJobs { get; set; }
        public virtual ICollection<ReportMapping> ReportMappings { get; set; }
        public virtual ICollection<ReportParameter> ReportParameters { get; set; }
    }
}
