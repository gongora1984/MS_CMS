using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IRolePermissionRepository
{
    void AddRolePermission(AppRolePermission newRolPermission);

    Task<List<AppRolePermission>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<AppRolePermission?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
