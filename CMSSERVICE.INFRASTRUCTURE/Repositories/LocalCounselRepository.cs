using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class LocalCounselRepository : ILocalCounselRepository
{
    private readonly ApplicationDbContext _dbContext;

    public LocalCounselRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddLocalCounsel(LocalCounsel newLocalCounsel) =>
        _dbContext.Set<LocalCounsel>().Add(newLocalCounsel);

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

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<LocalCounsel>()
            .AnyAsync(lc => lc.LccompanyName == name, cancellationToken);

    public void UpdateLocalCounsel(LocalCounsel existingLocalCounsel) =>
        _dbContext.Set<LocalCounsel>().Update(existingLocalCounsel);
}
