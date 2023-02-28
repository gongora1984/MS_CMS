using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;
using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.PermissionMappers;

public class RoleMapperProfile : Profile
{
    public RoleMapperProfile()
    {
        CreateMap<AppRole, RoleResponse>().ReverseMap();

        CreateMap<AppRole, RoleRequest>().ReverseMap();

        CreateMap<AppRole, AllRoleResponse>().ReverseMap();

        CreateMap<List<AppRole>, AllRoleResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new RoleResponse()
                    {
                        Id = t.Id,
                        Name = t.Name
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
