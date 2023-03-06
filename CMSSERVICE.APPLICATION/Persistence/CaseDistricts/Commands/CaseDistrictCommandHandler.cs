using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.CaseDistricts;

namespace CMSSERVICE.APPLICATION.Persistence.CaseDistricts.Commands;

internal sealed class RegisterCaseDistrictCommandHandler : ICommandHandler<RegisterCaseDistrictCommand, CaseDistrictResponse>
{
    private readonly ICaseStateRepository _caseStateRepository;
    private readonly ICaseDistrictRepository _caseDistrictRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterCaseDistrictCommandHandler(ICaseDistrictRepository caseDistrictRepository, ICaseStateRepository caseStateRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _caseDistrictRepository = caseDistrictRepository;
        _caseStateRepository = caseStateRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<CaseDistrictResponse>> Handle(RegisterCaseDistrictCommand request, CancellationToken cancellationToken)
    {
        if (await _caseStateRepository.GetByIdAsync(request.caseDistrict.CaseStateId, cancellationToken) is null)
        {
            return Result.Failure<CaseDistrictResponse>(
                CaseStateError.CaseStateById);
        }

        if (!await _caseDistrictRepository.IsNameUniqueInStateAsync(request.caseDistrict.DistrictName, request.caseDistrict.CaseStateId, cancellationToken))
        {
            return Result.Failure<CaseDistrictResponse>(
                CaseDistrictError.CaseDistrictNameByStateInUse);
        }

        try
        {
            var newCaseDistrict = _mapper.Map<CaseDistrict>(request.caseDistrict);

            var listOrder = await _caseDistrictRepository.GetListOrderAsync(request.caseDistrict.DistrictName, request.caseDistrict.CaseStateId);

            newCaseDistrict.ListOrder = listOrder == 0 ? 1 : listOrder + 1;

            _caseDistrictRepository.AddCaseDistrict(newCaseDistrict);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<CaseDistrictResponse>(newCaseDistrict);
        }
        catch (Exception ex)
        {
            return Result.Failure<CaseDistrictResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
