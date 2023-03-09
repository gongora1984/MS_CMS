using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseJudges.Commands;

public record RegisterCaseJudgeCommand(CaseJudgeRequest caseJudge) : ICommand<CaseJudgeResponse>;
