using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface ILawPracticeRepository
{
    Task<LawPractice?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<LawPractice?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<List<LawPractice>> GetAllAsync(CancellationToken cancellationToken = default);

    Task AddLawPractice(LawPractice newLawPractice);

    Task UpdateLawPractice(LawPractice existingLawPractice);
}
