using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IRolePermissionRepository
{
    Task AddRolePermission(AppRolePermission newRolPermission);

    Task<AppRolePermission?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
