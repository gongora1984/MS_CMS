namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignment : Entity, IAuditableEntity
    {
        public ClientAssignment()
        {
            CaseColLastAssignments = new HashSet<CaseCol>();
            CaseColNextAssignments = new HashSet<CaseCol>();
            CaseJobDefendantSearchHistories = new HashSet<CaseJobDefendantSearchHistory>();
            CaseJobDefendantServices = new HashSet<CaseJobDefendantService>();
            ClientAssignmentCheckListVrs = new HashSet<ClientAssignmentCheckListVr>();
            ClientAssignmentHoldClientAssignmentParents = new HashSet<ClientAssignmentHold>();
            ClientAssignmentHoldClientAssignments = new HashSet<ClientAssignmentHold>();
            ClientAssignmentHoldHoldingAssignments = new HashSet<ClientAssignmentHold>();
            ClientAssignmentJournals = new HashSet<ClientAssignmentJournal>();
            ClientAssignmentReProHistories = new HashSet<ClientAssignmentReProHistory>();
            ClientAssignmentScheduledClientAssignments = new HashSet<ClientAssignmentScheduled>();
            ClientAssignmentScheduledFromClientAssignments = new HashSet<ClientAssignmentScheduled>();
            ClientJobActivities = new HashSet<ClientJobActivity>();
            DocumentMailOutHistories = new HashSet<DocumentMailOutHistory>();
            DocumentRepositories = new HashSet<DocumentRepository>();
            InverseChainCompletedAssignment = new HashSet<ClientAssignment>();
            InverseParentAssignment = new HashSet<ClientAssignment>();
            InverseStartedByAssignment = new HashSet<ClientAssignment>();
        }

        public int? StartedByAssignmentId { get; set; }
        public int ParentAssignmentId { get; set; }
        public int? ChainCompletedAssignmentId { get; set; }
        public int ClientDepartmentId { get; set; }
        public DateTime TargetDate { get; set; }
        public string? CreatedNote { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CompletedOn { get; set; }
        public int? CompletedBy { get; set; }
        public string? CompleteNotes { get; set; }
        public DateTime? EventDate { get; set; }
        public DateTime? ReprojectedOn { get; set; }
        public int? ReportectedVersion { get; set; }
        public int? AssignedDepartmentId { get; set; }
        public DateTime? AssignedOn { get; set; }
        public string? ProgressNotes { get; set; }
        public string? IntegrationId { get; set; }
        public string? IntegrationKey { get; set; }
        public string? IntegrationOther { get; set; }
        public DateTime LastAccessedDate { get; set; }
        public DateTime? ChainCompletedOn { get; set; }
        public string? StartTasksOnComplete { get; set; }
        public bool? CheckDupesonChainComplete { get; set; }
        public DateTime? ChainEventDate { get; set; }
        public DateTime? SnoozeUntilDate { get; set; }
        public string? AutomationId1 { get; set; }
        public string? AutomationId2 { get; set; }
        public DateTime? VoidedOn { get; set; }
        public bool? IsVoided { get; set; }
        public bool? SendtoServicer { get; set; }
        public bool? IsInProgress { get; set; }
        public string? EventType { get; set; }
        public decimal? EventAmount { get; set; }
        public string? AssociatedMileStones { get; set; }
        public int? ExtensionDuration { get; set; }
        public bool? IsExtensionEvent { get; set; }
        public bool? IsCarveOut { get; set; }
        public bool? IsBillableEvent { get; set; }
        public string? AttyCompleteCode { get; set; }
        public DateTime? AttyCompleteCodeEnteredOn { get; set; }
        public DateTime? AttyCompleteCodeIssued { get; set; }
        public string? AttyCompleteCodeEnc { get; set; }
        public int ClientAssignmentTaskId { get; set; }
        public int ClientJobId { get; set; }
        public int UpdatedBy { get; set; }
        public int? ReprojectedBy { get; set; }
        public int? StartedDocumentRepositoryId { get; set; }
        public int? CompleteDocumentRepositoryId { get; set; }
        public int? AssignedTo { get; set; }
        public int? CaseJobDefendantId { get; set; }
        public int? LastAccessBy { get; set; }
        public int? ChainCompletedBy { get; set; }
        public int? VoidedBy { get; set; }

        public virtual LoginDetail? AssignedToNavigation { get; set; }
        public virtual CaseJobDefendant? CaseJobDefendant { get; set; }
        public virtual ClientAssignment? ChainCompletedAssignment { get; set; }
        public virtual LoginDetail? ChainCompletedByNavigation { get; set; }
        public virtual ClientAssignmentTask ClientAssignmentTask { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual DocumentRepository? CompleteDocumentRepository { get; set; }
        public virtual LoginDetail? CompletedByNavigation { get; set; }
        public virtual LoginDetail CreatedByNavigation { get; set; } = null!;
        public virtual LoginDetail? LastAccessByNavigation { get; set; }
        public virtual ClientAssignment ParentAssignment { get; set; } = null!;
        public virtual LoginDetail? ReprojectedByNavigation { get; set; }
        public virtual ClientAssignment? StartedByAssignment { get; set; }
        public virtual DocumentRepository? StartedDocumentRepository { get; set; }
        public virtual LoginDetail UpdatedByNavigation { get; set; } = null!;
        public virtual LoginDetail? VoidedByNavigation { get; set; }
        public virtual ICollection<CaseCol> CaseColLastAssignments { get; set; }
        public virtual ICollection<CaseCol> CaseColNextAssignments { get; set; }
        public virtual ICollection<CaseJobDefendantSearchHistory> CaseJobDefendantSearchHistories { get; set; }
        public virtual ICollection<CaseJobDefendantService> CaseJobDefendantServices { get; set; }
        public virtual ICollection<ClientAssignmentCheckListVr> ClientAssignmentCheckListVrs { get; set; }
        public virtual ICollection<ClientAssignmentHold> ClientAssignmentHoldClientAssignmentParents { get; set; }
        public virtual ICollection<ClientAssignmentHold> ClientAssignmentHoldClientAssignments { get; set; }
        public virtual ICollection<ClientAssignmentHold> ClientAssignmentHoldHoldingAssignments { get; set; }
        public virtual ICollection<ClientAssignmentJournal> ClientAssignmentJournals { get; set; }
        public virtual ICollection<ClientAssignmentReProHistory> ClientAssignmentReProHistories { get; set; }
        public virtual ICollection<ClientAssignmentScheduled> ClientAssignmentScheduledClientAssignments { get; set; }
        public virtual ICollection<ClientAssignmentScheduled> ClientAssignmentScheduledFromClientAssignments { get; set; }
        public virtual ICollection<ClientJobActivity> ClientJobActivities { get; set; }
        public virtual ICollection<DocumentMailOutHistory> DocumentMailOutHistories { get; set; }
        public virtual ICollection<DocumentRepository> DocumentRepositories { get; set; }
        public virtual ICollection<ClientAssignment> InverseChainCompletedAssignment { get; set; }
        public virtual ICollection<ClientAssignment> InverseParentAssignment { get; set; }
        public virtual ICollection<ClientAssignment> InverseStartedByAssignment { get; set; }
    }
}
