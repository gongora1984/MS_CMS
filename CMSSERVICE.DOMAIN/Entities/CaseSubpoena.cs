namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseSubpoena : Entity, IAuditableEntity
    {
        public CaseSubpoena()
        {
            CaseSubpoenaOrderInfos = new HashSet<CaseSubpoenaOrderInfo>();
        }

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

        public virtual ListItem? CaseSubpoenaClosedReason { get; set; }
        public virtual ListItem? CaseSubpoenaDocTransmissionMethod { get; set; }
        public virtual ListItem? CaseSubpoenaPcidataIncluded { get; set; }
        public virtual ListItem CaseSubpoenaStatus { get; set; } = null!;
        public virtual ListItem? CaseSubpoenaSubType { get; set; }
        public virtual ListItem? CaseSubpoenaType { get; set; }
        public virtual LoginDetailJobListing? CertificationMsrspecialist { get; set; }
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual LawPractice LawPractice { get; set; } = null!;
        public virtual LoginDetailJobListing ServicingMsrspecialist { get; set; } = null!;
        public virtual LoginDetailJobListing? TriageMsrspecialist { get; set; }
        public virtual ICollection<CaseSubpoenaOrderInfo> CaseSubpoenaOrderInfos { get; set; }
    }
}
