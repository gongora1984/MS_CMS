namespace CMSSERVICE.DOMAIN.Contracts.Responses.Common;

public class CaseCourtResponse
{
    public int Id { get; set; }
    public string CourtName { get; set; } = null!;
    public string? CountOfficalName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? Email { get; set; }
    public string? ClerkContact { get; set; }
    public string? CourtCurcit { get; set; }
    public string? PstcurcitCode { get; set; }
    public string? CourtNotes { get; set; }
    public string? Website { get; set; }
    public int CaseCountyId { get; set; }
    public int? CaseDistrictId { get; set; }
    public int? CourtTypeLid { get; set; }
}
