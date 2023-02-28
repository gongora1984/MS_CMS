namespace CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;

public class AllRolePermissionResponse
{
    public AllRolePermissionResponse()
    {
    }

    public AllRolePermissionResponse(IEnumerable<RolePermissionResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<RolePermissionResponse>? Items { get; set; }
}
