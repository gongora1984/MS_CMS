namespace CMSSERVICE.DOMAIN.Contracts.Responses.Common;

public class AllCaseCourtResponse
{
    public AllCaseCourtResponse()
    {
    }

    public AllCaseCourtResponse(IEnumerable<CaseCourtResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<CaseCourtResponse>? Items { get; set; }
}
