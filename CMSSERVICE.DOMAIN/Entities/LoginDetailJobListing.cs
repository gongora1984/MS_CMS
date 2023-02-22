namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LoginDetailJobListing : Entity, IAuditableEntity
    {
        public LoginDetailJobListing()
        {
            CaseSubpoenaCertificationMsrspecialists = new HashSet<CaseSubpoena>();
            CaseSubpoenaServicingMsrspecialists = new HashSet<CaseSubpoena>();
            CaseSubpoenaTriageMsrspecialists = new HashSet<CaseSubpoena>();
        }

        public int JobTypeId { get; set; }
        public int LoginDetailId { get; set; }

        public virtual JobType JobType { get; set; } = null!;
        public virtual LoginDetail LoginDetail { get; set; } = null!;
        public virtual ICollection<CaseSubpoena> CaseSubpoenaCertificationMsrspecialists { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenaServicingMsrspecialists { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenaTriageMsrspecialists { get; set; }
    }
}
