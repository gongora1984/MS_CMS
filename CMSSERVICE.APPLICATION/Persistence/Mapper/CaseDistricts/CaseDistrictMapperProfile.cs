using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.CaseDistricts;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.CaseDistricts;

public class CaseDistrictMapperProfile : Profile
{
    public CaseDistrictMapperProfile()
    {
        CreateMap<CaseDistrict, CaseDistrictResponse>().ReverseMap();

        CreateMap<CaseDistrict, CaseDistrictRequest>().ReverseMap();

        CreateMap<CaseDistrict, AllCaseDistrictResponse>().ReverseMap();

        CreateMap<List<CaseDistrict>, AllCaseDistrictResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new CaseDistrictResponse()
                    {
                        Id = t.Id,
                        DistrictName = t.DistrictName,
                        ListOrder = t.ListOrder,
                        CaseStateId = t.CaseStateId
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
