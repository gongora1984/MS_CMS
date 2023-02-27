using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Clients;
using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.ClientMappers;

public class ClientMapperProfile : Profile
{
    public ClientMapperProfile()
    {
        CreateMap<Client, ClientResponse>().ReverseMap();

        CreateMap<Client, ClientRequest>().ReverseMap();

        CreateMap<Client, AllClientResponse>().ReverseMap();

        CreateMap<List<Client>, AllClientResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new ClientResponse()
                    {
                        Id = t.Id,
                        ClientName = t.ClientName,
                        ClientAddress1 = t.ClientAddress1,
                        ClientAddress2 = t.ClientAddress2,
                        ClientCity = t.ClientCity,
                        ClientState = t.ClientState,
                        ClientZip = t.ClientZip,
                        ClientBillAddress1 = t.ClientBillAddress1,
                        ClientBillAddress2 = t.ClientBillAddress2,
                        ClientBillCity = t.ClientBillCity,
                        ClientBillState = t.ClientBillState,
                        ClientBillZip = t.ClientBillZip,
                        ClientMainContact = t.ClientMainContact,
                        ClientMailAlertLogEmail = t.ClientMailAlertLogEmail,
                        ClientLogoLocation = t.ClientLogoLocation,
                        ProvestClientCode = t.ProvestClientCode,
                        ClientFax = t.ClientFax,
                        ClientPhone = t.ClientPhone,
                        UseNativeTasksOnly = t.UseNativeTasksOnly,
                        IsReverseClient = t.IsReverseClient
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
