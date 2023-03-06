using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCourts.Commands;

public record RegisterCaseCourtCommand(CaseCourtRequest caseCourt) : ICommand<CaseCourtResponse>;