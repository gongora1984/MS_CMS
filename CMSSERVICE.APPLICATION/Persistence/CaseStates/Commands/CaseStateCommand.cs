using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseStates.Commands;

public record RegisterCaseStateCommand(CaseStateRequest caseState) : ICommand<CaseStateResponse>;
