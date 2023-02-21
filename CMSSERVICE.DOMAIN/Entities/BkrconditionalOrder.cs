namespace CMSSERVICE.DOMAIN.Entities;

public partial class BkrConditionalOrder : Entity, IAuditableEntity
{
    public DateTime? PaymentsDueFrom { get; set; }
    public DateTime? PaymentsDueTo { get; set; }
    public decimal? PaymentsDueAmt { get; set; }
    public decimal? PaymentsDueTotal { get; set; }
    public decimal? AttysFeesAndCosts { get; set; }
    public decimal? MnthlyPymntAmt { get; set; }
    public DateTime? NextPymntDt { get; set; }
    public decimal? TotalDelinquency { get; set; }
    public decimal? TotalDueDiv6Months { get; set; }
    public int CaseBkrId { get; set; }

    public virtual CaseBkr CaseBkr { get; set; } = null!;
}
