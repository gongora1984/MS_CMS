namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrLoanModification : Entity, IAuditableEntity
    {
        public decimal? ModifiedInterestRate { get; set; }
        public decimal? PrincipalAndInterest { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal? NewUnpaidPrincipalBal { get; set; }
        public int CaseBkrId { get; set; }
        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
