namespace CMSSERVICE.DOMAIN.Entities;

public partial class LoginDetail : Entity, IAuditableEntity
{
    public LoginDetail()
    {
        AppRoleLoginDetails = new HashSet<AppRoleLoginDetail>();
        CaseEvictionJournals = new HashSet<CaseEvictionJournal>();
        CaseReplevins = new HashSet<CaseReplevin>();
        ClientAssignmentAssignedToNavigations = new HashSet<ClientAssignment>();
        ClientAssignmentChainCompletedByNavigations = new HashSet<ClientAssignment>();
        ClientAssignmentCompletedByNavigations = new HashSet<ClientAssignment>();
        ClientAssignmentCreatedByNavigations = new HashSet<ClientAssignment>();
        ClientAssignmentHoldApprovedBies = new HashSet<ClientAssignmentHold>();
        ClientAssignmentHoldDeniedBies = new HashSet<ClientAssignmentHold>();
        ClientAssignmentJournals = new HashSet<ClientAssignmentJournal>();
        ClientAssignmentLastAccessByNavigations = new HashSet<ClientAssignment>();
        ClientAssignmentReProHistoryApprovedByNavigations = new HashSet<ClientAssignmentReProHistory>();
        ClientAssignmentReProHistoryReprojectedByNavigations = new HashSet<ClientAssignmentReProHistory>();
        ClientAssignmentReprojectedByNavigations = new HashSet<ClientAssignment>();
        ClientAssignmentScheduleds = new HashSet<ClientAssignmentScheduled>();
        ClientAssignmentUpdatedByNavigations = new HashSet<ClientAssignment>();
        ClientAssignmentVoidedByNavigations = new HashSet<ClientAssignment>();
        ClientJobLegals = new HashSet<ClientJobLegal>();
        DocumentNotes = new HashSet<DocumentNote>();
        LawPracticeUsers = new HashSet<LawPracticeUser>();
        LoginDetailJobListings = new HashSet<LoginDetailJobListing>();
        LoginDetailsAccessRoles = new HashSet<LoginDetailsAccessRole>();
        LogonDetailSubordinateLoginDetails = new HashSet<LogonDetailSubordinate>();
        LogonDetailSubordinateSubordinateLoginDetails = new HashSet<LogonDetailSubordinate>();
        LogonDetailsAssignmentPools = new HashSet<LogonDetailsAssignmentPool>();
    }

    public int LoginTypeLid { get; set; }
    public string LoginId { get; set; } = null!;
    public string LoginPwd { get; set; } = null!;
    public string? AccessToken { get; set; }
    public string LoginUserName { get; set; } = null!;
    public bool? IsEnabled { get; set; }
    public bool? IsApproved { get; set; }
    public DateTime? LastLogin { get; set; }
    public string? CurrentToken { get; set; }
    public string? LogonIp { get; set; }
    public string? PhoneAppCode { get; set; }
    public bool? EnforcePasswordPol { get; set; }
    public int PasswordExpiresIn { get; set; }
    public string? LastPasswordChange { get; set; }
    public bool? SentSubscription { get; set; }
    public string? CompanyName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public bool? IsAcceptTermsandConditions { get; set; }
    public DateTime? TermsandConditionsAcceptDate { get; set; }
    public int PendingAttemptCount { get; set; }
    public DateTime? LockedAt { get; set; }
    public string? BarNumber { get; set; }
    public bool? IsLocked { get; set; }
    public bool? CanAccessMenu { get; set; }
    public bool? CanAccessReports { get; set; }
    public bool IsClientAdmin { get; set; }
    public bool? IsAdmin { get; set; }
    public bool? IsSysAdmin { get; set; }
    public bool? IsSuperAdmin { get; set; }
    public int? LawPracticeId { get; set; }
    public int? ClientId { get; set; }
    public int? LocalCounselId { get; set; }

    public virtual Client? Client { get; set; }
    public virtual LawPractice? LawPractice { get; set; }
    public virtual LocalCounsel? LocalCounsel { get; set; }
    public virtual ListItem LoginTypeL { get; set; } = null!;
    public virtual ICollection<AppRoleLoginDetail> AppRoleLoginDetails { get; set; }
    public virtual ICollection<CaseEvictionJournal> CaseEvictionJournals { get; set; }
    public virtual ICollection<CaseReplevin> CaseReplevins { get; set; }
    public virtual ICollection<ClientAssignment> ClientAssignmentAssignedToNavigations { get; set; }
    public virtual ICollection<ClientAssignment> ClientAssignmentChainCompletedByNavigations { get; set; }
    public virtual ICollection<ClientAssignment> ClientAssignmentCompletedByNavigations { get; set; }
    public virtual ICollection<ClientAssignment> ClientAssignmentCreatedByNavigations { get; set; }
    public virtual ICollection<ClientAssignmentHold> ClientAssignmentHoldApprovedBies { get; set; }
    public virtual ICollection<ClientAssignmentHold> ClientAssignmentHoldDeniedBies { get; set; }
    public virtual ICollection<ClientAssignmentJournal> ClientAssignmentJournals { get; set; }
    public virtual ICollection<ClientAssignment> ClientAssignmentLastAccessByNavigations { get; set; }
    public virtual ICollection<ClientAssignmentReProHistory> ClientAssignmentReProHistoryApprovedByNavigations { get; set; }
    public virtual ICollection<ClientAssignmentReProHistory> ClientAssignmentReProHistoryReprojectedByNavigations { get; set; }
    public virtual ICollection<ClientAssignment> ClientAssignmentReprojectedByNavigations { get; set; }
    public virtual ICollection<ClientAssignmentScheduled> ClientAssignmentScheduleds { get; set; }
    public virtual ICollection<ClientAssignment> ClientAssignmentUpdatedByNavigations { get; set; }
    public virtual ICollection<ClientAssignment> ClientAssignmentVoidedByNavigations { get; set; }
    public virtual ICollection<ClientJobLegal> ClientJobLegals { get; set; }
    public virtual ICollection<DocumentNote> DocumentNotes { get; set; }
    public virtual ICollection<LawPracticeUser> LawPracticeUsers { get; set; }
    public virtual ICollection<LoginDetailJobListing> LoginDetailJobListings { get; set; }
    public virtual ICollection<LoginDetailsAccessRole> LoginDetailsAccessRoles { get; set; }
    public virtual ICollection<LogonDetailSubordinate> LogonDetailSubordinateLoginDetails { get; set; }
    public virtual ICollection<LogonDetailSubordinate> LogonDetailSubordinateSubordinateLoginDetails { get; set; }
    public virtual ICollection<LogonDetailsAssignmentPool> LogonDetailsAssignmentPools { get; set; }
}
