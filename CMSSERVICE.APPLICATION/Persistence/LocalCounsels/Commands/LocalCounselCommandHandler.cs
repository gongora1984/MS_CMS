using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.LocalCounsels;

namespace CMSSERVICE.APPLICATION.Persistence.LocalCounsels.Commands;

internal sealed class LocalCounselCommandHandler : ICommandHandler<RegisterLocalCounselCommand, LocalCounselResponse>
{
    private readonly ILocalCounselRepository _localCounselRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LocalCounselCommandHandler(ILocalCounselRepository localCounselRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _localCounselRepository = localCounselRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<LocalCounselResponse>> Handle(RegisterLocalCounselCommand request, CancellationToken cancellationToken)
    {
        if (!await _localCounselRepository.IsNameUniqueAsync(request.lc.lcName, cancellationToken))
        {
            return Result.Failure<LocalCounselResponse>(
                LocalCounselError.LocalCounselNameInUse);
        }

        try
        {
            var newLc = _mapper.Map<LocalCounsel>(request.lc);

            if (newLc.LccountyId == 0)
            {
                newLc.LccountyId = null;
            }

            _localCounselRepository.AddLocalCounsel(newLc);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<LocalCounselResponse>(newLc);
        }
        catch (Exception ex)
        {
            return Result.Failure<LocalCounselResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
