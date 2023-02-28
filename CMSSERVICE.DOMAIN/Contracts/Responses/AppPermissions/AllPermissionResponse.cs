namespace CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;

public class AllPermissionResponse
{
    public AllPermissionResponse()
    {
    }

    public AllPermissionResponse(IEnumerable<PermissionResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<PermissionResponse>? Items { get; set; }
}
