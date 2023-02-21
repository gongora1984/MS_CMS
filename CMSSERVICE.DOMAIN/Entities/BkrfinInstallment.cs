using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrfinInstallment : Entity, IAuditableEntity
    {
        public int BkrfinInstallmentsId { get; set; }
        public int NumberofInstallments { get; set; }
        public decimal? AmountofInstallments { get; set; }
        public decimal? TotalInstallmentAmount { get; set; }
        public string? DateofInstallment { get; set; }
        public int CaseBkrid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
