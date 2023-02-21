namespace CMSSERVICE.DOMAIN.Entities;

public partial class BkrCaseSummary : Entity, IAuditableEntity
{
    public string? ResidenceorHomestead { get; set; }
    public string? SurrenderedPursuant { get; set; }
    public string? ArrearageCured { get; set; }
    public string? ValuedorStripped { get; set; }
    public string? ProvidedPursuant { get; set; }
    public string? PropSurrendered { get; set; }
    public string? PropPaidDirectly { get; set; }
    public string? PropNotListed { get; set; }
    public string? Oedentered { get; set; }
    public string? PlanConfirmed { get; set; }
    public string? FinalJdgmntForeClosure { get; set; }
    public string? ExemptPursuant { get; set; }
    public string? TrusteeAbandonProp { get; set; }
    public string? ObtainedOed { get; set; }
    public string? PropertyProvidedPlan { get; set; }
    public string? DischargeOder { get; set; }
    public int CaseBkrId { get; set; }

    public virtual CaseBkr CaseBkr { get; set; } = null!;
}
