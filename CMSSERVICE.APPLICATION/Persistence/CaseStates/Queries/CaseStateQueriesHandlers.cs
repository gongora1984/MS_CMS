using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseStates.Queries;

/// <summary>
/// Get list of all case states.
/// </summary>
internal sealed class GetAllCaseStateQueryHandler : IQueryHandler<GetAllCaseStateQuery, AllCaseStateResponse>
{
    private readonly ICaseStateRepository _caseStateRepository;
    private readonly IMapper _mapper;

    public GetAllCaseStateQueryHandler(ICaseStateRepository caseStateRepository, IMapper mapper)
    {
        _caseStateRepository = caseStateRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseStateResponse>> Handle(GetAllCaseStateQuery request, CancellationToken cancellationToken)
    {
        var roles = await _caseStateRepository.GetAllAsync();

        var rtn = _mapper.Map<AllCaseStateResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get Case State By Id Query Handler.
/// </summary>
internal sealed class GetCaseStateByIdQueryHandler : IQueryHandler<GetCaseStateByIdQuery, CaseStateResponse>
{
    private readonly ICaseStateRepository _caseStateRepository;
    private readonly IMapper _mapper;

    public GetCaseStateByIdQueryHandler(ICaseStateRepository caseStateRepository, IMapper mapper)
    {
        _caseStateRepository = caseStateRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseStateResponse>> Handle(GetCaseStateByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _caseStateRepository.GetByIdAsync(request.id);

        if (role is null)
        {
            return Result.Failure<CaseStateResponse>(new Error(
                "CaseState.Id",
                $"Case State with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<CaseStateResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get Case State By Name Query Handler.
/// </summary>
internal sealed class GetCaseStateByNameQueryHandler : IQueryHandler<GetCaseStateByNameQuery, CaseStateResponse>
{
    private readonly ICaseStateRepository _caseStateRepository;
    private readonly IMapper _mapper;

    public GetCaseStateByNameQueryHandler(ICaseStateRepository caseStateRepository, IMapper mapper)
    {
        _caseStateRepository = caseStateRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseStateResponse>> Handle(GetCaseStateByNameQuery request, CancellationToken cancellationToken)
    {
        var role = await _caseStateRepository.GetByNameAsync(request.name);

        if (role is null)
        {
            return Result.Failure<CaseStateResponse>(new Error(
                "CaseState.StateName",
                $"Case State with name {request.name} was not found"));
        }

        var rtn = _mapper.Map<CaseStateResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get Case State By Abbreviation Query Handler.
/// </summary>
internal sealed class GetCaseStateByAbbrevQueryHandler : IQueryHandler<GetCaseStateByAbbrevQuery, CaseStateResponse>
{
    private readonly ICaseStateRepository _caseStateRepository;
    private readonly IMapper _mapper;

    public GetCaseStateByAbbrevQueryHandler(ICaseStateRepository caseStateRepository, IMapper mapper)
    {
        _caseStateRepository = caseStateRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseStateResponse>> Handle(GetCaseStateByAbbrevQuery request, CancellationToken cancellationToken)
    {
        var role = await _caseStateRepository.GetByAbbrevAsync(request.abbrev);

        if (role is null)
        {
            return Result.Failure<CaseStateResponse>(new Error(
                "CaseState.StateAbbrev",
                $"Case State with name {request.abbrev} was not found"));
        }

        var rtn = _mapper.Map<CaseStateResponse>(role);

        return rtn;
    }
}
