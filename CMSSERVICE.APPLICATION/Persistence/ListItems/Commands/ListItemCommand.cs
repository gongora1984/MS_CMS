using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.ListItems;

namespace CMSSERVICE.APPLICATION.Persistence.ListItems.Commands;

public record RegisterListItemCommand(ListItemRequest li) : ICommand<ListItemResponse>;
