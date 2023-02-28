using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;
using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.PermissionMappers;

public class RolePermissionMapperProfile : Profile
{
    public RolePermissionMapperProfile()
    {
        CreateMap<AppRolePermission, RolePermissionResponse>().ReverseMap();

        CreateMap<AppRolePermission, RolePermissionRequest>().ReverseMap();

        CreateMap<AppRolePermission, AllPermissionResponse>().ReverseMap();

        CreateMap<List<AppRolePermission>, AllPermissionResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new RolePermissionResponse()
                    {
                        Id = t.Id,
                        AppPermissionId = t.AppPermissionId,
                        AppRoleId = t.AppRoleId
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
