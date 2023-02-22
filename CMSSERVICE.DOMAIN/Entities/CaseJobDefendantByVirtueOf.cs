namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseJobDefendantByVirtueOf : Entity, IAuditableEntity
    {
        public int CaseJobDefendantId { get; set; }
        public int ByVirtueOfLid { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public string? Instrument { get; set; }

        public virtual ListItem ByVirtueOf { get; set; } = null!;
        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
    }
}
