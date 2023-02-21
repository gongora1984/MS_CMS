using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentTask : Entity, IAuditableEntity
    {
        public ClientAssignmentTask()
        {
            ClientAssignmentTaskCheckLists = new HashSet<ClientAssignmentTaskCheckList>();
            ClientAssignmentTaskScheduledClientAssignmentTasks = new HashSet<ClientAssignmentTaskScheduled>();
            ClientAssignmentTaskScheduledStartClientAssignmentTasks = new HashSet<ClientAssignmentTaskScheduled>();
            ClientAssignments = new HashSet<ClientAssignment>();
            InverseParentTask = new HashSet<ClientAssignmentTask>();
            LogonDetailsAssignmentPoolTasks = new HashSet<LogonDetailsAssignmentPoolTask>();
            LogonDetailsAssignmentPools = new HashSet<LogonDetailsAssignmentPool>();
        }

        public int ClientAssignmentTaskId { get; set; }
        public int ParentTaskId { get; set; }
        public int ClientDepartmentId { get; set; }
        public string Category { get; set; } = null!;
        public int CatListOrder { get; set; }
        public int ListOrder { get; set; }
        public string LawActionType { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsStartupTask { get; set; }
        public string AssignmentName { get; set; } = null!;
        public string? AssignmentCode { get; set; }
        public int AssignmentDuration { get; set; }
        public bool StopAllWorkUntilDone { get; set; }
        public string? HoldWorkOnDepts { get; set; }
        public bool RequiresAttyApproval { get; set; }
        public bool AlertAssigneeWhenComplete { get; set; }
        public bool AlertAttyWhenComplete { get; set; }
        public string? AlertEmailAddressWhenComplete { get; set; }
        public string? AutoAssignTheseWhenComplete { get; set; }
        public string? IntegrationCode1 { get; set; }
        public string? IntegrationCode2 { get; set; }
        public int? AcctFeeActivityCodeId { get; set; }
        public bool? BillOnCompletion { get; set; }
        public string? DefaultSecUserId { get; set; }
        public string? DefaultAssignmentText { get; set; }
        public int? DefaultPriority { get; set; }
        public bool StartAtReferral { get; set; }
        public string? CompleteActionDateName { get; set; }
        public string? AssignActionDate { get; set; }
        public string? CompleteCommand { get; set; }
        public string? CreateCommand { get; set; }
        public bool HasCheckList { get; set; }
        public bool RunCreateCmdOnTargetDate { get; set; }
        public bool? RequiresComplettion { get; set; }
        public bool? IsQueueTask { get; set; }
        public int MaxReprojectionDays { get; set; }
        public int MaxReprojections { get; set; }
        public bool AlertAttyOnReportject { get; set; }
        public bool AlertAllOnReproject { get; set; }
        public string? AlertOthersOnReproject { get; set; }
        public string? OptionalCompletionAssignments { get; set; }
        public int? SetHearingAppId { get; set; }
        public int? AcctFeeReasonId { get; set; }
        public string? HoldWorkOfAssignments { get; set; }
        public bool AssignmentCompletesChain { get; set; }
        public int? AcctFeeApprovalCoaitemId { get; set; }
        public bool RequireCoaapproval { get; set; }
        public bool AllowDuplicate { get; set; }
        public bool CloseDepartmentCase { get; set; }
        public int ShowWhenDueInDays { get; set; }
        public int ShowWhenEventInDays { get; set; }
        public bool? IsAttyreview { get; set; }
        public bool? IsHearingEvent { get; set; }
        public string? CalendarColor { get; set; }
        public string? ClientSystemDefualtCode { get; set; }
        public string? ClientSystemCommand { get; set; }
        public bool? RequireChecklistForCompletion { get; set; }
        public bool? AssignByFileLocation { get; set; }
        public bool? AblbiDirectional { get; set; }
        public bool? PrimaryTask { get; set; }
        public bool? AllowAnyToComplete { get; set; }
        public string? StartOnChainCompletion { get; set; }
        public string? CompleteOnChainCompletion { get; set; }
        public string? WebPortalTool { get; set; }
        public bool? CanBeAssignedToVender { get; set; }
        public bool? ShowChecklistByDefult { get; set; }
        public int? CloseFileReasonId { get; set; }
        public string? VoidOnComplete { get; set; }
        public string? DeleteOnComplete { get; set; }
        public bool? IsConsoleCompleteJob { get; set; }
        public bool? AutoAssignPara { get; set; }
        public bool? AutoAssignAtty { get; set; }
        public bool? RetainAssignee { get; set; }
        public bool? RequireEventDateOnComplete { get; set; }
        public bool? CheckDupsIfChainComplete { get; set; }
        public string? IntegrationTaskCode { get; set; }
        public bool? IsDocumentApprovalTask { get; set; }
        public string? MergeDocumentOnStart { get; set; }
        public string? MergeDocumentOnComplete { get; set; }
        public bool? ReturnDocument { get; set; }
        public string? ClaimState { get; set; }
        public int? PriorMileStone { get; set; }
        public int? UseForTagetTaskId { get; set; }
        public bool? UseCalendarDaysForTarget { get; set; }
        public bool? ShowDocumentAttachmentArea { get; set; }
        public int? MaxTimeOutOpen { get; set; }
        public bool? IsClientTask { get; set; }
        public bool? IsLawPracticeTask { get; set; }
        public bool? IsLocalCounselTask { get; set; }
        public bool? IsClientCompleteTask { get; set; }
        public bool? IsLawPracticeCompleteTask { get; set; }
        public bool? IsLocalCounselCompleteTask { get; set; }
        public int GroupCategory1 { get; set; }
        public int GroupCategory2 { get; set; }
        public int GroupCategory3 { get; set; }
        public int GroupCategory4 { get; set; }
        public int GroupCategory5 { get; set; }
        public int GroupCategory6 { get; set; }
        public int GroupCategory7 { get; set; }
        public bool? AllowParallel { get; set; }
        public string? AutoCompleteTaskIfExists { get; set; }
        public string? IgnorHoldsFromTaskIds { get; set; }
        public int ClientId { get; set; }
        public int JobTypeId { get; set; }
        public int? RequiresDocumentId { get; set; }
        public int? AssocMergePackageId { get; set; }

        public virtual MergeDocument? AssocMergePackage { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual JobType JobType { get; set; } = null!;
        public virtual ClientAssignmentTask ParentTask { get; set; } = null!;
        public virtual DocumentType? RequiresDocument { get; set; }
        public virtual ICollection<ClientAssignmentTaskCheckList> ClientAssignmentTaskCheckLists { get; set; }
        public virtual ICollection<ClientAssignmentTaskScheduled> ClientAssignmentTaskScheduledClientAssignmentTasks { get; set; }
        public virtual ICollection<ClientAssignmentTaskScheduled> ClientAssignmentTaskScheduledStartClientAssignmentTasks { get; set; }
        public virtual ICollection<ClientAssignment> ClientAssignments { get; set; }
        public virtual ICollection<ClientAssignmentTask> InverseParentTask { get; set; }
        public virtual ICollection<LogonDetailsAssignmentPoolTask> LogonDetailsAssignmentPoolTasks { get; set; }
        public virtual ICollection<LogonDetailsAssignmentPool> LogonDetailsAssignmentPools { get; set; }
    }
}
