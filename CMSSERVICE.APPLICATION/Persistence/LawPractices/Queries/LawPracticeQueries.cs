using CMSSERVICE.DOMAIN.Contracts.Responses.LawPratices;

namespace CMSSERVICE.APPLICATION.Persistence.LawPractices.Queries;

public record GetAllLawPracticeQuery : IQuery<AllLawPracticeResponse>;

public record GetLawPracticeByIdQuery(int id) : IQuery<LawPracticeResponse>;

public record GetLawPracticeByNameQuery(string name) : IQuery<LawPracticeResponse>;
