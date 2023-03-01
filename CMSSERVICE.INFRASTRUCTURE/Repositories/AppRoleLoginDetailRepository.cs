using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class AppRoleLoginDetailRepository : IAppRoleLoginDetailRepository
{
    private readonly ApplicationDbContext _dbContext;
    public AppRoleLoginDetailRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddUserRole(AppRoleLoginDetail newUserRol) =>
        _dbContext.Set<AppRoleLoginDetail>().Add(newUserRol);
}
