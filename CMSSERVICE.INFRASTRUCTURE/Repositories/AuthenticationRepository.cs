using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class AuthenticationRepository : IAuthenticationRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IRoleRepository _roleRepository;
    private readonly IAppRoleLoginDetailRepository _appRoleLoginDetailRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AuthenticationRepository(
        ApplicationDbContext dbContext,
        IRoleRepository roleRepository,
        IAppRoleLoginDetailRepository appRoleLoginDetailRepository,
        IUnitOfWork unitOfWork)
    {
        _dbContext = dbContext;
        _roleRepository = roleRepository;
        _appRoleLoginDetailRepository = appRoleLoginDetailRepository;
        _unitOfWork = unitOfWork;
    }

    public void AddUser(LoginDetail newUser) =>
         _dbContext.Set<LoginDetail>().Add(newUser);

    public async Task AddUserWithRoles(LoginDetail newUser, AppRole? userRole, CancellationToken cancellationToken = default)
    {
        using (var transaction = _dbContext.Database.BeginTransaction())
        {
            try
            {
                AddUser(newUser);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                if (userRole != null)
                {
                    var newUserRole = new AppRoleLoginDetail
                    {
                        AppRoleId = userRole.Id,
                        LoginDetailId = newUser.Id
                    };

                    _appRoleLoginDetailRepository.AddUserRole(newUserRole);

                    await _unitOfWork.SaveChangesAsync(cancellationToken);

                    transaction.Commit();
                }
                else
                {
                    transaction.Rollback();
                }
            }
            catch
            {
                transaction.Rollback();
            }
        }
    }

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

    public void UpdateUser(LoginDetail existingUser) =>
        _dbContext.Set<LoginDetail>().Update(existingUser);
}
