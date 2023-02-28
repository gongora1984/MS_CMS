namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LocalCounsel : Entity, IAuditableEntity
    {
        public LocalCounsel()
        {
            CaseReplevins = new HashSet<CaseReplevin>();
            ClientJobs = new HashSet<ClientJob>();
            LoginDetails = new HashSet<LoginDetail>();
            ReportMappings = new HashSet<ReportMapping>();
        }

        public string Lcname { get; set; } = null!;
        public string LccompanyName { get; set; } = null!;
        public string? LcphoneNumber { get; set; }
        public string? LcemailAddress { get; set; }
        public string Lcaddress1 { get; set; } = null!;
        public string? Lcaddress2 { get; set; }
        public string Lccity { get; set; } = null!;
        public string Lcstate { get; set; } = null!;
        public string Lczip { get; set; } = null!;
        public int? LccountyId { get; set; }
        public bool? IsLcactive { get; set; }
        public string? LcbarNumber { get; set; }
        public string? LcmoduleType { get; set; }
        public string? LcfaxNumber { get; set; }
        public string? LogoLocation { get; set; }
        public string? LctrackingNumber { get; set; }

        public virtual ICollection<CaseReplevin> CaseReplevins { get; set; }
        public virtual ICollection<ClientJob> ClientJobs { get; set; }
        public virtual ICollection<LoginDetail> LoginDetails { get; set; }
        public virtual ICollection<ReportMapping> ReportMappings { get; set; }
    }
}
