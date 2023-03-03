using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class JobTypeRepository : IJobTypeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public JobTypeRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddJobType(JobType newJobType) =>
        _dbContext.Set<JobType>().Add(newJobType);

    public async Task<List<JobType>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<JobType>()
            .ToListAsync(cancellationToken);

    public async Task<JobType?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<JobType>()
            .FirstOrDefaultAsync(jt => jt.Id == id, cancellationToken);

    public async Task<JobType?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<JobType>()
            .FirstOrDefaultAsync(jt => jt.JobName == name, cancellationToken);

    public async Task<JobType?> GetBySysCodeAsync(string syscode, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<JobType>()
            .FirstOrDefaultAsync(jt => jt.JobSysCode == syscode, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<JobType>()
            .AnyAsync(jt => jt.JobName == name, cancellationToken);

    public void UpdateJobType(JobType existingJobType) =>
        _dbContext.Set<JobType>().Update(existingJobType);
}
