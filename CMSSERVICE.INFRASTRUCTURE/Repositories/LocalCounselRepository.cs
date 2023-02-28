using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class LocalCounselRepository : GenericRepository<LocalCounsel>, ILocalCounselRepository
{
    private readonly ApplicationDbContext _dbContext;

    public LocalCounselRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddLocalCounsel(LocalCounsel newLocalCounsel) =>
        await Add(newLocalCounsel);

    public async Task<List<LocalCounsel>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LocalCounsel>()
            .ToListAsync(cancellationToken);

    public async Task<LocalCounsel?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LocalCounsel>()
            .FirstOrDefaultAsync(lp => lp.Id == id, cancellationToken);

    public async Task<LocalCounsel?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LocalCounsel>()
            .FirstOrDefaultAsync(lc => lc.Lcname == name, cancellationToken);

    public async Task UpdateLocalCounsel(LocalCounsel existingLocalCounsel) =>
        await Update(existingLocalCounsel);
}
