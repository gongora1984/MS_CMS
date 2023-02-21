using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class Bkrdistrict : Entity, IAuditableEntity
    {
        public Bkrdistrict()
        {
            CaseBkrs = new HashSet<CaseBkr>();
        }

        public int BkrdistrictId { get; set; }
        public string StateId { get; set; } = null!;
        public string DistrictName { get; set; } = null!;
        public int ListOrder { get; set; }
        public string? ClientBkcourtJurisdiction { get; set; }

        public virtual ICollection<CaseBkr> CaseBkrs { get; set; }
    }
}
