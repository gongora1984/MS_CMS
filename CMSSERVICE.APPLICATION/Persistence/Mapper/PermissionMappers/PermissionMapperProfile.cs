using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;
using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.PermissionMappers;

public class PermissionMapperProfile : Profile
{
    public PermissionMapperProfile()
    {
        CreateMap<AppPermission, PermissionResponse>().ReverseMap();

        CreateMap<AppPermission, PermissionRequest>().ReverseMap();

        CreateMap<AppPermission, AllPermissionResponse>().ReverseMap();

        CreateMap<List<AppPermission>, AllPermissionResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new PermissionResponse()
                    {
                        Id = t.Id,
                        Name = t.Name
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
