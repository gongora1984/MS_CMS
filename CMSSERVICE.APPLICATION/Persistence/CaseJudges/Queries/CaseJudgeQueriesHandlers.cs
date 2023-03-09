using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseJudges.Queries;

/// <summary>
/// Get Case Judge By Id Query Handler.
/// </summary>
internal sealed class GetCaseJudgeByIdHandler : IQueryHandler<GetCaseJudgeById, CaseJudgeResponse>
{
    private readonly ICaseJudgeRepository _caseJudgeRepository;
    private readonly IMapper _mapper;

    public GetCaseJudgeByIdHandler(ICaseJudgeRepository caseJudgeRepository, IMapper mapper)
    {
        _caseJudgeRepository = caseJudgeRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseJudgeResponse>> Handle(GetCaseJudgeById request, CancellationToken cancellationToken)
    {
        var judge = await _caseJudgeRepository.GetByIdAsync(request.id);

        if (judge is null)
        {
            return Result.Failure<CaseJudgeResponse>(new Error(
                "CaseJudge.CaseJudgeId",
                $"Case Judge with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<CaseJudgeResponse>(judge);

        return rtn;
    }
}

/// <summary>
/// Get By Name and CourtId Handler.
/// </summary>
internal sealed class GetByNameCourtIdHandler : IQueryHandler<GetByNameCourtId, CaseJudgeResponse>
{
    private readonly ICaseJudgeRepository _caseJudgeRepository;
    private readonly IMapper _mapper;

    public GetByNameCourtIdHandler(ICaseJudgeRepository caseJudgeRepository, IMapper mapper)
    {
        _caseJudgeRepository = caseJudgeRepository;
        _mapper = mapper;
    }

    public async Task<Result<CaseJudgeResponse>> Handle(GetByNameCourtId request, CancellationToken cancellationToken)
    {
        var judge = await _caseJudgeRepository.GetByNameCourtIdAsync(request.name, request.courtId);

        if (judge is null)
        {
            return Result.Failure<CaseJudgeResponse>(new Error(
                "CaseJudge",
                $"Case Judge with name {request.name} on court with id {request.courtId} was not found"));
        }

        var rtn = _mapper.Map<CaseJudgeResponse>(judge);

        return rtn;
    }
}

/// <summary>
/// Get list of all case judges.
/// </summary>
internal sealed class GetAllJudgeQueryHandler : IQueryHandler<GetAllJudgeQuery, AllCaseJudgeResponse>
{
    private readonly ICaseJudgeRepository _caseJudgeRepository;
    private readonly IMapper _mapper;

    public GetAllJudgeQueryHandler(ICaseJudgeRepository caseJudgeRepository, IMapper mapper)
    {
        _caseJudgeRepository = caseJudgeRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseJudgeResponse>> Handle(GetAllJudgeQuery request, CancellationToken cancellationToken)
    {
        var districts = await _caseJudgeRepository.GetAllAsync();

        var rtn = _mapper.Map<AllCaseJudgeResponse>(districts);

        return rtn;
    }
}

/// <summary>
/// Get list of all case judges by name.
/// </summary>
internal sealed class GetAllJudgeByNameQueryHandler : IQueryHandler<GetAllJudgeByNameQuery, AllCaseJudgeResponse>
{
    private readonly ICaseJudgeRepository _caseJudgeRepository;
    private readonly IMapper _mapper;

    public GetAllJudgeByNameQueryHandler(ICaseJudgeRepository caseJudgeRepository, IMapper mapper)
    {
        _caseJudgeRepository = caseJudgeRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseJudgeResponse>> Handle(GetAllJudgeByNameQuery request, CancellationToken cancellationToken)
    {
        var districts = await _caseJudgeRepository.GetByNameAsync(request.name);

        var rtn = _mapper.Map<AllCaseJudgeResponse>(districts);

        return rtn;
    }
}

/// <summary>
/// Get list of all case judges by court name.
/// </summary>
internal sealed class GetAllJudgeByCourtNameQueryHandler : IQueryHandler<GetAllJudgeByCourtNameQuery, AllCaseJudgeResponse>
{
    private readonly ICaseJudgeRepository _caseJudgeRepository;
    private readonly IMapper _mapper;

    public GetAllJudgeByCourtNameQueryHandler(ICaseJudgeRepository caseJudgeRepository, IMapper mapper)
    {
        _caseJudgeRepository = caseJudgeRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseJudgeResponse>> Handle(GetAllJudgeByCourtNameQuery request, CancellationToken cancellationToken)
    {
        var districts = await _caseJudgeRepository.GetByCourtNameAsync(request.courtName);

        var rtn = _mapper.Map<AllCaseJudgeResponse>(districts);

        return rtn;
    }
}

/// <summary>
/// Get list of all case judges by court id.
/// </summary>
internal sealed class GetAllJudgeByCourtIdQueryHandler : IQueryHandler<GetAllJudgeByCourtIdQuery, AllCaseJudgeResponse>
{
    private readonly ICaseJudgeRepository _caseJudgeRepository;
    private readonly IMapper _mapper;

    public GetAllJudgeByCourtIdQueryHandler(ICaseJudgeRepository caseJudgeRepository, IMapper mapper)
    {
        _caseJudgeRepository = caseJudgeRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllCaseJudgeResponse>> Handle(GetAllJudgeByCourtIdQuery request, CancellationToken cancellationToken)
    {
        var districts = await _caseJudgeRepository.GetByCourtIdAsync(request.courtId);

        var rtn = _mapper.Map<AllCaseJudgeResponse>(districts);

        return rtn;
    }
}
