using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseJobDefendantByVirtueOf : Entity, IAuditableEntity
    {
        public int CaseJobDefendantByVirtueOfId { get; set; }
        public int CaseJobDefendantId { get; set; }
        public int ByVirtueOfLid { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public string? Instrument { get; set; }

        public virtual ListItem ByVirtueOfL { get; set; } = null!;
        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
    }
}
