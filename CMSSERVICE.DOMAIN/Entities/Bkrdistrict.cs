namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrDistrict : Entity, IAuditableEntity
    {
        public BkrDistrict()
        {
            CaseBkrs = new HashSet<CaseBkr>();
        }

        public string StateId { get; set; } = null!;
        public string DistrictName { get; set; } = null!;
        public int ListOrder { get; set; }
        public string? ClientBkcourtJurisdiction { get; set; }

        public virtual ICollection<CaseBkr> CaseBkrs { get; set; }
    }
}
