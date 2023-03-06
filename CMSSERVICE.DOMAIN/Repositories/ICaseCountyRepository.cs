using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface ICaseCountyRepository
{
    void AddCaseCounty(CaseCounty newCaseCounty);

    Task<List<CaseCounty>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<CaseCounty?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<CaseCounty?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);

    void UpdateCaseCounty(CaseCounty existingCaseCounty);
}
