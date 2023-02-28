using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.LocalCounsels;

namespace CMSSERVICE.APPLICATION.Persistence.LocalCounsels.Queries;

/// <summary>
/// Get list of all LC.
/// </summary>
internal sealed class GetAllLocalCounselQueryHandler : IQueryHandler<GetAllLocalCounselQuery, AllLocalCounselResponse>
{
    private readonly ILocalCounselRepository _localCounselRepository;
    private readonly IMapper _mapper;

    public GetAllLocalCounselQueryHandler(ILocalCounselRepository localCounselRepository, IMapper mapper)
    {
        _localCounselRepository = localCounselRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllLocalCounselResponse>> Handle(GetAllLocalCounselQuery request, CancellationToken cancellationToken)
    {
        var roles = await _localCounselRepository.GetAllAsync();

        var rtn = _mapper.Map<AllLocalCounselResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get LC By Id Query Handler.
/// </summary>
internal sealed class GetLocalCounselByIdQueryHandler : IQueryHandler<GetLocalCounselByIdQuery, LocalCounselResponse>
{
    private readonly ILocalCounselRepository _localCounselRepository;
    private readonly IMapper _mapper;

    public GetLocalCounselByIdQueryHandler(ILocalCounselRepository localCounselRepository, IMapper mapper)
    {
        _localCounselRepository = localCounselRepository;
        _mapper = mapper;
    }

    public async Task<Result<LocalCounselResponse>> Handle(GetLocalCounselByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _localCounselRepository.GetByIdAsync(request.id);

        if (role is null)
        {
            return Result.Failure<LocalCounselResponse>(new Error(
                "LocalCounsel.Id",
                $"Local Counsel with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<LocalCounselResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get LC By Name Query Handler.
/// </summary>
internal sealed class GetLocalCounselByNameQueryHandler : IQueryHandler<GetLocalCounselByNameQuery, LocalCounselResponse>
{
    private readonly ILocalCounselRepository _localCounselRepository;
    private readonly IMapper _mapper;

    public GetLocalCounselByNameQueryHandler(ILocalCounselRepository localCounselRepository, IMapper mapper)
    {
        _localCounselRepository = localCounselRepository;
        _mapper = mapper;
    }

    public async Task<Result<LocalCounselResponse>> Handle(GetLocalCounselByNameQuery request, CancellationToken cancellationToken)
    {
        var role = await _localCounselRepository.GetByNameAsync(request.name);

        if (role is null)
        {
            return Result.Failure<LocalCounselResponse>(new Error(
                "LocalCounsel.LCName",
                $"Local Counsel with name {request.name} was not found"));
        }

        var rtn = _mapper.Map<LocalCounselResponse>(role);

        return rtn;
    }
}
