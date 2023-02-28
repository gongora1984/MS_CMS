using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Clients;

namespace CMSSERVICE.APPLICATION.Persistence.Clients.Queries;

/// <summary>
/// Get list of all clients.
/// </summary>
internal sealed class GetAllClientQueryHandler : IQueryHandler<GetAllClientQuery, AllClientResponse>
{
    private readonly IClientRepository _clientRepository;
    private readonly IMapper _mapper;

    public GetAllClientQueryHandler(IClientRepository clientRepository, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllClientResponse>> Handle(GetAllClientQuery request, CancellationToken cancellationToken)
    {
        var roles = await _clientRepository.GetAllAsync();

        var rtn = _mapper.Map<AllClientResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get Client By Id Query Handler.
/// </summary>
internal sealed class GetClientByIdQueryHandler : IQueryHandler<GetClientByIdQuery, ClientResponse>
{
    private readonly IClientRepository _clientRepository;
    private readonly IMapper _mapper;

    public GetClientByIdQueryHandler(IClientRepository clientRepository, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<Result<ClientResponse>> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _clientRepository.GetByIdAsync(request.id);

        if (role is null)
        {
            return Result.Failure<ClientResponse>(new Error(
                "Client.Id",
                $"Client with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<ClientResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get Client By Name Query Handler.
/// </summary>
internal sealed class GetClientByNameQueryHandler : IQueryHandler<GetClientByNameQuery, ClientResponse>
{
    private readonly IClientRepository _clientRepository;
    private readonly IMapper _mapper;

    public GetClientByNameQueryHandler(IClientRepository clientRepository, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<Result<ClientResponse>> Handle(GetClientByNameQuery request, CancellationToken cancellationToken)
    {
        var role = await _clientRepository.GetByNameAsync(request.name);

        if (role is null)
        {
            return Result.Failure<ClientResponse>(new Error(
                "Client.ClientName",
                $"Client with name {request.name} was not found"));
        }

        var rtn = _mapper.Map<ClientResponse>(role);

        return rtn;
    }
}
