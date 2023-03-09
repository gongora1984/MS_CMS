namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record CaseJudgeRequest(
    string JudgeName,
    string? JudgeCourtName,
    string? Address1,
    string? Address2,
    string? Room,
    string? Location,
    string? City,
    string? State,
    string? Zip,
    string? Phone,
    string? Fax,
    string? SpeacialInstructions1,
    int CaseCourtId);
