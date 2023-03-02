using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCounties.Commands;

public record RegisterCaseCountyCommand(CaseCountyRequest caseCounty) : ICommand<CaseCountyResponse>;
