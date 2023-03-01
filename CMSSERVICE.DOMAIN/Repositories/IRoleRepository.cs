using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IRoleRepository
{
    void AddRole(AppRole newRol);

    void AddUserRole(AppRoleLoginDetail newUserRole);

    Task<List<AppRole>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<AppRole?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<AppRole?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<AppRole?> GetRoleFromEnum(string roleName, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);
}
