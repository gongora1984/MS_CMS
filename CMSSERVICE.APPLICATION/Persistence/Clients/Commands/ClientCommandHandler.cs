using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Clients;

namespace CMSSERVICE.APPLICATION.Persistence.Clients.Commands;

internal sealed class ClientCommandHandler : ICommandHandler<RegisterClientCommand, ClientResponse>
{
    private readonly IClientRepository _clientRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ClientCommandHandler(IClientRepository clientRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<ClientResponse>> Handle(RegisterClientCommand request, CancellationToken cancellationToken)
    {
        if (!await _clientRepository.IsNameUniqueAsync(request.client.clientName, cancellationToken))
        {
            return Result.Failure<ClientResponse>(
                ClientError.ClientNameInUse);
        }

        try
        {
            var newClient = _mapper.Map<Client>(request.client);

            _clientRepository.AddClient(newClient);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ClientResponse>(newClient);
        }
        catch (Exception ex)
        {
            return Result.Failure<ClientResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
