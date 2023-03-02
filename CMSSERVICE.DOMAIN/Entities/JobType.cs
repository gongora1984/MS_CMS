namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class JobType : Entity, IAuditableEntity
    {
        public JobType()
        {
            ClientAssignmentTasks = new HashSet<ClientAssignmentTask>();
            ClientJobListings = new HashSet<ClientJobListing>();
            ClientJobs = new HashSet<ClientJob>();
            ClientLawPracticeJobTypes = new HashSet<ClientLawPracticeJobType>();
            DocumentTypes = new HashSet<DocumentType>();
            LawPracticeJobs = new HashSet<LawPracticeJob>();
            LoginDetailJobListings = new HashSet<LoginDetailJobListing>();
        }

        public string JobName { get; set; } = null!;
        public int JobDepartmentId { get; set; }
        public string? JobIconLocation { get; set; }
        public string? JobState { get; set; }
        public string? JobDataTable { get; set; }
        public string? JobPkfield { get; set; }
        public string? JobClientRefField { get; set; }
        public string JobSysCode { get; set; } = null!;
        public bool? IsMasterJob { get; set; }
        public string? JobTemplateLocation { get; set; }
        public bool? IsClientStart { get; set; }
        public bool? IsLawPracticeStart { get; set; }
        public bool? IsLocalCounselStart { get; set; }
        public bool? CanHaveMultiple { get; set; }
        public bool? CanCreateNewCase { get; set; }

        public virtual ICollection<ClientAssignmentTask> ClientAssignmentTasks { get; set; }
        public virtual ICollection<ClientJobListing> ClientJobListings { get; set; }
        public virtual ICollection<ClientJob> ClientJobs { get; set; }
        public virtual ICollection<ClientLawPracticeJobType> ClientLawPracticeJobTypes { get; set; }
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public virtual ICollection<LawPracticeJob> LawPracticeJobs { get; set; }
        public virtual ICollection<LoginDetailJobListing> LoginDetailJobListings { get; set; }
    }
}
