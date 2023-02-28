using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface ILocalCounselRepository
{
    Task<LocalCounsel?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<LocalCounsel?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<List<LocalCounsel>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);

    Task AddLocalCounsel(LocalCounsel newLocalCounsel);

    Task UpdateLocalCounsel(LocalCounsel existingLocalCounsel);
}
