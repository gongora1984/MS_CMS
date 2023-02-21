using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrconditionalOrder : Entity, IAuditableEntity
    {
        public int BkyFilePaymentChangeId { get; set; }
        public DateTime? PaymentsDueFrom { get; set; }
        public DateTime? PaymentsDueTo { get; set; }
        public decimal? PaymentsDueAmt { get; set; }
        public decimal? PaymentsDueTotal { get; set; }
        public decimal? AttysFeesAndCosts { get; set; }
        public decimal? MnthlyPymntAmt { get; set; }
        public DateTime? NextPymntDt { get; set; }
        public decimal? TotalDelinquency { get; set; }
        public decimal? TotalDueDiv6Months { get; set; }
        public int CaseBkrid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
