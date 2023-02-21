using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseSubpoena : Entity, IAuditableEntity
    {
        public CaseSubpoena()
        {
            CaseSubpoenaOrderInfos = new HashSet<CaseSubpoenaOrderInfo>();
        }

        public int CaseSubpoenaId { get; set; }
        public string OpenedDate { get; set; } = null!;
        public string? State { get; set; }
        public string LpreferenceId { get; set; } = null!;
        public string? CourtCaseNumber { get; set; }
        public DateTime? ServiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? NegotiatedDueDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? CountyId { get; set; }
        public string? HoldReasons { get; set; }
        public string? SubpoenaFormNumber { get; set; }
        public int ClientJobId { get; set; }
        public int LawPracticeId { get; set; }
        public int CaseSubpoenaStatusLid { get; set; }
        public int? CaseSubpoenaTypeLid { get; set; }
        public int? CaseSubpoenaSubTypeLid { get; set; }
        public int? CaseSubpoenaClosedReasonLid { get; set; }
        public int? CaseSubpoenaPcidataIncludedLid { get; set; }
        public int? CaseSubpoenaDocTransmissionMethodLid { get; set; }
        public int? TriageMsrspecialistId { get; set; }
        public int ServicingMsrspecialistId { get; set; }
        public int? CertificationMsrspecialistId { get; set; }

        public virtual ListItem? CaseSubpoenaClosedReasonL { get; set; }
        public virtual ListItem? CaseSubpoenaDocTransmissionMethodL { get; set; }
        public virtual ListItem? CaseSubpoenaPcidataIncludedL { get; set; }
        public virtual ListItem CaseSubpoenaStatusL { get; set; } = null!;
        public virtual ListItem? CaseSubpoenaSubTypeL { get; set; }
        public virtual ListItem? CaseSubpoenaTypeL { get; set; }
        public virtual LoginDetailJobListing? CertificationMsrspecialist { get; set; }
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual LawPractice LawPractice { get; set; } = null!;
        public virtual LoginDetailJobListing ServicingMsrspecialist { get; set; } = null!;
        public virtual LoginDetailJobListing? TriageMsrspecialist { get; set; }
        public virtual ICollection<CaseSubpoenaOrderInfo> CaseSubpoenaOrderInfos { get; set; }
    }
}
