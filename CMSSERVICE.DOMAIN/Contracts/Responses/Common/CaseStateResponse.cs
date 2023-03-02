namespace CMSSERVICE.DOMAIN.Contracts.Responses.Common;

public class CaseStateResponse
{
    public int Id { get; set; }
    public string StateAbbrev { get; set; } = null!;
    public string StateName { get; set; } = null!;
}
