namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrMfr : Entity, IAuditableEntity
    {
        public int Mfrid { get; set; }
        public string? ReliefByPlan { get; set; }
        public string? StatementOfIntention { get; set; }
        public string? FinalJudgment { get; set; }
        public string? NegativeNotice { get; set; }
        public string? MotionGranted { get; set; }
        public string? Apoentered { get; set; }
        public string? TermsOfApo { get; set; }
        public int CaseBkrid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
