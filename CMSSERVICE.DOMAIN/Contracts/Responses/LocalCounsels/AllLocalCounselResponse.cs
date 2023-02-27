namespace CMSSERVICE.DOMAIN.Contracts.Responses.LocalCounsels;

public class AllLocalCounselResponse
{
    public AllLocalCounselResponse()
    {
    }

    public AllLocalCounselResponse(IEnumerable<LocalCounselResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<LocalCounselResponse>? Items { get; set; }
}
