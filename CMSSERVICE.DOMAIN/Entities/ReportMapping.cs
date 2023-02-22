namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ReportMapping : Entity, IAuditableEntity
    {
        public int ReportId { get; set; }
        public int? LocalCounselId { get; set; }
        public int? LawPracticeId { get; set; }
        public int? ClientId { get; set; }

        public virtual Client? Client { get; set; }
        public virtual LawPractice? LawPractice { get; set; }
        public virtual LocalCounsel? LocalCounsel { get; set; }
        public virtual Report Report { get; set; } = null!;
    }
}
