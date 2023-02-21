using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleDlinqTax : Entity, IAuditableEntity
    {
        public int TitleDlinqTaxId { get; set; }
        public int ForYear { get; set; }
        public string? TaxId { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime TaxGoodUntil { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
    }
}
