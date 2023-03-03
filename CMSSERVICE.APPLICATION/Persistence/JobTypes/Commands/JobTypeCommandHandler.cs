using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.JobTypes;

namespace CMSSERVICE.APPLICATION.Persistence.JobTypes.Commands;

internal sealed class JobTypeCommandHandler : ICommandHandler<RegisterJobTypeCommand, JobTypeResponse>
{
    private readonly IJobTypeRepository _jobTypeRepository;
    private readonly IListItemRepository _listItemRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public JobTypeCommandHandler(IJobTypeRepository JobTypeRepository, IUnitOfWork unitOfWork, IMapper mapper, IListItemRepository listItemRepository)
    {
        _jobTypeRepository = JobTypeRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _listItemRepository = listItemRepository;
    }

    public async Task<Result<JobTypeResponse>> Handle(RegisterJobTypeCommand request, CancellationToken cancellationToken)
    {
        if (!await _jobTypeRepository.IsNameUniqueAsync(request.jt.JobName, cancellationToken))
        {
            return Result.Failure<JobTypeResponse>(
                JobTypeError.JobTypeNameInUse);
        }

        if (await _listItemRepository.GetByIdAsync(request.jt.JobDepartmentId, cancellationToken) is null)
        {
            return Result.Failure<JobTypeResponse>(
                JobTypeError.JobTypeDeparmentId);
        }

        try
        {
            var newLp = _mapper.Map<JobType>(request.jt);

            _jobTypeRepository.AddJobType(newLp);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<JobTypeResponse>(newLp);
        }
        catch (Exception ex)
        {
            return Result.Failure<JobTypeResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
