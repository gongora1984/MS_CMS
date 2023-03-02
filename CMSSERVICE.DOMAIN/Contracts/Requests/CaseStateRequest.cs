namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record CaseStateRequest(
    string StateAbbrev,
    string StateName);
