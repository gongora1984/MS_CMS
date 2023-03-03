namespace CMSSERVICE.DOMAIN.Contracts.Responses.CaseDistricts;

public class CaseDistrictResponse
{
    public int Id { get; set; }
    public string DistrictName { get; set; }
    public int ListOrder { get; set; }
    public int CaseStateId { get; set; }
}
