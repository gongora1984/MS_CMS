using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class DocumentType : Entity, IAuditableEntity
    {
        public DocumentType()
        {
            CaseJobDefendantServices = new HashSet<CaseJobDefendantService>();
            ClientAssignmentTasks = new HashSet<ClientAssignmentTask>();
            DocumentMailOutHistories = new HashSet<DocumentMailOutHistory>();
            DocumentRepositories = new HashSet<DocumentRepository>();
        }

        public int DocumentTypeId { get; set; }
        public string DocumentFileBase { get; set; } = null!;
        public string DocumentTitle { get; set; } = null!;
        public bool IsSecureDocument { get; set; }
        public bool IsMergeDocument { get; set; }
        public bool? HasVersioning { get; set; }
        public string? EnvokesFileAssignment { get; set; }
        public bool RegisterAsAction { get; set; }
        public string? ProvestDocumentCode { get; set; }
        public bool CanSendForService { get; set; }
        public string? SysDocumentCode { get; set; }
        public bool? SendCertified { get; set; }
        public bool? SendFirstClass { get; set; }
        public bool? IsClientView { get; set; }
        public bool? IsLawPracticeView { get; set; }
        public bool? IsLocalCounselView { get; set; }
        public bool AllowViewAll { get; set; }
        public bool AllowDuplicate { get; set; }
        public int ClientId { get; set; }
        public int DocumentCategoryLid { get; set; }
        public int? JobTypeId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ListItem DocumentCategoryL { get; set; } = null!;
        public virtual JobType? JobType { get; set; }
        public virtual ICollection<CaseJobDefendantService> CaseJobDefendantServices { get; set; }
        public virtual ICollection<ClientAssignmentTask> ClientAssignmentTasks { get; set; }
        public virtual ICollection<DocumentMailOutHistory> DocumentMailOutHistories { get; set; }
        public virtual ICollection<DocumentRepository> DocumentRepositories { get; set; }
    }
}
