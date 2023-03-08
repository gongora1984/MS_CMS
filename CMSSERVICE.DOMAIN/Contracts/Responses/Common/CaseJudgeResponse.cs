namespace CMSSERVICE.DOMAIN.Contracts.Responses.Common;

public class CaseJudgeResponse
{
    public int Id { get; set; }
    public string JudgeName { get; set; } = null!;
    public string? JudgeCourtName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Room { get; set; }
    public string? Location { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? SpeacialInstructions1 { get; set; }
    public int CaseCourtId { get; set; }
}
