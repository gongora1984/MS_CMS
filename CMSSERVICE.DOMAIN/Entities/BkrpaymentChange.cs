namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrPaymentChange : Entity, IAuditableEntity
    {
        public decimal? CurrentEscrowPayment { get; set; }
        public decimal? CurrentInterestRate { get; set; }
        public decimal? CurrentPrincipalAndInterestRate { get; set; }
        public decimal? CurrentMrtgPmnt { get; set; }
        public decimal? NewEscrowPayment { get; set; }
        public decimal? NewInterestRate { get; set; }
        public decimal? NewPrincipalAndInterestRate { get; set; }
        public decimal? NewMrtgPmnt { get; set; }
        public decimal? NewTotalPayment { get; set; }
        public int CaseBkrId { get; set; }
        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
