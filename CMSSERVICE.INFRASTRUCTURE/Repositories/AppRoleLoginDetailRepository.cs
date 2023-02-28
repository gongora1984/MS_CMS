using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class AppRoleLoginDetailRepository : GenericRepository<AppRoleLoginDetail>, IAppRoleLoginDetailRepository
{
    private readonly ApplicationDbContext _dbContext;
    public AppRoleLoginDetailRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddUserRole(AppRoleLoginDetail newUserRol) =>
        await Add(newUserRol);
}
