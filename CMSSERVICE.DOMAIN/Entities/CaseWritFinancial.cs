using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseWritFinancial : Entity, IAuditableEntity
    {
        public int CaseWritFinancialId { get; set; }
        public string? AcctLast4 { get; set; }
        public decimal? AmtinAcct { get; set; }
        public decimal? FedBenefitsOverLookback { get; set; }
        public decimal? AmtOnHold { get; set; }
        public string? AcctNotes { get; set; }
        public decimal? ProtectedAmt { get; set; }
        public decimal? TotalAmtOnHold { get; set; }
        public string? AcctHolderName { get; set; }
        public decimal? ExemptionAmount { get; set; }
        public int CaseWritId { get; set; }
        public int? AcctStatusLid { get; set; }
        public int? AcctStylingLid { get; set; }

        public virtual ListItem? AcctStatusL { get; set; }
        public virtual ListItem? AcctStylingL { get; set; }
        public virtual CaseWrit CaseWrit { get; set; } = null!;
    }
}
