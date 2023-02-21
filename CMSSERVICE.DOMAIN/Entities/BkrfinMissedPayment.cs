namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrFinMissedPayment : Entity, IAuditableEntity
    {
        public DateTime? MpfromDate { get; set; }
        public decimal? MppandI { get; set; }
        public decimal? Mpescrow { get; set; }
        public decimal? Mptotal { get; set; }
        public DateTime? MptoDate { get; set; }
        public int? MpnumberOfMissedPayments { get; set; }
        public int CaseBkrId { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
