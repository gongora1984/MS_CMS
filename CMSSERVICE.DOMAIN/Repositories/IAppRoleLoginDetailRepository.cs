using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IAppRoleLoginDetailRepository
{
    Task AddUserRole(AppRoleLoginDetail newUserRol);
}
