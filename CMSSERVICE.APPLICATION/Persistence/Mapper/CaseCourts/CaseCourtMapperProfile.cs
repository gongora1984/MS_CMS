using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.CaseCourts;

public class CaseCourtMapperProfile : Profile
{
    public CaseCourtMapperProfile()
    {
        CreateMap<CaseCourt, CaseCourtResponse>().ReverseMap();

        CreateMap<CaseCourt, CaseCourtRequest>().ReverseMap();

        CreateMap<CaseCourt, AllCaseCourtResponse>().ReverseMap();

        CreateMap<List<CaseCourt>, AllCaseCourtResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new CaseCourtResponse()
                    {
                        Id = t.Id,
                        CourtName = t.CourtName,
                        CountOfficalName = t.CountOfficalName,
                        Address1 = t.Address1,
                        Address2 = t.Address2,
                        City = t.City,
                        State = t.State,
                        Zip = t.Zip,
                        Phone = t.Phone,
                        Fax = t.Fax,
                        Email = t.Email,
                        ClerkContact = t.ClerkContact,
                        CourtCurcit = t.CourtCurcit,
                        PstcurcitCode = t.PstcurcitCode,
                        CourtNotes = t.CourtNotes,
                        Website = t.Website,
                        CaseCountyId = t.CaseCountyId,
                        CaseDistrictId = t.CaseDistrictId,
                        CourtTypeLid = t.CourtTypeLid
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
