using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrfinMissedPayment : Entity, IAuditableEntity
    {
        public int BkrfinMissedPaymentId { get; set; }
        public DateTime? MpfromDate { get; set; }
        public decimal? MppandI { get; set; }
        public decimal? Mpescrow { get; set; }
        public decimal? Mptotal { get; set; }
        public DateTime? MptoDate { get; set; }
        public int? MpnumberOfMissedPayments { get; set; }
        public int CaseBkrid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
