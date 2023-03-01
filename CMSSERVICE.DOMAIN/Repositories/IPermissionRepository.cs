using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IPermissionRepository
{
    void AddPermission(AppPermission newPermission);

    Task<List<AppPermission>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<AppPermission?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<AppPermission?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);

    void UpdatePermission(AppPermission existingPermission);
}