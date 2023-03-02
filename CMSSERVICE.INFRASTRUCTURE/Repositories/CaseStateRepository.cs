using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class CaseStateRepository : ICaseStateRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CaseStateRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddCaseState(CaseState newCaseState) =>
        _dbContext.Set<CaseState>().Add(newCaseState);

    public async Task<List<CaseState>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseState>()
            .ToListAsync(cancellationToken);

    public async Task<CaseState?> GetByAbbrevAsync(string abbrev, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseState>()
            .FirstOrDefaultAsync(state => state.StateAbbrev == abbrev, cancellationToken);

    public async Task<CaseState?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseState>()
            .FirstOrDefaultAsync(role => role.Id == id, cancellationToken);

    public async Task<CaseState?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseState>()
            .FirstOrDefaultAsync(state => state.StateName == name, cancellationToken);

    public async Task<bool> IsAbbrevUniqueAsync(string abbrev, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<CaseState>()
            .AnyAsync(role => role.StateAbbrev == abbrev, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<CaseState>()
            .AnyAsync(role => role.StateName == name, cancellationToken);
}
