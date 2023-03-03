namespace CMSSERVICE.DOMAIN.Contracts.Responses.CaseDistricts;

public class AllCaseDistrictResponse
{
    public AllCaseDistrictResponse()
    {
    }

    public AllCaseDistrictResponse(IEnumerable<CaseDistrictResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<CaseDistrictResponse>? Items { get; set; }
}
