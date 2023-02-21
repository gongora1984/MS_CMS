using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseJobDefendantAtty : Entity, IAuditableEntity
    {
        public CaseJobDefendantAtty()
        {
            CaseJobDefendants = new HashSet<CaseJobDefendant>();
        }

        public int CaseJobDefendantAttyId { get; set; }
        public string AttorneyName { get; set; } = null!;
        public string? LawPracticeName { get; set; }
        public string? AttyBarNumber { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? EmailAddress { get; set; }
        public string? BusPhoneNum { get; set; }
        public string? EmailAddress2 { get; set; }
        public int? LoginDetailsId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CaseJobDefendant> CaseJobDefendants { get; set; }
    }
}
