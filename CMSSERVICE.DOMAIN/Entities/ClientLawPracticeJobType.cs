namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientLawPracticeJobType : Entity, IAuditableEntity
    {
        public int ReferralPercent { get; set; }
        public string? AlertReferralAddress { get; set; }
        public int TotalOpenCases { get; set; }
        public int TotalHeldCases { get; set; }
        public int AverageDaysToClose { get; set; }
        public int Rating { get; set; }
        public int? CustomTemplateId { get; set; }
        public int JobTypeId { get; set; }

        public virtual JobType JobType { get; set; } = null!;
    }
}
