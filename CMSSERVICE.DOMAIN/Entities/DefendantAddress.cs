using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class DefendantAddress : Entity, IAuditableEntity
    {
        public int CaseDefendantAddressId { get; set; }
        public bool AddressIsPrimary { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public bool ServedAtThisAddress { get; set; }
        public string? ServiceDate { get; set; }
        public bool NotFoundAtAddress { get; set; }
        public int CaseJobDefendantId { get; set; }

        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
    }
}
