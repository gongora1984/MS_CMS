using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.LawPratices;

namespace CMSSERVICE.APPLICATION.Persistence.LawPractices.Commands;

internal sealed class LawPracticeCommandHandler : ICommandHandler<RegisterLawPracticeCommand, LawPracticeResponse>
{
    private readonly ILawPracticeRepository _lawPracticeRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LawPracticeCommandHandler(ILawPracticeRepository lawPracticeRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _lawPracticeRepository = lawPracticeRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<LawPracticeResponse>> Handle(RegisterLawPracticeCommand request, CancellationToken cancellationToken)
    {
        if (!await _lawPracticeRepository.IsNameUniqueAsync(request.lp.practiceName, cancellationToken))
        {
            return Result.Failure<LawPracticeResponse>(
                LawPracticeError.LawPracticeNameInUse);
        }

        try
        {
            var newLp = _mapper.Map<LawPractice>(request.lp);

            if (newLp.ClientId == 0)
            {
                newLp.ClientId = null;
            }

            _lawPracticeRepository.AddLawPractice(newLp);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<LawPracticeResponse>(newLp);
        }
        catch (Exception ex)
        {
            return Result.Failure<LawPracticeResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
