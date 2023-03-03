namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record JobTypeRequest(
    string JobName,
    int JobDepartmentId,
    string? JobIconLocation,
    string? JobState,
    string? JobDataTable,
    string? JobPkfield,
    string? JobClientRefField,
    string JobSysCode,
    bool? IsMasterJob,
    string? JobTemplateLocation,
    bool? IsClientStart,
    bool? IsLawPracticeStart,
    bool? IsLocalCounselStart,
    bool? CanHaveMultiple,
    bool? CanCreateNewCase);
