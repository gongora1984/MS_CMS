using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class DocumentRepository : Entity, IAuditableEntity
    {
        public DocumentRepository()
        {
            CaseJobDefendants = new HashSet<CaseJobDefendant>();
            CaseTitles = new HashSet<CaseTitle>();
            ClientAssignmentCompleteDocumentRepositories = new HashSet<ClientAssignment>();
            ClientAssignmentHolds = new HashSet<ClientAssignmentHold>();
            ClientAssignmentReProHistories = new HashSet<ClientAssignmentReProHistory>();
            ClientAssignmentStartedDocumentRepositories = new HashSet<ClientAssignment>();
            DocumentMailOutHistories = new HashSet<DocumentMailOutHistory>();
            DocumentNotes = new HashSet<DocumentNote>();
            InverseLastVersionDocument = new HashSet<DocumentRepository>();
            InverseNextVersionDocument = new HashSet<DocumentRepository>();
        }

        public int DocumentRepositoryId { get; set; }
        public int? NextVersionDocumentId { get; set; }
        public int? LastVersionDocumentId { get; set; }
        public string? DocumentName { get; set; }
        public string? FileLocationVirtualPath { get; set; }
        public string FileLocationPath { get; set; } = null!;
        public bool? IsCurrentVersion { get; set; }
        public int Version { get; set; }
        public string CameFrom { get; set; } = null!;
        public bool? IsDeleted { get; set; }
        public bool IsFiled { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public DateTime? DeliveredToDefendantsOn { get; set; }
        public string? InvoiceNumber { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? InvoiceFulfilmentDt { get; set; }
        public int DocumentTypeId { get; set; }
        public int ClientJobId { get; set; }
        public int? LawPracticeJobId { get; set; }
        public int? BoundCaseDefendantId { get; set; }
        public int? BoundServiceDefendantId { get; set; }
        public int? DeliveryMethodLid { get; set; }
        public int? BoundAssignmentId { get; set; }
        public int? FromCheckListId { get; set; }

        public virtual ClientAssignment? BoundAssignment { get; set; }
        public virtual CaseJobDefendant? BoundCaseDefendant { get; set; }
        public virtual CaseJobDefendantService? BoundServiceDefendant { get; set; }
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ListItem? DeliveryMethodL { get; set; }
        public virtual DocumentType DocumentType { get; set; } = null!;
        public virtual ClientAssignmentTaskCheckList? FromCheckList { get; set; }
        public virtual DocumentRepository? LastVersionDocument { get; set; }
        public virtual LawPracticeJob? LawPracticeJob { get; set; }
        public virtual DocumentRepository? NextVersionDocument { get; set; }
        public virtual ICollection<CaseJobDefendant> CaseJobDefendants { get; set; }
        public virtual ICollection<CaseTitle> CaseTitles { get; set; }
        public virtual ICollection<ClientAssignment> ClientAssignmentCompleteDocumentRepositories { get; set; }
        public virtual ICollection<ClientAssignmentHold> ClientAssignmentHolds { get; set; }
        public virtual ICollection<ClientAssignmentReProHistory> ClientAssignmentReProHistories { get; set; }
        public virtual ICollection<ClientAssignment> ClientAssignmentStartedDocumentRepositories { get; set; }
        public virtual ICollection<DocumentMailOutHistory> DocumentMailOutHistories { get; set; }
        public virtual ICollection<DocumentNote> DocumentNotes { get; set; }
        public virtual ICollection<DocumentRepository> InverseLastVersionDocument { get; set; }
        public virtual ICollection<DocumentRepository> InverseNextVersionDocument { get; set; }
    }
}
