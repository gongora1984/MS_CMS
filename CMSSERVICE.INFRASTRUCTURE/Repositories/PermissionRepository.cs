using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class PermissionRepository : GenericRepository<AppPermission>, IPermissionRepository
{
    private readonly ApplicationDbContext _dbContext;
    public PermissionRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddPermission(AppPermission newPermission) =>
        await Add(newPermission);

    public async Task<List<AppPermission>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppPermission>()
            .ToListAsync(cancellationToken);

    public async Task<AppPermission?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppPermission>()
            .FirstOrDefaultAsync(permission => permission.Id == id, cancellationToken);

    public async Task<AppPermission?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppPermission>()
            .FirstOrDefaultAsync(permission => permission.Name == name, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<AppPermission>()
            .AnyAsync(permission => permission.Name == name, cancellationToken);

    public async Task UpdatePermission(AppPermission existingPermission) =>
        await Update(existingPermission);
}
