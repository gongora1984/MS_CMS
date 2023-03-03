using CMSSERVICE.DOMAIN.Contracts.Responses.JobTypes;

namespace CMSSERVICE.APPLICATION.Persistence.JobTypes.Queries;

public record GetAllJobTypeQuery : IQuery<AllJobTypeResponse>;

public record GetJobTypeByIdQuery(int id) : IQuery<JobTypeResponse>;

public record GetJobTypeByNameQuery(string name) : IQuery<JobTypeResponse>;

public record GetJobTypeBySysCodeQuery(string name) : IQuery<JobTypeResponse>;
