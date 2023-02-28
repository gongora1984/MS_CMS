using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.LawPratices;

namespace CMSSERVICE.APPLICATION.Persistence.LawPractices.Queries;

/// <summary>
/// Get list of all LP.
/// </summary>
internal sealed class GetAllLawPracticeQueryHandler : IQueryHandler<GetAllLawPracticeQuery, AllLawPracticeResponse>
{
    private readonly ILawPracticeRepository _lawPracticeRepository;
    private readonly IMapper _mapper;

    public GetAllLawPracticeQueryHandler(ILawPracticeRepository lawPracticeRepository, IMapper mapper)
    {
        _lawPracticeRepository = lawPracticeRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllLawPracticeResponse>> Handle(GetAllLawPracticeQuery request, CancellationToken cancellationToken)
    {
        var roles = await _lawPracticeRepository.GetAllAsync();

        var rtn = _mapper.Map<AllLawPracticeResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get LP By Id Query Handler.
/// </summary>
internal sealed class GetLawPracticeByIdQueryHandler : IQueryHandler<GetLawPracticeByIdQuery, LawPracticeResponse>
{
    private readonly ILawPracticeRepository _lawPracticeRepository;
    private readonly IMapper _mapper;

    public GetLawPracticeByIdQueryHandler(ILawPracticeRepository lawPracticeRepository, IMapper mapper)
    {
        _lawPracticeRepository = lawPracticeRepository;
        _mapper = mapper;
    }

    public async Task<Result<LawPracticeResponse>> Handle(GetLawPracticeByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _lawPracticeRepository.GetByIdAsync(request.id);

        if (role is null)
        {
            return Result.Failure<LawPracticeResponse>(new Error(
                "LawPractice.Id",
                $"Law Practice with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<LawPracticeResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get LP By Name Query Handler.
/// </summary>
internal sealed class GetLawPracticeByNameQueryHandler : IQueryHandler<GetLawPracticeByNameQuery, LawPracticeResponse>
{
    private readonly ILawPracticeRepository _lawPracticeRepository;
    private readonly IMapper _mapper;

    public GetLawPracticeByNameQueryHandler(ILawPracticeRepository lawPracticeRepository, IMapper mapper)
    {
        _lawPracticeRepository = lawPracticeRepository;
        _mapper = mapper;
    }

    public async Task<Result<LawPracticeResponse>> Handle(GetLawPracticeByNameQuery request, CancellationToken cancellationToken)
    {
        var role = await _lawPracticeRepository.GetByNameAsync(request.name);

        if (role is null)
        {
            return Result.Failure<LawPracticeResponse>(new Error(
                "LawPractice.PracticeName",
                $"Law Practice with name {request.name} was not found"));
        }

        var rtn = _mapper.Map<LawPracticeResponse>(role);

        return rtn;
    }
}
