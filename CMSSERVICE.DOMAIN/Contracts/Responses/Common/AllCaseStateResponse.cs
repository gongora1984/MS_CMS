namespace CMSSERVICE.DOMAIN.Contracts.Responses.Common;

public class AllCaseStateResponse
{
    public AllCaseStateResponse()
    {
    }

    public AllCaseStateResponse(IEnumerable<CaseStateResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<CaseStateResponse>? Items { get; set; }
}
