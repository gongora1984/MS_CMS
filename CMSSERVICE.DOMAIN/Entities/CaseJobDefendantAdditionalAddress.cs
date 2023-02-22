namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseJobDefendantAdditionalAddress : Entity, IAuditableEntity
    {
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? StateId { get; set; }
        public string? Zip { get; set; }
        public bool? Active { get; set; }
        public bool IsInternational { get; set; }
        public int CaseJobDefendantId { get; set; }

        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
    }
}
