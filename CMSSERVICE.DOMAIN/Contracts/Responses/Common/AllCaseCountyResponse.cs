namespace CMSSERVICE.DOMAIN.Contracts.Responses.Common;

public class AllCaseCountyResponse
{
    public AllCaseCountyResponse()
    {
    }

    public AllCaseCountyResponse(IEnumerable<CaseCountyResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<CaseCountyResponse>? Items { get; set; }
}
