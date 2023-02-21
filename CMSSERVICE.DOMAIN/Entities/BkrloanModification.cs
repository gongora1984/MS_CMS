using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrloanModification : Entity, IAuditableEntity
    {
        public int BkrloanModificationId { get; set; }
        public decimal? ModifiedInterestRate { get; set; }
        public decimal? PrincipalAndInterest { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal? NewUnpaidPrincipalBal { get; set; }
        public int CaseBkrid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
