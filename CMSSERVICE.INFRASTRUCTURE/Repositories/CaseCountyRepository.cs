using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class CaseCountyRepository : ICaseCountyRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CaseCountyRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddCaseCounty(CaseCounty newCaseCounty) =>
        _dbContext.Set<CaseCounty>().Add(newCaseCounty);

    public async Task<List<CaseCounty>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCounty>()
            .ToListAsync(cancellationToken);

    public async Task<CaseCounty?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCounty>()
            .FirstOrDefaultAsync(county => county.Id == id, cancellationToken);

    public async Task<CaseCounty?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCounty>()
            .FirstOrDefaultAsync(county => county.County == name, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<CaseCounty>()
            .AnyAsync(county => county.County == name, cancellationToken);

    public void UpdateCaseCounty(CaseCounty existingCaseCounty) =>
        _dbContext.Set<CaseCounty>().Update(existingCaseCounty);
}
