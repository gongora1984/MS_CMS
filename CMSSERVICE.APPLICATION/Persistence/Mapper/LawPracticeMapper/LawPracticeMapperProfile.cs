using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.LawPratices;
using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.LawPracticeMapper;

public class LawPracticeMapperProfile : Profile
{
    public LawPracticeMapperProfile()
    {
        CreateMap<LawPractice, LawPracticeResponse>().ReverseMap();

        CreateMap<LawPractice, LawPracticeRequest>().ReverseMap();

        CreateMap<LawPractice, AllLawPracticeResponse>().ReverseMap();

        CreateMap<List<LawPractice>, AllLawPracticeResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new LawPracticeResponse()
                    {
                        Id = t.Id,
                        PracticeName = t.PracticeName,
                        PracticeContact = t.PracticeContact,
                        Address1 = t.Address1,
                        Address2 = t.Address2,
                        City = t.City,
                        State = t.State,
                        Zip = t.Zip,
                        ContactBarNumber = t.ContactBarNumber,
                        PracticeLogoLocation = t.PracticeLogoLocation,
                        CurrentCmssystem = t.CurrentCmssystem,
                        HasDevelopmentStaff = t.HasDevelopmentStaff,
                        HasEfileAbility = t.HasEfileAbility,
                        NumberOfAttorneys = t.NumberOfAttorneys,
                        PaymentType = t.PaymentType,
                        CardNumber = t.CardNumber,
                        CardExpirationDate = t.CardExpirationDate,
                        CardName = t.CardName,
                        CardDisplayNumber = t.CardDisplayNumber,
                        ServiceEventsUrl = t.ServiceEventsUrl,
                        ServiceEventsLogon = t.ServiceEventsLogon,
                        ServiceEventsPass = t.ServiceEventsPass,
                        ReferralCompanyCode = t.ReferralCompanyCode,
                        FirmStateCode = t.FirmStateCode,
                        PhoneNumber = t.PhoneNumber,
                        FaxNumber = t.FaxNumber,
                        ClientId = t.ClientId,
                        PracticeTypeLid = t.PracticeTypeLid
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
