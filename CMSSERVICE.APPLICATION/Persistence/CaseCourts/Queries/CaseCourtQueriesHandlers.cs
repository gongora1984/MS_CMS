using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCourts.Queries;

/// <summary>
/// Get list of all case courts.
/// </summary>
internal sealed class GetAllCaseCourtQueryHandler : IQueryHandler<GetAllCaseCourtQuery, AllCaseCourtResponse>
{
    private readonly ICaseCourtRepository _caseCourtRepository;
    private readonly IMapper _mapper;

    public GetAllCaseCourtQueryHandler(ICaseCourtRepository caseCourtRepository, IMapper mapper)
    {
        _caseCourtRepository = caseCourtRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseCourtResponse>> Handle(GetAllCaseCourtQuery request, CancellationToken cancellationToken)
    {
        var counties = await _caseCourtRepository.GetAllAsync();

        var rtn = _mapper.Map<AllCaseCourtResponse>(counties);

        return rtn;
    }
}

/// <summary>
/// Get Case Court By Id Query Handler.
/// </summary>
internal sealed class GetCaseCourtByIdQueryHandler : IQueryHandler<GetCaseCourtByIdQuery, CaseCourtResponse>
{
    private readonly ICaseCourtRepository _caseCourtRepository;
    private readonly IMapper _mapper;

    public GetCaseCourtByIdQueryHandler(ICaseCourtRepository caseCourtRepository, IMapper mapper)
    {
        _caseCourtRepository = caseCourtRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseCourtResponse>> Handle(GetCaseCourtByIdQuery request, CancellationToken cancellationToken)
    {
        var court = await _caseCourtRepository.GetByIdAsync(request.courtId);

        if (court is null)
        {
            return Result.Failure<CaseCourtResponse>(new Error(
                "CaseCourt.Id",
                $"Case Court with Id {request.courtId} was not found"));
        }

        var rtn = _mapper.Map<CaseCourtResponse>(court);

        return rtn;
    }
}

/// <summary>
/// Get list of all case courts by county.
/// </summary>
internal sealed class GetAllCaseCourtByCountyQueryHandler : IQueryHandler<GetAllCaseCourtByCountyQuery, AllCaseCourtResponse>
{
    private readonly ICaseCourtRepository _caseCourtRepository;
    private readonly IMapper _mapper;

    public GetAllCaseCourtByCountyQueryHandler(ICaseCourtRepository caseCourtRepository, IMapper mapper)
    {
        _caseCourtRepository = caseCourtRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseCourtResponse>> Handle(GetAllCaseCourtByCountyQuery request, CancellationToken cancellationToken)
    {
        var counties = await _caseCourtRepository.GetAllByCountyAsync(request.countyId);

        var rtn = _mapper.Map<AllCaseCourtResponse>(counties);

        return rtn;
    }
}

/// <summary>
/// Get list of all case courts by district.
/// </summary>
internal sealed class GetAllCaseCourtByDistrictQueryHandler : IQueryHandler<GetAllCaseCourtByDistrictQuery, AllCaseCourtResponse>
{
    private readonly ICaseCourtRepository _caseCourtRepository;
    private readonly IMapper _mapper;

    public GetAllCaseCourtByDistrictQueryHandler(ICaseCourtRepository caseCourtRepository, IMapper mapper)
    {
        _caseCourtRepository = caseCourtRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseCourtResponse>> Handle(GetAllCaseCourtByDistrictQuery request, CancellationToken cancellationToken)
    {
        var counties = await _caseCourtRepository.GetAllByDistrictAsync(request.districtId);

        var rtn = _mapper.Map<AllCaseCourtResponse>(counties);

        return rtn;
    }
}

/// <summary>
/// Get list of all case courts by name.
/// </summary>
internal sealed class GetAllCaseCourtByNameQueryHandler : IQueryHandler<GetAllCaseCourtByNameQuery, AllCaseCourtResponse>
{
    private readonly ICaseCourtRepository _caseCourtRepository;
    private readonly IMapper _mapper;

    public GetAllCaseCourtByNameQueryHandler(ICaseCourtRepository caseCourtRepository, IMapper mapper)
    {
        _caseCourtRepository = caseCourtRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseCourtResponse>> Handle(GetAllCaseCourtByNameQuery request, CancellationToken cancellationToken)
    {
        var counties = await _caseCourtRepository.GetAllByNameAsync(request.courtName);

        var rtn = _mapper.Map<AllCaseCourtResponse>(counties);

        return rtn;
    }
}

/// <summary>
/// Get list of all case courts by court type.
/// </summary>
internal sealed class GetAllCaseCourtByTypeQueryHandler : IQueryHandler<GetAllCaseCourtByTypeQuery, AllCaseCourtResponse>
{
    private readonly ICaseCourtRepository _caseCourtRepository;
    private readonly IMapper _mapper;

    public GetAllCaseCourtByTypeQueryHandler(ICaseCourtRepository caseCourtRepository, IMapper mapper)
    {
        _caseCourtRepository = caseCourtRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseCourtResponse>> Handle(GetAllCaseCourtByTypeQuery request, CancellationToken cancellationToken)
    {
        var counties = await _caseCourtRepository.GetAllByTypeAsync(request.courtTypeLid);

        var rtn = _mapper.Map<AllCaseCourtResponse>(counties);

        return rtn;
    }
}