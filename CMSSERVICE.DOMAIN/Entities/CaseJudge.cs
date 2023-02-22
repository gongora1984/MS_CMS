namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseJudge : Entity, IAuditableEntity
    {
        public CaseJudge()
        {
            CaseEvictions = new HashSet<CaseEviction>();
            CaseFcls = new HashSet<CaseFcl>();
        }

        public string JudgeName { get; set; } = null!;
        public string? JudgeCourtName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Room { get; set; }
        public string? Location { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? SpeacialInstructions1 { get; set; }
        public int CaseCourtId { get; set; }

        public virtual CaseCourt CaseCourt { get; set; } = null!;
        public virtual ICollection<CaseEviction> CaseEvictions { get; set; }
        public virtual ICollection<CaseFcl> CaseFcls { get; set; }
    }
}
