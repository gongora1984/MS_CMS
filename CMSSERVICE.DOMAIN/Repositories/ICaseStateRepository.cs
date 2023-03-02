using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface ICaseStateRepository
{
    void AddCaseState(CaseState newCaseState);

    Task<List<CaseState>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<CaseState?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<CaseState?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<CaseState?> GetByAbbrevAsync(string abbrev, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> IsAbbrevUniqueAsync(string abbrev, CancellationToken cancellationToken = default);
}
