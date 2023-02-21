using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseSalePubCost : Entity, IAuditableEntity
    {
        public int CaseSalePubCostsId { get; set; }
        public int? CaseSaleId { get; set; }
        public DateTime? PubDate { get; set; }
        public decimal? PubCost { get; set; }

        public virtual CaseSale? CaseSale { get; set; }
    }
}
