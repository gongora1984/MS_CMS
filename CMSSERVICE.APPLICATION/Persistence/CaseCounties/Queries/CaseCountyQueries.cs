using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCounties.Queries;

public record GetAllCaseCountyQuery : IQuery<AllCaseCountyResponse>;

public record GetCaseCountyByIdQuery(int id) : IQuery<CaseCountyResponse>;

public record GetCaseCountyByNameQuery(string name) : IQuery<CaseCountyResponse>;
