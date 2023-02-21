using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LawPracticeUser : Entity, IAuditableEntity
    {
        public LawPracticeUser()
        {
            CaseReplevinAssignedAttyNavigations = new HashSet<CaseReplevin>();
            CaseReplevinAssignedParaNavigations = new HashSet<CaseReplevin>();
        }

        public int LawPracticeUserId { get; set; }
        public bool Enabled { get; set; }
        public bool IsAttorney { get; set; }
        public bool IsPara { get; set; }
        public bool IsPartner { get; set; }
        public string? AttyBarNumber { get; set; }
        public string? AttyPinNumer { get; set; }
        public string? AttyLastPinCreated { get; set; }
        public bool? IsRemote { get; set; }
        public bool? IsLocalCounsel { get; set; }
        public decimal? HourlyConntractRate { get; set; }
        public string? Smsemail { get; set; }
        public string? ActionTypeCode { get; set; }
        public int? MgrLawPracticeUserId { get; set; }
        public string? Smtpemail { get; set; }
        public string? LawPracticeUserName { get; set; }
        public string? AttySignImagePath { get; set; }
        public int LawPracticeId { get; set; }
        public int? ClientId { get; set; }
        public int LoginDetailId { get; set; }

        public virtual Client? Client { get; set; }
        public virtual LawPractice LawPractice { get; set; } = null!;
        public virtual LoginDetail LoginDetail { get; set; } = null!;
        public virtual ICollection<CaseReplevin> CaseReplevinAssignedAttyNavigations { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinAssignedParaNavigations { get; set; }
    }
}
