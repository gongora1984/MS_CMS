using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.PermissionMappers;

public class UserRoleMapperProfile : Profile
{
    public UserRoleMapperProfile()
    {
        CreateMap<AppRoleLoginDetail, UserRoleResponse>().ReverseMap();
    }
}
