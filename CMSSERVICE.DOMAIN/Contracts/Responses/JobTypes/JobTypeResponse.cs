namespace CMSSERVICE.DOMAIN.Contracts.Responses.JobTypes;

public class JobTypeResponse
{
    public int Id { get; set; }
    public string JobName { get; set; } = null!;
    public int JobDepartmentId { get; set; }
    public string? JobIconLocation { get; set; }
    public string? JobState { get; set; }
    public string? JobDataTable { get; set; }
    public string? JobPkfield { get; set; }
    public string? JobClientRefField { get; set; }
    public string JobSysCode { get; set; } = null!;
    public bool? IsMasterJob { get; set; }
    public string? JobTemplateLocation { get; set; }
    public bool? IsClientStart { get; set; }
    public bool? IsLawPracticeStart { get; set; }
    public bool? IsLocalCounselStart { get; set; }
    public bool? CanHaveMultiple { get; set; }
    public bool? CanCreateNewCase { get; set; }
}
