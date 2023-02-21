using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseWrit : Entity, IAuditableEntity
    {
        public CaseWrit()
        {
            CaseWritFinancials = new HashSet<CaseWritFinancial>();
        }

        public int CaseWritId { get; set; }
        public DateTime? CaseOpenedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? LpreferenceId { get; set; }
        public string? State { get; set; }
        public string? CourtCaseNum { get; set; }
        public string? Garnishor { get; set; }
        public DateTime? AnswerDueDate { get; set; }
        public DateTime? AnswerFiledDate { get; set; }
        public string? AccountNumber { get; set; }
        public decimal? GarnishmentDebtAmt { get; set; }
        public decimal? CheckIssuedAmt { get; set; }
        public DateTime? WritServiceDate { get; set; }
        public DateTime? WritFiledDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? HearingDate { get; set; }
        public DateTime? MailScannedDate { get; set; }
        public DateTime? EwlcreationDate { get; set; }
        public DateTime? FundsRemittanceDate { get; set; }
        public string? EwlcaseNumber { get; set; }
        public int ClientJobId { get; set; }
        public int CaseWritStatusLid { get; set; }
        public int? ClosedReasonLid { get; set; }
        public int? CaseTypeLid { get; set; }
        public int? CountyId { get; set; }
        public int? CaseDetailLid { get; set; }
        public int? CourtTypeId { get; set; }
        public int? GarnisheeId { get; set; }
        public int? RtgLid { get; set; }
        public int? AdditionalDocumentationLid { get; set; }

        public virtual ListItem? AdditionalDocumentationL { get; set; }
        public virtual ListItem? CaseDetailL { get; set; }
        public virtual ListItem? CaseTypeL { get; set; }
        public virtual ListItem CaseWritStatusL { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ListItem? ClosedReasonL { get; set; }
        public virtual CaseCounty? County { get; set; }
        public virtual CaseCourt? CourtType { get; set; }
        public virtual Garnishee? Garnishee { get; set; }
        public virtual ListItem? RtgL { get; set; }
        public virtual ICollection<CaseWritFinancial> CaseWritFinancials { get; set; }
    }
}
