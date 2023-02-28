using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class RoleRepository : GenericRepository<AppRole>, IRoleRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RoleRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddRole(AppRole newRol) =>
        await Add(newRol);

    public async Task<List<AppRole>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppRole>()
            .ToListAsync(cancellationToken);

    public async Task<AppRole?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppRole>()
            .FirstOrDefaultAsync(role => role.Id == id, cancellationToken);

    public async Task<AppRole?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppRole>()
            .FirstOrDefaultAsync(role => role.Name == name, cancellationToken);

    public async Task<AppRole?> GetRoleFromEnum(string roleName, CancellationToken cancellationToken = default) =>
           await _dbContext
              .Set<AppRole>()
              .FirstOrDefaultAsync(role => role.Name == roleName, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<AppRole>()
            .AnyAsync(role => role.Name == name, cancellationToken);
}
