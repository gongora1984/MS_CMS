using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.CaseJudgeMappers;

public class CaseJudgeMapperProfile : Profile
{
    public CaseJudgeMapperProfile()
    {
        CreateMap<CaseJudge, CaseJudgeResponse>().ReverseMap();

        CreateMap<CaseJudge, CaseJudgeRequest>().ReverseMap();

        CreateMap<CaseJudge, AllCaseJudgeResponse>().ReverseMap();

        CreateMap<List<CaseJudge>, AllCaseJudgeResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new CaseJudgeResponse()
                    {
                        Id = t.Id,
                        JudgeName = t.JudgeName,
                        JudgeCourtName = t.JudgeCourtName,
                        Address1 = t.Address1,
                        Address2 = t.Address2,
                        Room = t.Room,
                        Location = t.Location,
                        City = t.City,
                        State = t.State,
                        Zip = t.Zip,
                        Phone = t.Phone,
                        Fax = t.Fax,
                        SpeacialInstructions1 = t.SpeacialInstructions1,
                        CaseCourtId = t.CaseCourtId
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
