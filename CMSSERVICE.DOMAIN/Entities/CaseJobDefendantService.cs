namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseJobDefendantService : Entity, IAuditableEntity
    {
        public CaseJobDefendantService()
        {
            DocumentRepositories = new HashSet<DocumentRepository>();
        }

        public int LpdefendantId { get; set; }
        public string? Lpkey1 { get; set; }
        public string? DefendantWorkFlowKey { get; set; }
        public string? DefendantAlius { get; set; }
        public string? DefendantName { get; set; }
        public int? ServiceAddressId { get; set; }
        public bool? ServiceComplete { get; set; }
        public DateTime? ServiceDate { get; set; }
        public bool? ServiceNotAble { get; set; }
        public string? Notes { get; set; }
        public bool? AddressVacant { get; set; }
        public bool? IsMobileHome { get; set; }
        public bool? IsMultiPlex { get; set; }
        public DateTime? ServiceDefaultDate { get; set; }
        public DateTime? ServiceTta { get; set; }
        public int? CurrentWorkFlowId { get; set; }
        public DateTime? ServiceAnswerDate { get; set; }
        public DateTime? ServiceReturnedDate { get; set; }
        public int CaseJobDefendantId { get; set; }
        public int DocumentTypeId { get; set; }
        public int ClientAssignmentId { get; set; }
        public int ServiceStatusLid { get; set; }
        public int ServiceTypeLid { get; set; }

        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
        public virtual ClientAssignment ClientAssignment { get; set; } = null!;
        public virtual DocumentType DocumentType { get; set; } = null!;
        public virtual ListItem ServiceStatus { get; set; } = null!;
        public virtual ListItem ServiceType { get; set; } = null!;
        public virtual ICollection<DocumentRepository> DocumentRepositories { get; set; }
    }
}
