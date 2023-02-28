using CMSSERVICE.DOMAIN.Contracts.Responses.LocalCounsels;

namespace CMSSERVICE.APPLICATION.Persistence.LocalCounsels.Queries;

public record GetAllLocalCounselQuery : IQuery<AllLocalCounselResponse>;

public record GetLocalCounselByIdQuery(int id) : IQuery<LocalCounselResponse>;

public record GetLocalCounselByNameQuery(string name) : IQuery<LocalCounselResponse>;
