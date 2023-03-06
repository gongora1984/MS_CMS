using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface ICaseCourtRepository
{
    void AddCaseCourt(CaseCourt newCaseCourt);

    Task<List<CaseCourt>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<List<CaseCourt>> GetAllByTypeAsync(int courtTypeLid, CancellationToken cancellationToken = default);

    Task<List<CaseCourt>> GetAllByCountyAsync(int countyId, CancellationToken cancellationToken = default);

    Task<List<CaseCourt>> GetAllByDistrictAsync(int districtId, CancellationToken cancellationToken = default);

    Task<List<CaseCourt>> GetAllByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(int caseCountyId, int caseDistrictId, int courtTypeLid, string name, CancellationToken cancellationToken = default);

    void UpdateCaseCourt(CaseCourt existingCaseCourt);
}
