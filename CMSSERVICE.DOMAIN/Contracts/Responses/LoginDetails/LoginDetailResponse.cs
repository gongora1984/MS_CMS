namespace CMSSERVICE.DOMAIN.Contracts.Responses.LoginDetails;

public class LoginDetailResponse
{
    public int Id { get; set; }
    public string LoginId { get; set; } = null!;
    public string LoginUserName { get; set; } = null!;
    public bool? IsEnabled { get; set; }
    public bool? IsApproved { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
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
}
