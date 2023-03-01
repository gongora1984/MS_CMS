using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IAppRoleLoginDetailRepository
{
    void AddUserRole(AppRoleLoginDetail newUserRol);
}
