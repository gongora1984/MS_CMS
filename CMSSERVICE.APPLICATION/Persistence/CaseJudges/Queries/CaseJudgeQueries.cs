using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseJudges.Queries;

public record GetCaseJudgeById(int id) : IQuery<CaseJudgeResponse>;

public record GetByNameCourtId(string name, int courtId) : IQuery<CaseJudgeResponse>;

public record GetAllJudgeQuery : IQuery<AllCaseJudgeResponse>;

public record GetAllJudgeByNameQuery(string name) : IQuery<AllCaseJudgeResponse>;

public record GetAllJudgeByCourtNameQuery(string courtName) : IQuery<AllCaseJudgeResponse>;

public record GetAllJudgeByCourtIdQuery(int courtId) : IQuery<AllCaseJudgeResponse>;
