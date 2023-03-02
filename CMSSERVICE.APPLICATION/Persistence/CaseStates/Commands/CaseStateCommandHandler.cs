using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseStates.Commands;

internal sealed class RegisterCaseStateCommandHandler : ICommandHandler<RegisterCaseStateCommand, CaseStateResponse>
{
    private readonly ICaseStateRepository _caseStateRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterCaseStateCommandHandler(ICaseStateRepository caseStateRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _caseStateRepository = caseStateRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<CaseStateResponse>> Handle(RegisterCaseStateCommand request, CancellationToken cancellationToken)
    {
        if (!await _caseStateRepository.IsNameUniqueAsync(request.caseState.StateName, cancellationToken))
        {
            return Result.Failure<CaseStateResponse>(
                CaseStateError.CaseStateNameInUse);
        }

        if (!await _caseStateRepository.IsAbbrevUniqueAsync(request.caseState.StateAbbrev, cancellationToken))
        {
            return Result.Failure<CaseStateResponse>(
                CaseStateError.CaseStateAbbrevInUse);
        }

        try
        {
            var newCaseState = _mapper.Map<CaseState>(request.caseState);

            _caseStateRepository.AddCaseState(newCaseState);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<CaseStateResponse>(newCaseState);
        }
        catch (Exception ex)
        {
            return Result.Failure<CaseStateResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
