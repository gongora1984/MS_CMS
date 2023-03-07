using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class CaseCourtRepository : ICaseCourtRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CaseCourtRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddCaseCourt(CaseCourt newCaseCourt) =>
        _dbContext.Set<CaseCourt>().Add(newCaseCourt);

    public async Task<List<CaseCourt>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCourt>()
            .ToListAsync(cancellationToken);

    public async Task<CaseCourt?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCourt>()
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

    public async Task<List<CaseCourt>> GetAllByCountyAsync(int countyId, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCourt>()
            .Where(court => court.CaseCountyId == countyId)
            .ToListAsync(cancellationToken);

    public async Task<List<CaseCourt>> GetAllByDistrictAsync(int districtId, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCourt>()
            .Where(court => court.CaseDistrictId == districtId)
            .ToListAsync(cancellationToken);

    public async Task<List<CaseCourt>> GetAllByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCourt>()
            .Where(court => court.CourtName == name)
            .ToListAsync(cancellationToken);

    public async Task<List<CaseCourt>> GetAllByTypeAsync(int courtTypeLid, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseCourt>()
            .Where(court => court.CourtTypeLid == courtTypeLid)
            .ToListAsync(cancellationToken);

    public async Task<bool> IsNameUniqueAsync(int caseCountyId, int caseDistrictId, int courtTypeLid, string name, CancellationToken cancellationToken = default) =>
        !await _dbContext
        .Set<CaseCourt>()
                .AnyAsync(
                    court => court.CaseCountyId == caseCountyId
                && (caseDistrictId > 0 ? court.CaseDistrictId == caseDistrictId : court.CaseDistrictId == null)
                && (courtTypeLid > 0 ? court.CourtTypeLid == courtTypeLid : court.CourtTypeLid == null)
                && court.CourtName == name, cancellationToken);

    public void UpdateCaseCourt(CaseCourt existingCaseCourt) =>
        _dbContext.Set<CaseCourt>().Update(existingCaseCourt);
}
