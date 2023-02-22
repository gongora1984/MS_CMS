namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LawPracticeJob : Entity, IAuditableEntity
    {
        public LawPracticeJob()
        {
            DocumentRepositories = new HashSet<DocumentRepository>();
        }

        public bool? Enabled { get; set; }
        public int ContectMemberId { get; set; }
        public string? LpfileNumber { get; set; }
        public string? Lpkey1 { get; set; }
        public int LawPracticeId { get; set; }
        public int JobTypeId { get; set; }

        public virtual JobType JobType { get; set; } = null!;
        public virtual LawPractice LawPractice { get; set; } = null!;
        public virtual ICollection<DocumentRepository> DocumentRepositories { get; set; }
    }
}
