using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.CaseDistricts;

namespace CMSSERVICE.APPLICATION.Persistence.CaseDistricts.Queries;

/// <summary>
/// Get Case District By Id Query Handler.
/// </summary>
internal sealed class GetCaseDistrictByIdQueryHandler : IQueryHandler<GetCaseDistrictByIdQuery, CaseDistrictResponse>
{
    private readonly ICaseDistrictRepository _caseDistrictRepository;
    private readonly IMapper _mapper;

    public GetCaseDistrictByIdQueryHandler(ICaseDistrictRepository caseDistrictRepository, IMapper mapper)
    {
        _caseDistrictRepository = caseDistrictRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseDistrictResponse>> Handle(GetCaseDistrictByIdQuery request, CancellationToken cancellationToken)
    {
        var district = await _caseDistrictRepository.GetByIdAsync(request.id);

        if (district is null)
        {
            return Result.Failure<CaseDistrictResponse>(new Error(
                "CaseDistrict.CaseDistrictId",
                $"Case District with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<CaseDistrictResponse>(district);

        return rtn;
    }
}

/// <summary>
/// Get list of all case districts.
/// </summary>
internal sealed class GetAllCaseDistrictQueryHandler : IQueryHandler<GetAllCaseDistrictQuery, AllCaseDistrictResponse>
{
    private readonly ICaseDistrictRepository _caseDistrictRepository;
    private readonly IMapper _mapper;

    public GetAllCaseDistrictQueryHandler(ICaseDistrictRepository caseDistrictRepository, IMapper mapper)
    {
        _caseDistrictRepository = caseDistrictRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseDistrictResponse>> Handle(GetAllCaseDistrictQuery request, CancellationToken cancellationToken)
    {
        var districts = await _caseDistrictRepository.GetAllAsync();

        var rtn = _mapper.Map<AllCaseDistrictResponse>(districts);

        return rtn;
    }
}

/// <summary>
/// Get all districts by state Query Handler.
/// </summary>
internal sealed class GetAllCaseDistrictInStateQueryHandler : IQueryHandler<GetAllCaseDistrictInStateQuery, AllCaseDistrictResponse>
{
    private readonly ICaseDistrictRepository _caseDistrictRepository;
    private readonly IMapper _mapper;

    public GetAllCaseDistrictInStateQueryHandler(ICaseDistrictRepository caseDistrictRepository, IMapper mapper)
    {
        _caseDistrictRepository = caseDistrictRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseDistrictResponse>> Handle(GetAllCaseDistrictInStateQuery request, CancellationToken cancellationToken)
    {
        var districts = await _caseDistrictRepository.GetAllInStateAsync(request.stateId);

        if (districts is null)
        {
            return Result.Failure<AllCaseDistrictResponse>(new Error(
                "CaseDistrict.CaseStateId",
                $"Case Districts for state with id {request.stateId} not found."));
        }

        var rtn = _mapper.Map<AllCaseDistrictResponse>(districts);

        return rtn;
    }
}

/// <summary>
/// Get all districts by name Query Handler.
/// </summary>
internal sealed class GetAllCaseDistrictByNameQueryHandler : IQueryHandler<GetAllCaseDistrictByNameQuery, AllCaseDistrictResponse>
{
    private readonly ICaseDistrictRepository _caseDistrictRepository;
    private readonly IMapper _mapper;

    public GetAllCaseDistrictByNameQueryHandler(ICaseDistrictRepository caseDistrictRepository, IMapper mapper)
    {
        _caseDistrictRepository = caseDistrictRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseDistrictResponse>> Handle(GetAllCaseDistrictByNameQuery request, CancellationToken cancellationToken)
    {
        var districts = await _caseDistrictRepository.GetByNameAsync(request.name);

        if (districts is null)
        {
            return Result.Failure<AllCaseDistrictResponse>(new Error(
                "CaseDistrict.CaseStateId",
                $"Case Districts with name {request.name} not found."));
        }

        var rtn = _mapper.Map<AllCaseDistrictResponse>(districts);

        return rtn;
    }
}

/// <summary>
/// Get case district by name and state Query Handler.
/// </summary>
internal sealed class GetCaseDistrictByNameInStateQueryHandler : IQueryHandler<GetCaseDistrictByNameInStateQuery, CaseDistrictResponse>
{
    private readonly ICaseDistrictRepository _caseDistrictRepository;
    private readonly IMapper _mapper;

    public GetCaseDistrictByNameInStateQueryHandler(ICaseDistrictRepository caseDistrictRepository, IMapper mapper)
    {
        _caseDistrictRepository = caseDistrictRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseDistrictResponse>> Handle(GetCaseDistrictByNameInStateQuery request, CancellationToken cancellationToken)
    {
        var district = await _caseDistrictRepository.GetByNameInStateAsync(request.name, request.stateId);

        if (district is null)
        {
            return Result.Failure<CaseDistrictResponse>(new Error(
                "CaseDistrict.CaseStateId",
                $"Case District with name {request.name} and state id {request.stateId} not found."));
        }

        var rtn = _mapper.Map<CaseDistrictResponse>(district);

        return rtn;
    }
}
