using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrfinOtherCost : Entity, IAuditableEntity
    {
        public int BkrotherCostId { get; set; }
        public string? CostName { get; set; }
        public decimal CostAmount { get; set; }
        public string? DateIncurred { get; set; }
        public string? OtherDescription { get; set; }
        public int? SupportDocumentRepositoryId { get; set; }
        public bool Lpapproved { get; set; }
        public bool ClientApproved { get; set; }
        public DateTime? WriteOffDate { get; set; }
        public string? WriteOffNote { get; set; }
        public int? WriteOffBy { get; set; }
        public string? ActionNeededNote { get; set; }
        public int CaseBkrid { get; set; }
        public int CostDecriptionLid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
        public virtual ListItem CostDecriptionL { get; set; } = null!;
    }
}
