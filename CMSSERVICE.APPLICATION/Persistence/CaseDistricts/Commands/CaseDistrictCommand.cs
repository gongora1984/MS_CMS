using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.CaseDistricts;

namespace CMSSERVICE.APPLICATION.Persistence.CaseDistricts.Commands;

public record RegisterCaseDistrictCommand(CaseDistrictRequest caseDistrict) : ICommand<CaseDistrictResponse>;
