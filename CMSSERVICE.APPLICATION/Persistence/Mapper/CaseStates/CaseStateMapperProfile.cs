using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.CaseStates;

public class CaseStateMapperProfile : Profile
{
    public CaseStateMapperProfile()
    {
        CreateMap<CaseState, CaseStateResponse>().ReverseMap();

        CreateMap<CaseState, CaseStateRequest>().ReverseMap();

        CreateMap<CaseState, AllCaseStateResponse>().ReverseMap();

        CreateMap<List<CaseState>, AllCaseStateResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new CaseStateResponse()
                    {
                        Id = t.Id,
                        StateName = t.StateName,
                        StateAbbrev = t.StateAbbrev
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
