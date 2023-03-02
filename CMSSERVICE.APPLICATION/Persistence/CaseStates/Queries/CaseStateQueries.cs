using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseStates.Queries;

public record GetAllCaseStateQuery : IQuery<AllCaseStateResponse>;

public record GetCaseStateByIdQuery(int id) : IQuery<CaseStateResponse>;

public record GetCaseStateByNameQuery(string name) : IQuery<CaseStateResponse>;

public record GetCaseStateByAbbrevQuery(string abbrev) : IQuery<CaseStateResponse>;
