using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class LawPracticeRepository : ILawPracticeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public LawPracticeRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddLawPractice(LawPractice newLawPractice) =>
        _dbContext.Set<LawPractice>().Add(newLawPractice);

    public async Task<List<LawPractice>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LawPractice>()
            .ToListAsync(cancellationToken);

    public async Task<LawPractice?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LawPractice>()
            .FirstOrDefaultAsync(lp => lp.Id == id, cancellationToken);

    public async Task<LawPractice?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LawPractice>()
            .FirstOrDefaultAsync(lp => lp.PracticeName == name, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<LawPractice>()
            .AnyAsync(lp => lp.PracticeName == name, cancellationToken);

    public void UpdateLawPractice(LawPractice existingLawPractice) =>
        _dbContext.Set<LawPractice>().Update(existingLawPractice);
}
