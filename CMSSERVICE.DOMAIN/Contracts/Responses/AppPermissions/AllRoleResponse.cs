namespace CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;

public class AllRoleResponse
{
    public AllRoleResponse()
    {
    }

    public AllRoleResponse(IEnumerable<RoleResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<RoleResponse>? Items { get; set; }
}
