using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.ListItems;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.ListItemMappers;

public class ListItemMapperProfile : Profile
{
    public ListItemMapperProfile()
    {
        CreateMap<ListItem, ListItemRequest>().ReverseMap();

        CreateMap<ListItem, ListItemResponse>().ReverseMap();

        CreateMap<ListItem, AllListItemResponse>().ReverseMap();

        CreateMap<List<ListItem>, AllListItemResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new ListItemResponse()
                    {
                        Id = t.Id,
                        ClientId = t.ClientId,
                        LawPracticeId = t.LawPracticeId,
                        SystemCategory = t.SystemCategory,
                        SystemTag = t.SystemTag,
                        DisplayText = t.DisplayText,
                        Value1 = t.Value1,
                        Value2 = t.Value2,
                        ListOrder = t.ListOrder,
                        Enabled = t.Enabled,
                        DefValue1 = t.DefValue1,
                        DefValue2 = t.DefValue2,
                        DefValue3 = t.DefValue3,
                        DefValue4 = t.DefValue4,
                        DefValue5 = t.DefValue5,
                        DefValue6 = t.DefValue6,
                        DefaultDateDays = t.DefaultDateDays,
                        MergeText = t.MergeText,
                        MergeValue = t.MergeValue,
                        InvokeAssignment = t.InvokeAssignment
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
