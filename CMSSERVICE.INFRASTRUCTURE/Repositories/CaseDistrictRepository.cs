using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class CaseDistrictRepository : ICaseDistrictRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CaseDistrictRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddCaseDistrict(CaseDistrict newCaseDistrict) =>
        _dbContext.Set<CaseDistrict>().Add(newCaseDistrict);

    public async Task<List<CaseDistrict>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseDistrict>()
            .ToListAsync(cancellationToken);

    public async Task<List<CaseDistrict>> GetAllInStateAsync(int stateid, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseDistrict>()
            .Where(cd => cd.CaseStateId == stateid)
            .ToListAsync(cancellationToken);

    public async Task<CaseDistrict?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseDistrict>()
            .FirstOrDefaultAsync(cd => cd.Id == id, cancellationToken);

    public async Task<List<CaseDistrict>?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseDistrict>()
            .Where(cd => cd.DistrictName == name)
            .ToListAsync(cancellationToken);

    public async Task<CaseDistrict?> GetByNameInStateAsync(string name, int stateid, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseDistrict>()
            .FirstOrDefaultAsync(cd => cd.DistrictName == name && cd.CaseStateId == stateid, cancellationToken);

    public async Task<int> GetListOrderAsync(string name, int stateid, CancellationToken cancellationToken = default)
    {
        var items = await GetAllInStateAsync(stateid, cancellationToken);

        return (items != null && items.Any()) ? items.Max(x => x.ListOrder) : 0;
    }

    public async Task<bool> IsNameUniqueInStateAsync(string name, int stateid, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<CaseDistrict>()
            .AnyAsync(cd => cd.DistrictName == name && cd.CaseStateId == stateid, cancellationToken);

    public void UpdateCaseDistrict(CaseDistrict existingCaseDistrict) =>
        _dbContext.Set<CaseDistrict>().Update(existingCaseDistrict);
}
