using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrfinInterestRate : Entity, IAuditableEntity
    {
        public int BkrfinInterestRateId { get; set; }
        public DateTime? IrfromDate { get; set; }
        public DateTime? IttoDate { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? Irtotal { get; set; }
        public bool? IsFixedRate { get; set; }
        public bool? IsVariableRate { get; set; }
        public int CaseBkrid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
