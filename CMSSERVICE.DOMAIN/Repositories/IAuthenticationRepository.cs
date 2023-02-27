using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Enums;

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

    Task UpdateUser(LoginDetail existingUser);
}

public interface IRoleRepository
{
    Task AddUserRole(AppRoleLoginDetail newUserRol);

    Task<List<AppRole>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<AppRole?> GetRoleFromEnum(Roles role, CancellationToken cancellationToken = default);
}
