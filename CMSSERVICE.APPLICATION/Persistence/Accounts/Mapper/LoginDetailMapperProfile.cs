using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.LoginDetails;
using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Mapper;

public class LoginDetailMapperProfile : Profile
{
    public LoginDetailMapperProfile()
    {
        CreateMap<LoginDetail, LoginDetailResponse>().ReverseMap();

        CreateMap<LoginDetail, AllLoginDetailResponse>().ReverseMap();

        CreateMap<List<LoginDetail>, AllLoginDetailResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new LoginDetailResponse()
                    {
                        Id = t.Id,
                        LoginId = t.LoginId,
                        LoginUserName = t.LoginUserName,
                        IsEnabled = t.IsEnabled,
                        IsApproved = t.IsApproved,
                        Address1 = t.Address1,
                        Address2 = t.Address2,
                        City = t.City,
                        State = t.State,
                        Zip = t.Zip,
                        IsLocked = t.IsLocked,
                        CanAccessMenu = t.CanAccessMenu,
                        CanAccessReports = t.CanAccessReports,
                        IsClientAdmin = t.IsClientAdmin,
                        IsAdmin = t.IsAdmin,
                        IsSysAdmin = t.IsSysAdmin,
                        IsSuperAdmin = t.IsSuperAdmin,
                        LawPracticeId = t.LawPracticeId,
                        ClientId = t.ClientId,
                        LocalCounselId = t.LocalCounselId
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
