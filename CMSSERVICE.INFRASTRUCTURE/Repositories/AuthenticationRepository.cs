using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Enums;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

public sealed class AuthenticationRepository : IAuthenticationRepository
{
    private readonly ApplicationDbContext _dbContext;

    public AuthenticationRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(LoginDetail newUser) =>
        _dbContext.Set<LoginDetail>().Add(newUser);

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

    public async Task<AppRole?> GetRoleFromEnum(Permission permission, CancellationToken cancellationToken = default) =>
         await _dbContext
            .Set<AppRole>()
            .FirstOrDefaultAsync(role => role.Name == permission.ToString(), cancellationToken);
    public async Task<bool> IsEmailUniqueAsync(string email, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<LoginDetail>()
            .AnyAsync(login => login.LoginId == email, cancellationToken);

    public async Task<bool> IsValidCredentialAsync(string email, string password, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<LoginDetail>()
            .AnyAsync(login => login.LoginId == email && login.LoginPwd == password, cancellationToken);

    public void Update(LoginDetail existingUser) =>
        _dbContext.Set<LoginDetail>().Update(existingUser);
}
