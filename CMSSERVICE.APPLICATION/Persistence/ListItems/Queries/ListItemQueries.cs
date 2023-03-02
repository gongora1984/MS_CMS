using CMSSERVICE.DOMAIN.Contracts.Responses.ListItems;

namespace CMSSERVICE.APPLICATION.Persistence.ListItems.Queries;

public record GetAllListItemQuery : IQuery<AllListItemResponse>;

public record GetListItemByIdQuery(int id) : IQuery<ListItemResponse>;

public record GetListItemByCategoryQuery(string category) : IQuery<AllListItemResponse>;

public record GetListItemByTagQuery(string tag) : IQuery<AllListItemResponse>;

public record GetListItemBySystemCategoryTagQuery(string category, string tag) : IQuery<AllListItemResponse>;

public record GetListItemBySystemCategoryTagDisplayTextQuery(string category, string tag, string displayText) : IQuery<ListItemResponse>;
