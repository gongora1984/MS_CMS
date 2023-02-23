namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

public interface IPermissionService
{
    Task<HashSet<string>> GetPermissionsAsync(int userId);
}
