using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface ICaseDistrictRepository
{
    void AddCaseDistrict(CaseDistrict newCaseDistrict);

    Task<List<CaseDistrict>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<List<CaseDistrict>> GetAllInStateAsync(int stateid, CancellationToken cancellationToken = default);

    Task<CaseDistrict?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<List<CaseDistrict>?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<CaseDistrict?> GetByNameInStateAsync(string name, int stateid, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueInStateAsync(string name, int stateid, CancellationToken cancellationToken = default);

    Task<int> GetListOrderAsync(string name, int stateid, CancellationToken cancellationToken = default);

    void UpdateCaseDistrict(CaseDistrict existingCaseDistrict);
}
