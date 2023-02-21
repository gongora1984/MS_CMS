using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientLawPractice : Entity, IAuditableEntity
    {
        public int ClientLawPracticeId { get; set; }
        public decimal AttyHourRate { get; set; }
        public bool? FirmwareUser { get; set; }
        public int ReferralPercent { get; set; }
        public bool? Enabled { get; set; }
        public string LawPracticeState { get; set; } = null!;
        public bool? FcldoesTitle { get; set; }
        public int ClientId { get; set; }
        public int LawPracticeId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual LawPractice LawPractice { get; set; } = null!;
    }
}
