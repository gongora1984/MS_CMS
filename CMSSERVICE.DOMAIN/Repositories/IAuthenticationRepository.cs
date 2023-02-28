using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IAuthenticationRepository
{
    Task<LoginDetail?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<LoginDetail?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

    Task<LoginDetail?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<List<LoginDetail>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<bool> IsEmailUniqueAsync(string email, CancellationToken cancellationToken = default);

    Task<bool> IsValidCredentialAsync(string email, string password, CancellationToken cancellationToken = default);

    Task AddUser(LoginDetail newUser);

    Task AddUserWithRoles(LoginDetail newUser, AppRole? userRole, CancellationToken cancellationToken = default);

    Task UpdateUser(LoginDetail existingUser);
}
