namespace CMSSERVICE.DOMAIN.Contracts.Responses.Clients;

public class AllClientResponse
{
    public AllClientResponse()
    {
    }

    public AllClientResponse(IEnumerable<ClientResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<ClientResponse>? Items { get; set; }
}
