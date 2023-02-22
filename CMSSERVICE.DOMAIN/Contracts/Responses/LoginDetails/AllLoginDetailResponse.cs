namespace CMSSERVICE.DOMAIN.Contracts.Responses.LoginDetails;

public class AllLoginDetailResponse
{
    public AllLoginDetailResponse()
    {
    }

    public AllLoginDetailResponse(IEnumerable<LoginDetailResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<LoginDetailResponse>? Items { get; set; }
}
