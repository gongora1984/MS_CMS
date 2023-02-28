using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class LawPracticeRepository : GenericRepository<LawPractice>, ILawPracticeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public LawPracticeRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddLawPractice(LawPractice newLawPractice) =>
        await Add(newLawPractice);

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

    public async Task UpdateLawPractice(LawPractice existingLawPractice) =>
        await Update(existingLawPractice);
}
