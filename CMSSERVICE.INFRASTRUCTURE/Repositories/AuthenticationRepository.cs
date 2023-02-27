using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Enums;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal class AuthenticationRepository : GenericRepository<LoginDetail>, IAuthenticationRepository
{
    private readonly ApplicationDbContext _dbContext;

    public AuthenticationRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddUser(LoginDetail newUser) =>
        await Add(newUser);
    public async Task<List<LoginDetail>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LoginDetail>()
            .ToListAsync(cancellationToken);

    public async Task<LoginDetail?> GetByEmailAsync(string email, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LoginDetail>()
            .FirstOrDefaultAsync(login => login.LoginId == email, cancellationToken);

    public async Task<LoginDetail?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LoginDetail>()
            .FirstOrDefaultAsync(login => login.Id == id, cancellationToken);

    public async Task<LoginDetail?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<LoginDetail>()
            .FirstOrDefaultAsync(login => login.LoginUserName == name, cancellationToken);

    public async Task<bool> IsEmailUniqueAsync(string email, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<LoginDetail>()
            .AnyAsync(login => login.LoginId == email, cancellationToken);

    public async Task<bool> IsValidCredentialAsync(string email, string password, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<LoginDetail>()
            .AnyAsync(login => login.LoginId == email && login.LoginPwd == password, cancellationToken);

    public async Task UpdateUser(LoginDetail existingUser) =>
        await Update(existingUser);
}

internal class RoleRepository : GenericRepository<AppRoleLoginDetail>, IRoleRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RoleRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddUserRole(AppRoleLoginDetail newUserRol) =>
        await Add(newUserRol);

    public async Task<List<AppRole>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<AppRole>()
            .ToListAsync(cancellationToken);

    public async Task<AppRole?> GetRoleFromEnum(Roles role, CancellationToken cancellationToken = default) =>
           await _dbContext
              .Set<AppRole>()
              .FirstOrDefaultAsync(role => role.Name == role.ToString(), cancellationToken);
}
