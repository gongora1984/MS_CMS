using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class RolePermissionRepository : GenericRepository<AppRolePermission>, IRolePermissionRepository
{
    private readonly ApplicationDbContext _dbContext;
    public RolePermissionRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddRolePermission(AppRolePermission newRolPermission) =>
        await Add(newRolPermission);

    public async Task<AppRolePermission?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppRolePermission>()
            .FirstOrDefaultAsync(permission => permission.Id == id, cancellationToken);
}
