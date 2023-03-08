using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class CaseJudgeRepository : ICaseJudgeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CaseJudgeRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddCaseJudge(CaseJudge newCaseJudge) =>
        _dbContext.Set<CaseJudge>().Add(newCaseJudge);

    public async Task<List<CaseJudge>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseJudge>()
            .ToListAsync(cancellationToken);

    public async Task<List<CaseJudge>> GetByCourtNameAsync(string courtName, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseJudge>()
            .Where(x => x.JudgeCourtName == courtName)
            .ToListAsync(cancellationToken);

    public async Task<CaseJudge?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseJudge>()
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

    public async Task<List<CaseJudge>> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CaseJudge>()
            .Where(x => x.JudgeName == name)
            .ToListAsync(cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, int caseCourtId, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<CaseJudge>()
            .AnyAsync(x => x.JudgeName == name && x.CaseCourtId == caseCourtId, cancellationToken);

    public void UpdateCaseJudge(CaseJudge existingCaseJudge) =>
        _dbContext.Set<CaseJudge>().Update(existingCaseJudge);
}
