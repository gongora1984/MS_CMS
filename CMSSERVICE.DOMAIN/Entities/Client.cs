namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class Client : Entity, IAuditableEntity
    {
        public Client()
        {
            CaseMasters = new HashSet<CaseMaster>();
            ClientAssignmentTasks = new HashSet<ClientAssignmentTask>();
            ClientFacilities = new HashSet<ClientFacility>();
            ClientJobListings = new HashSet<ClientJobListing>();
            ClientLawPractices = new HashSet<ClientLawPractice>();
            ClientStateLocations = new HashSet<ClientStateLocation>();
            DocumentTypes = new HashSet<DocumentType>();
            Garnishees = new HashSet<Garnishee>();
            LawPracticeUsers = new HashSet<LawPracticeUser>();
            LawPractices = new HashSet<LawPractice>();
            LoginDetails = new HashSet<LoginDetail>();
            ReportMappings = new HashSet<ReportMapping>();
            Reports = new HashSet<Report>();
        }

        public string ClientName { get; set; } = null!;
        public string ClientAddress1 { get; set; } = null!;
        public string ClientAddress2 { get; set; } = null!;
        public string ClientCity { get; set; } = null!;
        public string ClientState { get; set; } = null!;
        public string ClientZip { get; set; } = null!;
        public string ClientBillAddress1 { get; set; } = null!;
        public string ClientBillAddress2 { get; set; } = null!;
        public string ClientBillCity { get; set; } = null!;
        public string ClientBillState { get; set; } = null!;
        public string ClientBillZip { get; set; } = null!;
        public string ClientMainContact { get; set; } = null!;
        public string? ClientMailAlertLogEmail { get; set; }
        public string? ClientLogoLocation { get; set; }
        public string? ProvestClientCode { get; set; }
        public string? ClientFax { get; set; }
        public string? ClientPhone { get; set; }
        public bool? UseNativeTasksOnly { get; set; }
        public bool? IsReverseClient { get; set; }
        public string? GlobeClientCode { get; set; }
        public int ClientTypeLid { get; set; }

        public virtual ListItem ClientTypeL { get; set; } = null!;
        public virtual ICollection<CaseMaster> CaseMasters { get; set; }
        public virtual ICollection<ClientAssignmentTask> ClientAssignmentTasks { get; set; }
        public virtual ICollection<ClientFacility> ClientFacilities { get; set; }
        public virtual ICollection<ClientJobListing> ClientJobListings { get; set; }
        public virtual ICollection<ClientLawPractice> ClientLawPractices { get; set; }
        public virtual ICollection<ClientStateLocation> ClientStateLocations { get; set; }
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public virtual ICollection<Garnishee> Garnishees { get; set; }
        public virtual ICollection<LawPracticeUser> LawPracticeUsers { get; set; }
        public virtual ICollection<LawPractice> LawPractices { get; set; }
        public virtual ICollection<LoginDetail> LoginDetails { get; set; }
        public virtual ICollection<ReportMapping> ReportMappings { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
