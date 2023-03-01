using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class RolePermissionRepository : IRolePermissionRepository
{
    private readonly ApplicationDbContext _dbContext;
    public RolePermissionRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddRolePermission(AppRolePermission newRolPermission) =>
        _dbContext.Set<AppRolePermission>().Add(newRolPermission);

    public async Task<List<AppRolePermission>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppRolePermission>()
            .ToListAsync(cancellationToken);

    public async Task<AppRolePermission?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppRolePermission>()
            .FirstOrDefaultAsync(permission => permission.Id == id, cancellationToken);
}
