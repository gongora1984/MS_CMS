using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface ICaseJudgeRepository
{
    void AddCaseJudge(CaseJudge newCaseJudge);

    Task<List<CaseJudge>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<CaseJudge?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<List<CaseJudge>> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<List<CaseJudge>> GetByCourtNameAsync(string courtName, CancellationToken cancellationToken = default);

    Task<List<CaseJudge>> GetByCourtIdAsync(int caseCourtId, CancellationToken cancellationToken = default);

    Task<CaseJudge?> GetByNameCourtIdAsync(string name, int caseCourtId, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, int caseCourtId, CancellationToken cancellationToken = default);

    void UpdateCaseJudge(CaseJudge existingCaseJudge);
}
