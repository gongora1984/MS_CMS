using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCourts.Commands;

internal sealed class RegisterCaseCourtCommandHandler : ICommandHandler<RegisterCaseCourtCommand, CaseCourtResponse>
{
    private readonly ICaseCountyRepository _caseCountyRepository;
    private readonly ICaseDistrictRepository _caseDistrictRepository;
    private readonly ICaseCourtRepository _caseCourtRepository;
    private readonly IListItemRepository _listItemRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterCaseCourtCommandHandler(
        ICaseCountyRepository caseCountyRepository,
        ICaseDistrictRepository caseDistrictRepository,
        IListItemRepository listItemRepository,
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ICaseCourtRepository caseCourtRepository)
    {
        _caseCountyRepository = caseCountyRepository;
        _caseDistrictRepository = caseDistrictRepository;
        _listItemRepository = listItemRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _caseCourtRepository = caseCourtRepository;
    }

    public async Task<Result<CaseCourtResponse>> Handle(RegisterCaseCourtCommand request, CancellationToken cancellationToken)
    {
        if (await _caseCountyRepository.GetByIdAsync(request.caseCourt.CaseCountyId, cancellationToken) is null)
        {
            return Result.Failure<CaseCourtResponse>(
                CaseCountyError.CountyById);
        }

        if (request.caseCourt.CaseDistrictId is not null && request.caseCourt.CaseDistrictId > 0)
        {
            if (await _caseDistrictRepository.GetByIdAsync(Convert.ToInt32(request.caseCourt.CaseDistrictId), cancellationToken) is null)
            {
                return Result.Failure<CaseCourtResponse>(
                    CaseDistrictError.CaseDistrictById);
            }
        }

        if (request.caseCourt.CourtTypeLid is not null && request.caseCourt.CourtTypeLid > 0)
        {
            if (await _listItemRepository.GetByIdAsync(Convert.ToInt32(request.caseCourt.CourtTypeLid), cancellationToken) is null)
            {
                return Result.Failure<CaseCourtResponse>(
                    ListItemError.ListItemById);
            }
        }

        if (!await _caseCourtRepository.IsNameUniqueAsync(
            request.caseCourt.CaseCountyId,
            Convert.ToInt32(request.caseCourt.CaseDistrictId),
            Convert.ToInt32(request.caseCourt.CourtTypeLid),
            request.caseCourt.CourtName,
            cancellationToken))
        {
            return Result.Failure<CaseCourtResponse>(
                CaseCourtError.CaseCourtInUse);
        }

        try
        {
            var newCaseCourt = _mapper.Map<CaseCourt>(request.caseCourt);

            if (newCaseCourt.CaseDistrictId == 0)
            {
                newCaseCourt.CaseDistrictId = null;
            }

            if (newCaseCourt.CourtTypeLid == 0)
            {
                newCaseCourt.CourtTypeLid = null;
            }

            _caseCourtRepository.AddCaseCourt(newCaseCourt);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<CaseCourtResponse>(newCaseCourt);
        }
        catch (Exception ex)
        {
            return Result.Failure<CaseCourtResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
