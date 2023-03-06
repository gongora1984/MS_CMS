namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record CaseCourtRequest(
    string CourtName,
    string? CountOfficalName,
    string? Address1,
    string? Address2,
    string? City,
    string? State,
    string? Zip,
    string? Phone,
    string? Fax,
    string? Email,
    string? ClerkContact,
    string? CourtCurcit,
    string? PstcurcitCode,
    string? CourtNotes,
    string? Website,
    int CaseCountyId,
    int? CaseDistrictId,
    int? CourtTypeLid
    );
