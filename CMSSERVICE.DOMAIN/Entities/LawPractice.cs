namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LawPractice : Entity, IAuditableEntity
    {
        public LawPractice()
        {
            CaseSubpoenas = new HashSet<CaseSubpoena>();
            ClientAssignmentHolds = new HashSet<ClientAssignmentHold>();
            ClientJobs = new HashSet<ClientJob>();
            ClientLawPractices = new HashSet<ClientLawPractice>();
            LawPracticeJobs = new HashSet<LawPracticeJob>();
            LawPracticeUsers = new HashSet<LawPracticeUser>();
            LoginDetails = new HashSet<LoginDetail>();
            ReportMappings = new HashSet<ReportMapping>();
        }

        public string PracticeName { get; set; } = null!;
        public string PracticeContact { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string ContactBarNumber { get; set; } = null!;
        public string? PracticeLogoLocation { get; set; }
        public string? CurrentCmssystem { get; set; }
        public bool? HasDevelopmentStaff { get; set; }
        public bool? HasEfileAbility { get; set; }
        public int? NumberOfAttorneys { get; set; }
        public string? PaymentType { get; set; }
        public string? CardNumber { get; set; }
        public string? CardExpirationDate { get; set; }
        public string? CardName { get; set; }
        public string? CardDisplayNumber { get; set; }
        public string? ServiceEventsUrl { get; set; }
        public string? ServiceEventsLogon { get; set; }
        public string? ServiceEventsPass { get; set; }
        public string? ReferralCompanyCode { get; set; }
        public string? FirmStateCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FaxNumber { get; set; }
        public int? ClientId { get; set; }
        public int PracticeTypeLid { get; set; }

        public virtual Client? Client { get; set; }
        public virtual ListItem PracticeType { get; set; } = null!;
        public virtual ICollection<CaseSubpoena> CaseSubpoenas { get; set; }
        public virtual ICollection<ClientAssignmentHold> ClientAssignmentHolds { get; set; }
        public virtual ICollection<ClientJob> ClientJobs { get; set; }
        public virtual ICollection<ClientLawPractice> ClientLawPractices { get; set; }
        public virtual ICollection<LawPracticeJob> LawPracticeJobs { get; set; }
        public virtual ICollection<LawPracticeUser> LawPracticeUsers { get; set; }
        public virtual ICollection<LoginDetail> LoginDetails { get; set; }
        public virtual ICollection<ReportMapping> ReportMappings { get; set; }
    }
}
