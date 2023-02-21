using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseCol : Entity, IAuditableEntity
    {
        public CaseCol()
        {
            CaseColtransactions = new HashSet<CaseColtransaction>();
        }

        public int CaseColid { get; set; }
        public string LoanNumber { get; set; } = null!;
        public string? ClientCaseNumber { get; set; }
        public string? Referance { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime? FiledDate { get; set; }
        public DateTime? JudgmentDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public decimal? LastPaymentAmount { get; set; }
        public decimal? BeginingPrincipal { get; set; }
        public string? CompanyName { get; set; }
        public string? ClaimTypeDescription { get; set; }
        public string? CourtCaseNumber { get; set; }
        public string? DefendantCap { get; set; }
        public string? PlaintiffCap { get; set; }
        public decimal? InterestRate { get; set; }
        public string PropertyAddress1 { get; set; } = null!;
        public string? PropertyAddress2 { get; set; }
        public string PropertyCity { get; set; } = null!;
        public string PropertyState { get; set; } = null!;
        public string PropertyZip { get; set; } = null!;
        public string? InvestorTypeDesc { get; set; }
        public string? ClientAttyName { get; set; }
        public DateTime? Soldate { get; set; }
        public DateTime? DefaultDate { get; set; }
        public int ClientJobId { get; set; }
        public int? LastAssignmentId { get; set; }
        public int? NextAssignmentId { get; set; }
        public int? CaseColstatusLid { get; set; }
        public int? CaseColcloseReasonLid { get; set; }

        public virtual ListItem? CaseColcloseReasonL { get; set; }
        public virtual ListItem? CaseColstatusL { get; set; }
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ClientAssignment? LastAssignment { get; set; }
        public virtual ClientAssignment? NextAssignment { get; set; }
        public virtual ICollection<CaseColtransaction> CaseColtransactions { get; set; }
    }
}
