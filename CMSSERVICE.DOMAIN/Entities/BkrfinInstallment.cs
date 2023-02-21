namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrFinInstallment : Entity, IAuditableEntity
    {
        public int NumberofInstallments { get; set; }
        public decimal? AmountofInstallments { get; set; }
        public decimal? TotalInstallmentAmount { get; set; }
        public string? DateofInstallment { get; set; }
        public int CaseBkrId { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
