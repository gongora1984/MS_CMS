using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Clients;

namespace CMSSERVICE.APPLICATION.Persistence.Clients.Commands;

public record RegisterClientCommand(ClientRequest client) : ICommand<ClientResponse>;
