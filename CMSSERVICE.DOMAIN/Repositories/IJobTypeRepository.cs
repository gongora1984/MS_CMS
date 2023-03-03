using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IJobTypeRepository
{
    Task<JobType?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<JobType?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<JobType?> GetBySysCodeAsync(string syscode, CancellationToken cancellationToken = default);

    Task<List<JobType>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);

    void AddJobType(JobType newJobType);

    void UpdateJobType(JobType existingJobType);
}
