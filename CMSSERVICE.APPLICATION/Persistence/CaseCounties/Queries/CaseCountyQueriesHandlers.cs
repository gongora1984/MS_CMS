using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCounties.Queries;

/// <summary>
/// Get list of all case county.
/// </summary>
internal sealed class GetAllCaseCountyQueryHandler : IQueryHandler<GetAllCaseCountyQuery, AllCaseCountyResponse>
{
    private readonly ICaseCountyRepository _caseCountyRepository;
    private readonly IMapper _mapper;

    public GetAllCaseCountyQueryHandler(ICaseCountyRepository CaseCountyRepository, IMapper mapper)
    {
        _caseCountyRepository = CaseCountyRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseCountyResponse>> Handle(GetAllCaseCountyQuery request, CancellationToken cancellationToken)
    {
        var roles = await _caseCountyRepository.GetAllAsync();

        var rtn = _mapper.Map<AllCaseCountyResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get Case County By Id Query Handler.
/// </summary>
internal sealed class GetCaseCountyByIdQueryHandler : IQueryHandler<GetCaseCountyByIdQuery, CaseCountyResponse>
{
    private readonly ICaseCountyRepository _caseCountyRepository;
    private readonly IMapper _mapper;

    public GetCaseCountyByIdQueryHandler(ICaseCountyRepository CaseCountyRepository, IMapper mapper)
    {
        _caseCountyRepository = CaseCountyRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseCountyResponse>> Handle(GetCaseCountyByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _caseCountyRepository.GetByIdAsync(request.id);

        if (role is null)
        {
            return Result.Failure<CaseCountyResponse>(new Error(
                "CaseCounty.Id",
                $"Case County with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<CaseCountyResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get Case County By Name Query Handler.
/// </summary>
internal sealed class GetCaseCountyByNameQueryHandler : IQueryHandler<GetCaseCountyByNameQuery, CaseCountyResponse>
{
    private readonly ICaseCountyRepository _caseCountyRepository;
    private readonly IMapper _mapper;

    public GetCaseCountyByNameQueryHandler(ICaseCountyRepository CaseCountyRepository, IMapper mapper)
    {
        _caseCountyRepository = CaseCountyRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseCountyResponse>> Handle(GetCaseCountyByNameQuery request, CancellationToken cancellationToken)
    {
        var role = await _caseCountyRepository.GetByNameAsync(request.name);

        if (role is null)
        {
            return Result.Failure<CaseCountyResponse>(new Error(
                "CaseCounty.County",
                $"Case County with name {request.name} was not found"));
        }

        var rtn = _mapper.Map<CaseCountyResponse>(role);

        return rtn;
    }
}
