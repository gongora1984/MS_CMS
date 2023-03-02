using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.CaseCounties;

public class CaseCountyMapperProfile : Profile
{
    public CaseCountyMapperProfile()
    {
        CreateMap<CaseCounty, CaseCountyResponse>().ReverseMap();

        CreateMap<CaseCounty, CaseCountyRequest>().ReverseMap();

        CreateMap<CaseCounty, AllCaseCountyResponse>().ReverseMap();

        CreateMap<List<CaseCounty>, AllCaseCountyResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new CaseCountyResponse()
                    {
                        Id = t.Id,
                        County = t.County,
                        CaseStateId = t.CaseStateId
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
