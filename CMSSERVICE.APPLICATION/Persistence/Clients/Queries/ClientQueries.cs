using CMSSERVICE.DOMAIN.Contracts.Responses.Clients;

namespace CMSSERVICE.APPLICATION.Persistence.Clients.Queries;

public record GetAllClientQuery : IQuery<AllClientResponse>;

public record GetClientByIdQuery(int id) : IQuery<ClientResponse>;

public record GetClientByNameQuery(string name) : IQuery<ClientResponse>;
