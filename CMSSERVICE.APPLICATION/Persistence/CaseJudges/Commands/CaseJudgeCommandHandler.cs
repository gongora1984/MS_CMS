using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseJudges.Commands;

internal sealed class RegisterCaseJudgeCommandHandler : ICommandHandler<RegisterCaseJudgeCommand, CaseJudgeResponse>
{
    private readonly ICaseCourtRepository _caseCourtRepository;
    private readonly ICaseJudgeRepository _caseJudgeRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterCaseJudgeCommandHandler(ICaseCourtRepository caseCourtRepository, ICaseJudgeRepository caseJudgeRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _caseCourtRepository = caseCourtRepository;
        _caseJudgeRepository = caseJudgeRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<CaseJudgeResponse>> Handle(RegisterCaseJudgeCommand request, CancellationToken cancellationToken)
    {
        if (await _caseCourtRepository.GetByIdAsync(request.caseJudge.CaseCourtId, cancellationToken) is null)
        {
            return Result.Failure<CaseJudgeResponse>(
                CaseCourtError.CaseCourtById);
        }

        if (!await _caseJudgeRepository.IsNameUniqueAsync(request.caseJudge.JudgeName, request.caseJudge.CaseCourtId, cancellationToken))
        {
            return Result.Failure<CaseJudgeResponse>(
                CaseJudgeError.CaseJudgeInUse);
        }

        try
        {
            var newCaseJudge = _mapper.Map<CaseJudge>(request.caseJudge);

            _caseJudgeRepository.AddCaseJudge(newCaseJudge);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<CaseJudgeResponse>(newCaseJudge);
        }
        catch (Exception ex)
        {
            return Result.Failure<CaseJudgeResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
