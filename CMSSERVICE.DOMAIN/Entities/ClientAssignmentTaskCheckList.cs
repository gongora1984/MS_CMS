using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentTaskCheckList : Entity, IAuditableEntity
    {
        public ClientAssignmentTaskCheckList()
        {
            ClientAssignmentCheckListCrs = new HashSet<ClientAssignmentCheckListCr>();
            ClientAssignmentCheckListVrs = new HashSet<ClientAssignmentCheckListVr>();
            ClientAssignmentTaskCheckListVrs = new HashSet<ClientAssignmentTaskCheckListVr>();
            ClientAssignmentTaskRules = new HashSet<ClientAssignmentTaskRule>();
            DocumentRepositories = new HashSet<DocumentRepository>();
        }

        public int ClientAssignmentTaskCheckListId { get; set; }
        public string TaskListName { get; set; } = null!;
        public int ListOrder { get; set; }
        public string? ProcessCommand { get; set; }
        public string? TaskListItemTag { get; set; }
        public string? DropSql { get; set; }
        public bool? UseTaskListItemId { get; set; }
        public string? UpdateTable { get; set; }
        public string? UpdateField { get; set; }
        public string? UpdateKeyField { get; set; }
        public string? UpdateKeyValue { get; set; }
        public bool? CompletesFileAssignmentTaskId { get; set; }
        public bool? StartsFileAssignmentsTaskId { get; set; }
        public string? AssignmentsYes { get; set; }
        public string? AssignmentsNo { get; set; }
        public string? CustomControlName { get; set; }
        public bool AutoCompletesTasks { get; set; }
        public string? RulesDefaultAssignments { get; set; }
        public bool UsesValueRules { get; set; }
        public bool ShowDefendantForStartAssignment { get; set; }
        public string? DropUpdaterControl { get; set; }
        public bool? BindDocumentToAssignment { get; set; }
        public string? DefaultValue { get; set; }
        public bool? AssignClientWitness { get; set; }
        public string? CustomWorkScheduleName { get; set; }
        public bool? AttachDropDocToAssDocument { get; set; }
        public string? MergeToken { get; set; }
        public bool? UpdateTopOne { get; set; }
        public string? OrderBy { get; set; }
        public bool? IsRequired { get; set; }
        public string? KillAssignmentSchedule { get; set; }
        public bool? IsConditional { get; set; }
        public bool? MirrorToComment { get; set; }
        public int ClientAssignmentTaskId { get; set; }
        public int CheckListTypeLid { get; set; }

        public virtual ListItem CheckListTypeL { get; set; } = null!;
        public virtual ClientAssignmentTask ClientAssignmentTask { get; set; } = null!;
        public virtual ICollection<ClientAssignmentCheckListCr> ClientAssignmentCheckListCrs { get; set; }
        public virtual ICollection<ClientAssignmentCheckListVr> ClientAssignmentCheckListVrs { get; set; }
        public virtual ICollection<ClientAssignmentTaskCheckListVr> ClientAssignmentTaskCheckListVrs { get; set; }
        public virtual ICollection<ClientAssignmentTaskRule> ClientAssignmentTaskRules { get; set; }
        public virtual ICollection<DocumentRepository> DocumentRepositories { get; set; }
    }
}
