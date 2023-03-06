using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCounties.Commands;

internal sealed class RegisterCaseCountyCommandHandler : ICommandHandler<RegisterCaseCountyCommand, CaseCountyResponse>
{
    private readonly ICaseCountyRepository _caseCountyRepository;
    private readonly ICaseStateRepository _caseStateRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterCaseCountyCommandHandler(ICaseCountyRepository caseCountyRepository, ICaseStateRepository caseStateRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _caseCountyRepository = caseCountyRepository;
        _caseStateRepository = caseStateRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<CaseCountyResponse>> Handle(RegisterCaseCountyCommand request, CancellationToken cancellationToken)
    {
        if (!await _caseCountyRepository.IsNameUniqueAsync(request.caseCounty.County, cancellationToken))
        {
            return Result.Failure<CaseCountyResponse>(
                CaseCountyError.CaseCountyNameInUse);
        }

        if (await _caseStateRepository.GetByIdAsync(request.caseCounty.CaseStateId, cancellationToken) is null)
        {
            return Result.Failure<CaseCountyResponse>(
                CaseCountyError.CaseStateById);
        }

        try
        {
            var newCaseCounty = _mapper.Map<CaseCounty>(request.caseCounty);

            _caseCountyRepository.AddCaseCounty(newCaseCounty);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<CaseCountyResponse>(newCaseCounty);
        }
        catch (Exception ex)
        {
            return Result.Failure<CaseCountyResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
