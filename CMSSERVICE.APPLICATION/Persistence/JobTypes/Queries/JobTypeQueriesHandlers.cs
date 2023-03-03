using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.JobTypes;

namespace CMSSERVICE.APPLICATION.Persistence.JobTypes.Queries;

/// <summary>
/// Get list of all JT.
/// </summary>
internal sealed class GetAllJobTypeQueryHandler : IQueryHandler<GetAllJobTypeQuery, AllJobTypeResponse>
{
    private readonly IJobTypeRepository _jobTypeRepository;
    private readonly IMapper _mapper;

    public GetAllJobTypeQueryHandler(IJobTypeRepository JobTypeRepository, IMapper mapper)
    {
        _jobTypeRepository = JobTypeRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllJobTypeResponse>> Handle(GetAllJobTypeQuery request, CancellationToken cancellationToken)
    {
        var roles = await _jobTypeRepository.GetAllAsync();

        var rtn = _mapper.Map<AllJobTypeResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get JT By Id Query Handler.
/// </summary>
internal sealed class GetJobTypeByIdQueryHandler : IQueryHandler<GetJobTypeByIdQuery, JobTypeResponse>
{
    private readonly IJobTypeRepository _jobTypeRepository;
    private readonly IMapper _mapper;

    public GetJobTypeByIdQueryHandler(IJobTypeRepository JobTypeRepository, IMapper mapper)
    {
        _jobTypeRepository = JobTypeRepository;
        _mapper = mapper;
    }

    public async Task<Result<JobTypeResponse>> Handle(GetJobTypeByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _jobTypeRepository.GetByIdAsync(request.id);

        if (role is null)
        {
            return Result.Failure<JobTypeResponse>(new Error(
                "JobType.JobTypeId",
                $"Job Type with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<JobTypeResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get JT By Name Query Handler.
/// </summary>
internal sealed class GetJobTypeByNameQueryHandler : IQueryHandler<GetJobTypeByNameQuery, JobTypeResponse>
{
    private readonly IJobTypeRepository _jobTypeRepository;
    private readonly IMapper _mapper;

    public GetJobTypeByNameQueryHandler(IJobTypeRepository JobTypeRepository, IMapper mapper)
    {
        _jobTypeRepository = JobTypeRepository;
        _mapper = mapper;
    }

    public async Task<Result<JobTypeResponse>> Handle(GetJobTypeByNameQuery request, CancellationToken cancellationToken)
    {
        var role = await _jobTypeRepository.GetByNameAsync(request.name);

        if (role is null)
        {
            return Result.Failure<JobTypeResponse>(new Error(
                "JobType.JobName",
                $"Job Type with name {request.name} was not found"));
        }

        var rtn = _mapper.Map<JobTypeResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get JT By Name Query Handler.
/// </summary>
internal sealed class GetJobTypeBySysCodeQueryHandler : IQueryHandler<GetJobTypeBySysCodeQuery, JobTypeResponse>
{
    private readonly IJobTypeRepository _jobTypeRepository;
    private readonly IMapper _mapper;

    public GetJobTypeBySysCodeQueryHandler(IJobTypeRepository JobTypeRepository, IMapper mapper)
    {
        _jobTypeRepository = JobTypeRepository;
        _mapper = mapper;
    }

    public async Task<Result<JobTypeResponse>> Handle(GetJobTypeBySysCodeQuery request, CancellationToken cancellationToken)
    {
        var role = await _jobTypeRepository.GetByNameAsync(request.name);

        if (role is null)
        {
            return Result.Failure<JobTypeResponse>(new Error(
                "JobType.JobSysCode",
                $"Job Type with syscode {request.name} was not found"));
        }

        var rtn = _mapper.Map<JobTypeResponse>(role);

        return rtn;
    }
}
