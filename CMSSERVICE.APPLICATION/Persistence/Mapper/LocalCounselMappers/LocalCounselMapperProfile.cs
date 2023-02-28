using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.LocalCounsels;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.LocalCounselMappers;

public class LocalCounselMapperProfile : Profile
{
    public LocalCounselMapperProfile()
    {
        CreateMap<LocalCounsel, LocalCounselResponse>().ReverseMap();

        CreateMap<LocalCounsel, LocalCounselRequest>().ReverseMap();

        CreateMap<LocalCounsel, AllLocalCounselResponse>().ReverseMap();

        CreateMap<List<LocalCounsel>, AllLocalCounselResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new LocalCounselResponse()
                    {
                        Id = t.Id,
                        Lcname = t.Lcname,
                        LccompanyName = t.LccompanyName,
                        LcphoneNumber = t.LcphoneNumber,
                        LcemailAddress = t.LcemailAddress,
                        Lcaddress1 = t.Lcaddress1,
                        Lcaddress2 = t.Lcaddress2,
                        Lccity = t.Lccity,
                        Lcstate = t.Lcstate,
                        Lczip = t.Lczip,
                        LccountyId = t.LccountyId,
                        IsLcactive = t.IsLcactive,
                        LcbarNumber = t.LcbarNumber,
                        LcmoduleType = t.LcmoduleType,
                        LcfaxNumber = t.LcfaxNumber,
                        LogoLocation = t.LogoLocation,
                        LctrackingNumber = t.LctrackingNumber
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
